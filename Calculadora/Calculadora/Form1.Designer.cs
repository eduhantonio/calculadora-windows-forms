
namespace Calculadora
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
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.soma = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(144, 38);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(256, 40);
            this.Num1.TabIndex = 0;
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(144, 98);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(256, 40);
            this.Num2.TabIndex = 1;
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(2, 41);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(136, 33);
            this.L1.TabIndex = 2;
            this.L1.Text = "1° Valor:";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.Location = new System.Drawing.Point(2, 101);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(136, 33);
            this.L2.TabIndex = 3;
            this.L2.Text = "2° Valor:";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(2, 167);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(164, 33);
            this.Result.TabIndex = 4;
            this.Result.Text = "Resultado:";
            // 
            // soma
            // 
            this.soma.Location = new System.Drawing.Point(8, 250);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(185, 84);
            this.soma.TabIndex = 6;
            this.soma.Text = "SOMA";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // subtracao
            // 
            this.subtracao.Location = new System.Drawing.Point(8, 355);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(187, 84);
            this.subtracao.TabIndex = 7;
            this.subtracao.Text = "SUBTRAÇÃO";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Location = new System.Drawing.Point(215, 355);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(185, 84);
            this.multiplicacao.TabIndex = 8;
            this.multiplicacao.Text = "MULTIPLICAÇÃO";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // divisao
            // 
            this.divisao.Location = new System.Drawing.Point(215, 250);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(185, 84);
            this.divisao.TabIndex = 9;
            this.divisao.Text = "DIVISÃO";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // potencia
            // 
            this.potencia.Location = new System.Drawing.Point(112, 459);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(185, 84);
            this.potencia.TabIndex = 10;
            this.potencia.Text = "1° ELEVADO AO 2°";
            this.potencia.UseVisualStyleBackColor = true;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(163, 167);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(146, 33);
            this.resultado.TabIndex = 11;
            this.resultado.Text = "Resultado";
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 569);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Label resultado;
    }
}

