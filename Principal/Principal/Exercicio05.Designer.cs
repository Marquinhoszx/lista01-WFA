namespace Principal
{
    partial class Exercicio05
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
            this.tbnomecarro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbvalorcarro = new System.Windows.Forms.TextBox();
            this.tbvalorparcela = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbquantidadedevezesqueocarrofoifinanciado = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do carro";
            // 
            // tbnomecarro
            // 
            this.tbnomecarro.Location = new System.Drawing.Point(15, 52);
            this.tbnomecarro.Name = "tbnomecarro";
            this.tbnomecarro.Size = new System.Drawing.Size(182, 20);
            this.tbnomecarro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor do carro";
            // 
            // tbvalorcarro
            // 
            this.tbvalorcarro.Location = new System.Drawing.Point(15, 91);
            this.tbvalorcarro.Name = "tbvalorcarro";
            this.tbvalorcarro.Size = new System.Drawing.Size(182, 20);
            this.tbvalorcarro.TabIndex = 3;
            // 
            // tbvalorparcela
            // 
            this.tbvalorparcela.Location = new System.Drawing.Point(15, 130);
            this.tbvalorparcela.Name = "tbvalorparcela";
            this.tbvalorparcela.Size = new System.Drawing.Size(182, 20);
            this.tbvalorparcela.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor de cada parcela";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade de vezes que o carro foi financiado";
            // 
            // tbquantidadedevezesqueocarrofoifinanciado
            // 
            this.tbquantidadedevezesqueocarrofoifinanciado.Location = new System.Drawing.Point(15, 169);
            this.tbquantidadedevezesqueocarrofoifinanciado.Name = "tbquantidadedevezesqueocarrofoifinanciado";
            this.tbquantidadedevezesqueocarrofoifinanciado.Size = new System.Drawing.Size(182, 20);
            this.tbquantidadedevezesqueocarrofoifinanciado.TabIndex = 7;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(15, 208);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "GOO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Exercicio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 404);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbquantidadedevezesqueocarrofoifinanciado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbvalorparcela);
            this.Controls.Add(this.tbvalorcarro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnomecarro);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio05";
            this.Text = "Exercicio05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnomecarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbvalorcarro;
        private System.Windows.Forms.TextBox tbvalorparcela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbquantidadedevezesqueocarrofoifinanciado;
        private System.Windows.Forms.Button btnGo;
    }
}