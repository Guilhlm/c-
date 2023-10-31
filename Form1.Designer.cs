namespace troca_de_valores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.caixinha1 = new System.Windows.Forms.TextBox();
            this.caixinha2 = new System.Windows.Forms.TextBox();
            this.caixinha3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botao2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Trocar Valores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // caixinha1
            // 
            this.caixinha1.Location = new System.Drawing.Point(334, 163);
            this.caixinha1.Name = "caixinha1";
            this.caixinha1.Size = new System.Drawing.Size(100, 20);
            this.caixinha1.TabIndex = 1;
            // 
            // caixinha2
            // 
            this.caixinha2.Location = new System.Drawing.Point(445, 163);
            this.caixinha2.Name = "caixinha2";
            this.caixinha2.Size = new System.Drawing.Size(100, 20);
            this.caixinha2.TabIndex = 2;
            // 
            // caixinha3
            // 
            this.caixinha3.Location = new System.Drawing.Point(562, 163);
            this.caixinha3.Name = "caixinha3";
            this.caixinha3.Size = new System.Drawing.Size(100, 20);
            this.caixinha3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "numero1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "numero2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "numero3";
            // 
            // botao2
            // 
            this.botao2.Location = new System.Drawing.Point(445, 443);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(100, 38);
            this.botao2.TabIndex = 7;
            this.botao2.Text = "> para <";
            this.botao2.UseVisualStyleBackColor = true;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 599);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caixinha3);
            this.Controls.Add(this.caixinha2);
            this.Controls.Add(this.caixinha1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox caixinha1;
        private System.Windows.Forms.TextBox caixinha2;
        private System.Windows.Forms.TextBox caixinha3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botao2;
    }
}

