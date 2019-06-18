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
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosowanie.Visible = true;
            buttonNowaGra.Enabled = false;
        }

        private void buttonWylosuj_Click(object sender, EventArgs e)
        {
            liczklik++;
            try
            {
                int Od = int.Parse(textBoxZakresOd.Text);
                int Do = int.Parse(textBoxZakresDo.Text);

                g = new Gra(Od, Do);
                buttonWylosuj.Enabled = false;
                groupBoxRozgrywka.Visible = true;
            }
            catch(FormatException)
            {
                MessageBox.Show("Niepoprawny format danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxZakresOd.Clear();
                textBoxZakresDo.Clear();

                buttonWylosuj.Enabled = true;
                groupBoxRozgrywka.Visible = false;
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Maksymalny zakres nie może być mniejszy od minimalnego", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxZakresOd.Clear();
                textBoxZakresDo.Clear();

                buttonWylosuj.Enabled = true;
                groupBoxRozgrywka.Visible = false;
            }
        }

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            int p = 0;
            try
            {
                p = int.Parse(textBoxPropozycja.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Niepoprawny format danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            labelOdpowiedz.Text = "Status";
            labelOdpowiedz.ForeColor = Color.Black;
            textBoxPropozycja.Clear();

            labelWylosowana.Visible = false;
            labelLicznik.Visible = false;
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
        }

        private void buttonHistoria_Click(object sender, EventArgs e)
        {
            Historia historia = new Historia();
            historia.Show();
        }
    }
}
