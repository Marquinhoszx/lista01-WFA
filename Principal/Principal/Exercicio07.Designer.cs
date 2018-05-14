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
            this.tbroger = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbarvorezinha = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnroger
            // 
            this.btnroger.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnroger.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroger.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnroger.Location = new System.Drawing.Point(34, 82);
            this.btnroger.Name = "btnroger";
            this.btnroger.Size = new System.Drawing.Size(344, 123);
            this.btnroger.TabIndex = 0;
            this.btnroger.Text = "Roger";
            this.btnroger.UseVisualStyleBackColor = false;
            this.btnroger.Click += new System.EventHandler(this.btnroger_Click);
            // 
            // tbroger
            // 
            this.tbroger.Location = new System.Drawing.Point(34, 56);
            this.tbroger.Name = "tbroger";
            this.tbroger.Size = new System.Drawing.Size(344, 20);
            this.tbroger.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escreva roger e aperte no botão roger";
            // 
            // lbarvorezinha
            // 
            this.lbarvorezinha.FormattingEnabled = true;
            this.lbarvorezinha.Location = new System.Drawing.Point(37, 242);
            this.lbarvorezinha.Name = "lbarvorezinha";
            this.lbarvorezinha.Size = new System.Drawing.Size(330, 134);
            this.lbarvorezinha.TabIndex = 3;
            // 
            // Exercicio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 393);
            this.Controls.Add(this.lbarvorezinha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbroger);
            this.Controls.Add(this.btnroger);
            this.Name = "Exercicio07";
            this.Text = "Exercicio07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnroger;
        private System.Windows.Forms.TextBox tbroger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbarvorezinha;
    }
}