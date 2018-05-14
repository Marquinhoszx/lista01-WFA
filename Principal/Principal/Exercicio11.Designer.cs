namespace Principal
{
    partial class Exercicio11
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbdia = new System.Windows.Forms.TextBox();
            this.tbmes = new System.Windows.Forms.TextBox();
            this.tbano = new System.Windows.Forms.TextBox();
            this.btngo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia que você usuário nasceu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mês que você usuário nasceu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano que você usuário nasceu";
            // 
            // tbdia
            // 
            this.tbdia.Location = new System.Drawing.Point(166, 31);
            this.tbdia.Name = "tbdia";
            this.tbdia.Size = new System.Drawing.Size(62, 20);
            this.tbdia.TabIndex = 3;
            // 
            // tbmes
            // 
            this.tbmes.Location = new System.Drawing.Point(166, 57);
            this.tbmes.Name = "tbmes";
            this.tbmes.Size = new System.Drawing.Size(62, 20);
            this.tbmes.TabIndex = 4;
            // 
            // tbano
            // 
            this.tbano.Location = new System.Drawing.Point(166, 85);
            this.tbano.Name = "tbano";
            this.tbano.Size = new System.Drawing.Size(62, 20);
            this.tbano.TabIndex = 5;
            // 
            // btngo
            // 
            this.btngo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btngo.Location = new System.Drawing.Point(16, 126);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(146, 49);
            this.btngo.TabIndex = 6;
            this.btngo.Text = "GO";
            this.btngo.UseVisualStyleBackColor = false;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // Exercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 410);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.tbano);
            this.Controls.Add(this.tbmes);
            this.Controls.Add(this.tbdia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio11";
            this.Text = "Exercicio11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbdia;
        private System.Windows.Forms.TextBox tbmes;
        private System.Windows.Forms.TextBox tbano;
        private System.Windows.Forms.Button btngo;
    }
}