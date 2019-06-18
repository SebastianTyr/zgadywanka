namespace GraGUI
{
    partial class Historia
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
            this.labelProp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProp
            // 
            this.labelProp.AutoSize = true;
            this.labelProp.Location = new System.Drawing.Point(27, 52);
            this.labelProp.Name = "labelProp";
            this.labelProp.Size = new System.Drawing.Size(35, 13);
            this.labelProp.TabIndex = 0;
            this.labelProp.Text = "label1";
            // 
            // Historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.labelProp);
            this.Name = "Historia";
            this.Text = "Historia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProp;
    }
}