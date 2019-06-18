namespace GraGUI
{
    partial class Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInfoGra = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelOpis1 = new System.Windows.Forms.Label();
            this.labelOpis2 = new System.Windows.Forms.Label();
            this.labelStopka1 = new System.Windows.Forms.Label();
            this.labelStopka2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfoGra
            // 
            this.labelInfoGra.AutoSize = true;
            this.labelInfoGra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfoGra.Location = new System.Drawing.Point(57, 55);
            this.labelInfoGra.Name = "labelInfoGra";
            this.labelInfoGra.Size = new System.Drawing.Size(0, 31);
            this.labelInfoGra.TabIndex = 0;
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAutor.Location = new System.Drawing.Point(58, 139);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(0, 25);
            this.labelAutor.TabIndex = 1;
            // 
            // labelOpis1
            // 
            this.labelOpis1.AutoSize = true;
            this.labelOpis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis1.Location = new System.Drawing.Point(21, 206);
            this.labelOpis1.Name = "labelOpis1";
            this.labelOpis1.Size = new System.Drawing.Size(0, 20);
            this.labelOpis1.TabIndex = 2;
            // 
            // labelOpis2
            // 
            this.labelOpis2.AutoSize = true;
            this.labelOpis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis2.Location = new System.Drawing.Point(88, 242);
            this.labelOpis2.Name = "labelOpis2";
            this.labelOpis2.Size = new System.Drawing.Size(0, 20);
            this.labelOpis2.TabIndex = 3;
            // 
            // labelStopka1
            // 
            this.labelStopka1.AutoSize = true;
            this.labelStopka1.Location = new System.Drawing.Point(161, 363);
            this.labelStopka1.Name = "labelStopka1";
            this.labelStopka1.Size = new System.Drawing.Size(0, 13);
            this.labelStopka1.TabIndex = 4;
            // 
            // labelStopka2
            // 
            this.labelStopka2.AutoSize = true;
            this.labelStopka2.Location = new System.Drawing.Point(117, 389);
            this.labelStopka2.Name = "labelStopka2";
            this.labelStopka2.Size = new System.Drawing.Size(0, 13);
            this.labelStopka2.TabIndex = 5;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.labelStopka2);
            this.Controls.Add(this.labelStopka1);
            this.Controls.Add(this.labelOpis2);
            this.Controls.Add(this.labelOpis1);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelInfoGra);
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoGra;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelOpis1;
        private System.Windows.Forms.Label labelOpis2;
        private System.Windows.Forms.Label labelStopka1;
        private System.Windows.Forms.Label labelStopka2;
    }
}