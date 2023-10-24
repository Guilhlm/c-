namespace aula1_c_
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
            this.BTNMAIS = new System.Windows.Forms.Button();
            this.TXBNUMERO1 = new System.Windows.Forms.TextBox();
            this.TXBNUMERO2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBRESULTADO = new System.Windows.Forms.Label();
            this.BTNMENOS = new System.Windows.Forms.Button();
            this.BTNDIVIDIR = new System.Windows.Forms.Button();
            this.BTNMULTIPLICAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TXBNUMERO3 = new System.Windows.Forms.TextBox();
            this.BXTMAIOR = new System.Windows.Forms.Button();
            this.BTNPARIMPAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNMAIS
            // 
            this.BTNMAIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMAIS.Location = new System.Drawing.Point(34, 208);
            this.BTNMAIS.Name = "BTNMAIS";
            this.BTNMAIS.Size = new System.Drawing.Size(171, 119);
            this.BTNMAIS.TabIndex = 0;
            this.BTNMAIS.Text = "somar";
            this.BTNMAIS.UseVisualStyleBackColor = true;
            this.BTNMAIS.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXBNUMERO1
            // 
            this.TXBNUMERO1.Location = new System.Drawing.Point(114, 34);
            this.TXBNUMERO1.Name = "TXBNUMERO1";
            this.TXBNUMERO1.Size = new System.Drawing.Size(100, 20);
            this.TXBNUMERO1.TabIndex = 1;
            // 
            // TXBNUMERO2
            // 
            this.TXBNUMERO2.Location = new System.Drawing.Point(114, 79);
            this.TXBNUMERO2.Name = "TXBNUMERO2";
            this.TXBNUMERO2.Size = new System.Drawing.Size(100, 20);
            this.TXBNUMERO2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NUMERO1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NUMERO2";
            // 
            // LBRESULTADO
            // 
            this.LBRESULTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRESULTADO.Location = new System.Drawing.Point(30, 133);
            this.LBRESULTADO.Name = "LBRESULTADO";
            this.LBRESULTADO.Size = new System.Drawing.Size(111, 25);
            this.LBRESULTADO.TabIndex = 5;
            this.LBRESULTADO.Text = "RESULTADO";
            this.LBRESULTADO.Click += new System.EventHandler(this.label3_Click);
            // 
            // BTNMENOS
            // 
            this.BTNMENOS.Location = new System.Drawing.Point(34, 360);
            this.BTNMENOS.Name = "BTNMENOS";
            this.BTNMENOS.Size = new System.Drawing.Size(171, 117);
            this.BTNMENOS.TabIndex = 6;
            this.BTNMENOS.Text = "subtrair";
            this.BTNMENOS.UseVisualStyleBackColor = true;
            this.BTNMENOS.Click += new System.EventHandler(this.BTNMENOS_Click);
            // 
            // BTNDIVIDIR
            // 
            this.BTNDIVIDIR.Location = new System.Drawing.Point(226, 209);
            this.BTNDIVIDIR.Name = "BTNDIVIDIR";
            this.BTNDIVIDIR.Size = new System.Drawing.Size(172, 118);
            this.BTNDIVIDIR.TabIndex = 7;
            this.BTNDIVIDIR.Text = "dividir";
            this.BTNDIVIDIR.UseVisualStyleBackColor = true;
            this.BTNDIVIDIR.Click += new System.EventHandler(this.BTNDIVIDIR_Click);
            // 
            // BTNMULTIPLICAR
            // 
            this.BTNMULTIPLICAR.Location = new System.Drawing.Point(226, 360);
            this.BTNMULTIPLICAR.Name = "BTNMULTIPLICAR";
            this.BTNMULTIPLICAR.Size = new System.Drawing.Size(172, 118);
            this.BTNMULTIPLICAR.TabIndex = 8;
            this.BTNMULTIPLICAR.Text = "multiplicar";
            this.BTNMULTIPLICAR.UseVisualStyleBackColor = true;
            this.BTNMULTIPLICAR.Click += new System.EventHandler(this.BTNMULTIPLICAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DIGITE UM NUMBER";
            // 
            // TXBNUMERO3
            // 
            this.TXBNUMERO3.Location = new System.Drawing.Point(635, 75);
            this.TXBNUMERO3.Name = "TXBNUMERO3";
            this.TXBNUMERO3.Size = new System.Drawing.Size(233, 20);
            this.TXBNUMERO3.TabIndex = 10;
            this.TXBNUMERO3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BXTMAIOR
            // 
            this.BXTMAIOR.Location = new System.Drawing.Point(635, 133);
            this.BXTMAIOR.Name = "BXTMAIOR";
            this.BXTMAIOR.Size = new System.Drawing.Size(114, 90);
            this.BXTMAIOR.TabIndex = 11;
            this.BXTMAIOR.Text = "MENOR OU MAIOR";
            this.BXTMAIOR.UseVisualStyleBackColor = true;
            this.BXTMAIOR.Click += new System.EventHandler(this.BXTMAIOR_Click);
            // 
            // BTNPARIMPAR
            // 
            this.BTNPARIMPAR.Location = new System.Drawing.Point(635, 237);
            this.BTNPARIMPAR.Name = "BTNPARIMPAR";
            this.BTNPARIMPAR.Size = new System.Drawing.Size(114, 90);
            this.BTNPARIMPAR.TabIndex = 12;
            this.BTNPARIMPAR.Text = "IMPAR OU PAR";
            this.BTNPARIMPAR.UseVisualStyleBackColor = true;
            this.BTNPARIMPAR.Click += new System.EventHandler(this.BTNPARIMPAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(911, 540);
            this.Controls.Add(this.BTNPARIMPAR);
            this.Controls.Add(this.BXTMAIOR);
            this.Controls.Add(this.TXBNUMERO3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNMULTIPLICAR);
            this.Controls.Add(this.BTNDIVIDIR);
            this.Controls.Add(this.BTNMENOS);
            this.Controls.Add(this.LBRESULTADO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXBNUMERO2);
            this.Controls.Add(this.TXBNUMERO1);
            this.Controls.Add(this.BTNMAIS);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNMAIS;
        private System.Windows.Forms.TextBox TXBNUMERO1;
        private System.Windows.Forms.TextBox TXBNUMERO2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBRESULTADO;
        private System.Windows.Forms.Button BTNMENOS;
        private System.Windows.Forms.Button BTNDIVIDIR;
        private System.Windows.Forms.Button BTNMULTIPLICAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXBNUMERO3;
        private System.Windows.Forms.Button BXTMAIOR;
        private System.Windows.Forms.Button BTNPARIMPAR;
    }
}

