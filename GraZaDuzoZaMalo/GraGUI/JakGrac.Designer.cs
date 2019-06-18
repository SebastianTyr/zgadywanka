namespace GraGUI
{
    partial class JakGrac
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
            this.labelTytul = new System.Windows.Forms.Label();
            this.labelOpis1 = new System.Windows.Forms.Label();
            this.labelOpis3 = new System.Windows.Forms.Label();
            this.labelOpis2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTytul
            // 
            this.labelTytul.AutoSize = true;
            this.labelTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTytul.Location = new System.Drawing.Point(115, 38);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(0, 31);
            this.labelTytul.TabIndex = 0;
            // 
            // labelOpis1
            // 
            this.labelOpis1.AutoSize = true;
            this.labelOpis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis1.Location = new System.Drawing.Point(12, 119);
            this.labelOpis1.Name = "labelOpis1";
            this.labelOpis1.Size = new System.Drawing.Size(0, 20);
            this.labelOpis1.TabIndex = 1;
            this.labelOpis1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOpis3
            // 
            this.labelOpis3.AutoSize = true;
            this.labelOpis3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis3.Location = new System.Drawing.Point(12, 207);
            this.labelOpis3.Name = "labelOpis3";
            this.labelOpis3.Size = new System.Drawing.Size(0, 20);
            this.labelOpis3.TabIndex = 5;
            // 
            // labelOpis2
            // 
            this.labelOpis2.AutoSize = true;
            this.labelOpis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis2.Location = new System.Drawing.Point(12, 164);
            this.labelOpis2.Name = "labelOpis2";
            this.labelOpis2.Size = new System.Drawing.Size(0, 20);
            this.labelOpis2.TabIndex = 6;
            // 
            // JakGrac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 312);
            this.Controls.Add(this.labelOpis2);
            this.Controls.Add(this.labelOpis3);
            this.Controls.Add(this.labelOpis1);
            this.Controls.Add(this.labelTytul);
            this.Name = "JakGrac";
            this.Text = "JakGrac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.Label labelOpis1;
        private System.Windows.Forms.Label labelOpis3;
        private System.Windows.Forms.Label labelOpis2;
    }
}