namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.labelZakreDo = new System.Windows.Forms.Label();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBoxRozgrywka = new System.Windows.Forms.GroupBox();
            this.labelCzasGry = new System.Windows.Forms.Label();
            this.labelLicznik = new System.Windows.Forms.Label();
            this.labelWylosowana = new System.Windows.Forms.Label();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonPoddaj = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.textBoxPropozycja = new System.Windows.Forms.TextBox();
            this.labelPropozycja = new System.Windows.Forms.Label();
            this.buttonInstrukcja = new System.Windows.Forms.Button();
            this.groupBoxLosowanie.SuspendLayout();
            this.groupBoxRozgrywka.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(12, 12);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa Gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.Controls.Add(this.buttonWylosuj);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.labelZakreDo);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresOd);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosowanie.Location = new System.Drawing.Point(12, 64);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Size = new System.Drawing.Size(369, 111);
            this.groupBoxLosowanie.TabIndex = 1;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(218, 40);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonWylosuj.TabIndex = 4;
            this.buttonWylosuj.Text = "Wylosuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(67, 59);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresDo.TabIndex = 3;
            this.textBoxZakresDo.Text = "100";
            this.textBoxZakresDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelZakreDo
            // 
            this.labelZakreDo.AutoSize = true;
            this.labelZakreDo.Location = new System.Drawing.Point(6, 62);
            this.labelZakreDo.Name = "labelZakreDo";
            this.labelZakreDo.Size = new System.Drawing.Size(61, 13);
            this.labelZakreDo.TabIndex = 2;
            this.labelZakreDo.Text = "Zakres do: ";
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(6, 26);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(61, 13);
            this.labelZakresOd.TabIndex = 1;
            this.labelZakresOd.Text = "Zakres od: ";
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(67, 23);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresOd.TabIndex = 0;
            this.textBoxZakresOd.Text = "1";
            this.textBoxZakresOd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonHistoria
            // 
            this.buttonHistoria.Location = new System.Drawing.Point(12, 399);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(93, 23);
            this.buttonHistoria.TabIndex = 2;
            this.buttonHistoria.Text = "Statystyki Gry";
            this.buttonHistoria.UseVisualStyleBackColor = true;
            this.buttonHistoria.Click += new System.EventHandler(this.buttonHistoria_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(293, 399);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "O Grze";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // groupBoxRozgrywka
            // 
            this.groupBoxRozgrywka.Controls.Add(this.labelCzasGry);
            this.groupBoxRozgrywka.Controls.Add(this.labelLicznik);
            this.groupBoxRozgrywka.Controls.Add(this.labelWylosowana);
            this.groupBoxRozgrywka.Controls.Add(this.buttonSprawdz);
            this.groupBoxRozgrywka.Controls.Add(this.buttonRestart);
            this.groupBoxRozgrywka.Controls.Add(this.buttonPoddaj);
            this.groupBoxRozgrywka.Controls.Add(this.labelTime);
            this.groupBoxRozgrywka.Controls.Add(this.labelOdpowiedz);
            this.groupBoxRozgrywka.Controls.Add(this.textBoxPropozycja);
            this.groupBoxRozgrywka.Controls.Add(this.labelPropozycja);
            this.groupBoxRozgrywka.Location = new System.Drawing.Point(12, 181);
            this.groupBoxRozgrywka.Name = "groupBoxRozgrywka";
            this.groupBoxRozgrywka.Size = new System.Drawing.Size(369, 212);
            this.groupBoxRozgrywka.TabIndex = 4;
            this.groupBoxRozgrywka.TabStop = false;
            this.groupBoxRozgrywka.Text = "Rozgrywka";
            this.groupBoxRozgrywka.Visible = false;
            // 
            // labelCzasGry
            // 
            this.labelCzasGry.AutoSize = true;
            this.labelCzasGry.Location = new System.Drawing.Point(15, 163);
            this.labelCzasGry.Name = "labelCzasGry";
            this.labelCzasGry.Size = new System.Drawing.Size(0, 13);
            this.labelCzasGry.TabIndex = 9;
            // 
            // labelLicznik
            // 
            this.labelLicznik.AutoSize = true;
            this.labelLicznik.Location = new System.Drawing.Point(12, 131);
            this.labelLicznik.Name = "labelLicznik";
            this.labelLicznik.Size = new System.Drawing.Size(81, 13);
            this.labelLicznik.TabIndex = 8;
            this.labelLicznik.Text = "Liczba Ruchów";
            this.labelLicznik.Visible = false;
            // 
            // labelWylosowana
            // 
            this.labelWylosowana.AutoSize = true;
            this.labelWylosowana.Location = new System.Drawing.Point(12, 101);
            this.labelWylosowana.Name = "labelWylosowana";
            this.labelWylosowana.Size = new System.Drawing.Size(68, 13);
            this.labelWylosowana.TabIndex = 7;
            this.labelWylosowana.Text = "Wylosowana";
            this.labelWylosowana.Visible = false;
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(238, 80);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(96, 23);
            this.buttonSprawdz.TabIndex = 6;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Enabled = false;
            this.buttonRestart.Location = new System.Drawing.Point(238, 141);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(96, 23);
            this.buttonRestart.TabIndex = 5;
            this.buttonRestart.Text = "Zagraj ponownie";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonPoddaj
            // 
            this.buttonPoddaj.Location = new System.Drawing.Point(238, 112);
            this.buttonPoddaj.Name = "buttonPoddaj";
            this.buttonPoddaj.Size = new System.Drawing.Size(96, 23);
            this.buttonPoddaj.TabIndex = 4;
            this.buttonPoddaj.Text = "Poddaj się";
            this.buttonPoddaj.UseVisualStyleBackColor = true;
            this.buttonPoddaj.Click += new System.EventHandler(this.buttonPoddaj_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(259, 38);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(49, 13);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(12, 70);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(0, 13);
            this.labelOdpowiedz.TabIndex = 2;
            this.labelOdpowiedz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(136, 35);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropozycja.TabIndex = 1;
            this.textBoxPropozycja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPropozycja
            // 
            this.labelPropozycja.AutoSize = true;
            this.labelPropozycja.Location = new System.Drawing.Point(9, 38);
            this.labelPropozycja.Name = "labelPropozycja";
            this.labelPropozycja.Size = new System.Drawing.Size(121, 13);
            this.labelPropozycja.TabIndex = 0;
            this.labelPropozycja.Text = "Podaj swoją propozycję:";
            // 
            // buttonInstrukcja
            // 
            this.buttonInstrukcja.Location = new System.Drawing.Point(293, 12);
            this.buttonInstrukcja.Name = "buttonInstrukcja";
            this.buttonInstrukcja.Size = new System.Drawing.Size(75, 23);
            this.buttonInstrukcja.TabIndex = 5;
            this.buttonInstrukcja.Text = "Jak grać";
            this.buttonInstrukcja.UseVisualStyleBackColor = true;
            this.buttonInstrukcja.Click += new System.EventHandler(this.buttonInstrukcja_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 444);
            this.Controls.Add(this.buttonInstrukcja);
            this.Controls.Add(this.groupBoxRozgrywka);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonHistoria);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Gra - Losowanie";
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
            this.groupBoxRozgrywka.ResumeLayout(false);
            this.groupBoxRozgrywka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosowanie;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.Label labelZakreDo;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.Button buttonHistoria;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.GroupBox groupBoxRozgrywka;
        private System.Windows.Forms.Label labelOdpowiedz;
        private System.Windows.Forms.TextBox textBoxPropozycja;
        private System.Windows.Forms.Label labelPropozycja;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonPoddaj;
        private System.Windows.Forms.Button buttonInstrukcja;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Label labelLicznik;
        private System.Windows.Forms.Label labelWylosowana;
        private System.Windows.Forms.Label labelCzasGry;
    }
}

