namespace Principal
{
    partial class Exercicio02
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
            this.tbquantidadedelitrospordia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbquatidadedeanos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbvalorpolitro = new System.Windows.Forms.TextBox();
            this.btnprosseguir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "quantidade de litros ingeridos por dia\r\n";
            // 
            // tbquantidadedelitrospordia
            // 
            this.tbquantidadedelitrospordia.Location = new System.Drawing.Point(25, 34);
            this.tbquantidadedelitrospordia.Name = "tbquantidadedelitrospordia";
            this.tbquantidadedelitrospordia.Size = new System.Drawing.Size(100, 20);
            this.tbquantidadedelitrospordia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade de anos";
            // 
            // tbquatidadedeanos
            // 
            this.tbquatidadedeanos.Location = new System.Drawing.Point(25, 94);
            this.tbquatidadedeanos.Name = "tbquatidadedeanos";
            this.tbquatidadedeanos.Size = new System.Drawing.Size(100, 20);
            this.tbquatidadedeanos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor pago por litro";
            // 
            // tbvalorpolitro
            // 
            this.tbvalorpolitro.Location = new System.Drawing.Point(25, 163);
            this.tbvalorpolitro.Name = "tbvalorpolitro";
            this.tbvalorpolitro.Size = new System.Drawing.Size(100, 20);
            this.tbvalorpolitro.TabIndex = 5;
            // 
            // btnprosseguir
            // 
            this.btnprosseguir.BackColor = System.Drawing.Color.Fuchsia;
            this.btnprosseguir.ForeColor = System.Drawing.Color.Blue;
            this.btnprosseguir.Location = new System.Drawing.Point(25, 224);
            this.btnprosseguir.Name = "btnprosseguir";
            this.btnprosseguir.Size = new System.Drawing.Size(100, 38);
            this.btnprosseguir.TabIndex = 6;
            this.btnprosseguir.Text = "Prosseguir";
            this.btnprosseguir.UseVisualStyleBackColor = false;
            this.btnprosseguir.Click += new System.EventHandler(this.btnprosseguir_Click);
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 407);
            this.Controls.Add(this.btnprosseguir);
            this.Controls.Add(this.tbvalorpolitro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbquatidadedeanos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbquantidadedelitrospordia);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio02";
            this.Text = "Exercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbquantidadedelitrospordia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbquatidadedeanos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbvalorpolitro;
        private System.Windows.Forms.Button btnprosseguir;
    }
}