using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;
using static ModelGry.Gra;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;
        public int liczklik = 0;
        private Timer t = new Timer();
        private TimeSpan timeSpan;
        private readonly TimeSpan sekunda = new TimeSpan(0, 0, 1);
        public Form1()
        {
            InitializeComponent();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
        }

        private void t_Tick(object sender, EventArgs e)
        {
            timeSpan = timeSpan.Add(sekunda);
            labelTime.Text = timeSpan.ToString();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosowanie.Visible = true;
            buttonNowaGra.Enabled = false;
        }

        private void buttonWylosuj_Click(object sender, EventArgs e)
        {
            //liczba kliknięć
            liczklik++;
            try
            {
                t.Start();

                int Od = int.Parse(textBoxZakresOd.Text);
                int Do = int.Parse(textBoxZakresDo.Text);
                if (Od > Do) throw new ArgumentOutOfRangeException();

                g = new Gra(Od, Do);

                buttonWylosuj.Enabled = false;
                groupBoxRozgrywka.Visible = true;
            }
            catch(FormatException)
            {
                MessageBox.Show("Niepoprawny format danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxZakresOd.Clear();
                textBoxZakresDo.Clear();

                t.Stop();
                timeSpan = new TimeSpan(0, 0, 0);
                labelTime.Text = "00:00:00";

                buttonWylosuj.Enabled = true;
                groupBoxRozgrywka.Visible = false;
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Maksymalny zakres nie może być mniejszy od minimalnego", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxZakresOd.Clear();
                textBoxZakresDo.Clear();

                t.Stop();
                timeSpan = new TimeSpan(0, 0, 0);
                labelTime.Text = "00:00:00";

                buttonWylosuj.Enabled = true;
                groupBoxRozgrywka.Visible = false;
            }
            catch(OverflowException)
            {
                MessageBox.Show("Podana wartość jest za duża!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxZakresOd.Clear();
                textBoxZakresDo.Clear();

                t.Stop();
                timeSpan = new TimeSpan(0, 0, 0);
                labelTime.Text = "00:00:00";

                buttonWylosuj.Enabled = true;
                groupBoxRozgrywka.Visible = false;
            }
            labelCzasGry.Text = "";
        }

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            int p = 0;
            try
            {
                p = int.Parse(textBoxPropozycja.Text);
                int Do = int.Parse(textBoxZakresDo.Text);
                if (p > Do) throw new OverflowException();
            }
            catch(FormatException)
            {
                MessageBox.Show("Niepoprawny format danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPropozycja.Clear();
            }
            catch(OverflowException)
            {
                MessageBox.Show("Propozycja wykracza poza zakres losowania!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPropozycja.Clear();
            }
            Odp odp = g.Ocena(p);

            switch(odp)
            {
                case Odp.ZaMalo:
                    {
                        labelOdpowiedz.Text = "Status: " + "Za Mało";
                        labelOdpowiedz.ForeColor = Color.Red;
                        break;
                    }
                case Odp.ZaDuzo:
                    {
                        labelOdpowiedz.Text = "Status: " + "Za Dużo";
                        labelOdpowiedz.ForeColor = Color.Red;
                        break;
                    }
                case Odp.Trafiono:
                    {
                        labelOdpowiedz.Text = "Status: " + "Trafiono";
                        labelOdpowiedz.ForeColor = Color.Green;
                        labelWylosowana.Visible = true;
                        labelWylosowana.Text = "Wylosowana liczba: " + g.CoByloWylosowane();
                        labelLicznik.Visible = true;
                        labelLicznik.Text = "Liczba ruchów: " + g.LicznikRuchow;
                        labelCzasGry.Text = "Czas Gry " + labelTime.Text;
                        t.Stop();
                        statystyki();

                        buttonSprawdz.Enabled = false;
                        buttonRestart.Enabled = true;
                        buttonPoddaj.Enabled = false;
                        break;
                    }
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            groupBoxRozgrywka.Visible = false;
            buttonWylosuj.Enabled = true;
            buttonSprawdz.Enabled = true;
            buttonRestart.Enabled = false;
            buttonPoddaj.Enabled = true;

            labelOdpowiedz.Text = "";
            labelOdpowiedz.ForeColor = Color.Black;
            textBoxPropozycja.Clear();

            labelWylosowana.Visible = false;
            labelLicznik.Visible = false;

            labelTime.Text = "00:00:00";
            timeSpan = new TimeSpan(0, 0, 0);
        }

        private void buttonPoddaj_Click(object sender, EventArgs e)
        {
            g.Poddaj();

            labelOdpowiedz.Text = "Nie udało Ci się odgadnąć";
            labelOdpowiedz.ForeColor = Color.Red;
            labelWylosowana.Text = "Wylosowana liczba to: " + g.CoByloWylosowane();

            labelWylosowana.Visible = true;
            buttonSprawdz.Enabled = false;
            buttonPoddaj.Enabled = false;
            buttonRestart.Enabled = true;
            t.Stop();
        }

        private void buttonHistoria_Click(object sender, EventArgs e)
        {
            statystyki();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void buttonInstrukcja_Click(object sender, EventArgs e)
        {
            JakGrac jakGrac = new JakGrac();
            jakGrac.Show();
        }

        private void statystyki()
        {
            try
            {
                MessageBox.Show($@"Liczba losowań: {liczklik} Liczba Ruchów = {g.LicznikRuchow} Status: {g.Stan} CzasGry: {DateTime.Now}",
                    "Twoje statystyki", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
            }
        }
    }
}
