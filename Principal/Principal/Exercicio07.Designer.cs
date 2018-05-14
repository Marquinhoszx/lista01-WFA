namespace Principal
{
    partial class Exercicio07
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
            this.btnroger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnroger
            // 
            this.btnroger.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnroger.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroger.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnroger.Location = new System.Drawing.Point(26, 12);
            this.btnroger.Name = "btnroger";
            this.btnroger.Size = new System.Drawing.Size(344, 369);
            this.btnroger.TabIndex = 0;
            this.btnroger.Text = "Roger";
            this.btnroger.UseVisualStyleBackColor = false;
            this.btnroger.Click += new System.EventHandler(this.btnroger_Click);
            // 
            // Exercicio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 393);
            this.Controls.Add(this.btnroger);
            this.Name = "Exercicio07";
            this.Text = "Exercicio07";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnroger;
    }
}