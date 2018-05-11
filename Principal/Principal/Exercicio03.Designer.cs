namespace Principal
{
    partial class Exercicio03
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
            this.tbnumero1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnumero2 = new System.Windows.Forms.TextBox();
            this.btncGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // tbnumero1
            // 
            this.tbnumero1.Location = new System.Drawing.Point(25, 49);
            this.tbnumero1.Name = "tbnumero1";
            this.tbnumero1.Size = new System.Drawing.Size(100, 20);
            this.tbnumero1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número 2";
            // 
            // tbnumero2
            // 
            this.tbnumero2.Location = new System.Drawing.Point(25, 113);
            this.tbnumero2.Name = "tbnumero2";
            this.tbnumero2.Size = new System.Drawing.Size(100, 20);
            this.tbnumero2.TabIndex = 3;
            // 
            // btncGo
            // 
            this.btncGo.ForeColor = System.Drawing.Color.Red;
            this.btncGo.Location = new System.Drawing.Point(25, 154);
            this.btncGo.Name = "btncGo";
            this.btncGo.Size = new System.Drawing.Size(100, 41);
            this.btncGo.TabIndex = 8;
            this.btncGo.Text = "GO";
            this.btncGo.UseVisualStyleBackColor = true;
            this.btncGo.Click += new System.EventHandler(this.btncGo_Click);
            // 
            // Exercicio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 412);
            this.Controls.Add(this.btncGo);
            this.Controls.Add(this.tbnumero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnumero1);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio03";
            this.Text = "Exercicio03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnumero1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnumero2;
        private System.Windows.Forms.Button btncGo;
    }
}