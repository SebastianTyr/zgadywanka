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
            this.labelPropozycja = new System.Windows.Forms.Label();
            this.textBoxPropozycja = new System.Windows.Forms.TextBox();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
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
            this.buttonHistoria.Location = new System.Drawing.Point(12, 381);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(75, 23);
            this.buttonHistoria.TabIndex = 2;
            this.buttonHistoria.Text = "Historia";
            this.buttonHistoria.UseVisualStyleBackColor = true;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(293, 381);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // groupBoxRozgrywka
            // 
            this.groupBoxRozgrywka.Controls.Add(this.labelTime);
            this.groupBoxRozgrywka.Controls.Add(this.labelOdpowiedz);
            this.groupBoxRozgrywka.Controls.Add(this.textBoxPropozycja);
            this.groupBoxRozgrywka.Controls.Add(this.labelPropozycja);
            this.groupBoxRozgrywka.Location = new System.Drawing.Point(12, 181);
            this.groupBoxRozgrywka.Name = "groupBoxRozgrywka";
            this.groupBoxRozgrywka.Size = new System.Drawing.Size(369, 179);
            this.groupBoxRozgrywka.TabIndex = 4;
            this.groupBoxRozgrywka.TabStop = false;
            this.groupBoxRozgrywka.Text = "Rozgrywka";
            this.groupBoxRozgrywka.Visible = false;
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
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(136, 35);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropozycja.TabIndex = 1;
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(32, 77);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(35, 13);
            this.labelOdpowiedz.TabIndex = 2;
            this.labelOdpowiedz.Text = "label2";
            // 
            // labelTime
            // 
            this.labelTime.Location = new System.Drawing.Point(257, 38);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(100, 23);
            this.labelTime.TabIndex = 3;
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 444);
            this.Controls.Add(this.groupBoxRozgrywka);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonHistoria);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

