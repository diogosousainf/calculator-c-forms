namespace PL_Forms
{
    partial class Calc
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
            this.IbI_N1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_N1 = new System.Windows.Forms.TextBox();
            this.txt_N2 = new System.Windows.Forms.TextBox();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.btn_formExtra_click = new System.Windows.Forms.Button();
            this.btn_sair_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IbI_N1
            // 
            this.IbI_N1.AutoSize = true;
            this.IbI_N1.Location = new System.Drawing.Point(249, 154);
            this.IbI_N1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IbI_N1.Name = "IbI_N1";
            this.IbI_N1.Size = new System.Drawing.Size(69, 18);
            this.IbI_N1.TabIndex = 0;
            this.IbI_N1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // txt_N1
            // 
            this.txt_N1.Location = new System.Drawing.Point(433, 150);
            this.txt_N1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_N1.Name = "txt_N1";
            this.txt_N1.Size = new System.Drawing.Size(132, 26);
            this.txt_N1.TabIndex = 2;
            // 
            // txt_N2
            // 
            this.txt_N2.Location = new System.Drawing.Point(433, 220);
            this.txt_N2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_N2.Name = "txt_N2";
            this.txt_N2.Size = new System.Drawing.Size(132, 26);
            this.txt_N2.TabIndex = 3;
            // 
            // btn_Somar
            // 
            this.btn_Somar.Location = new System.Drawing.Point(253, 295);
            this.btn_Somar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(100, 32);
            this.btn_Somar.TabIndex = 4;
            this.btn_Somar.Text = "Somar";
            this.btn_Somar.UseVisualStyleBackColor = true;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(253, 361);
            this.resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(70, 18);
            this.resultado.TabIndex = 5;
            this.resultado.Text = "Resultado";
            // 
            // btn_formExtra_click
            // 
            this.btn_formExtra_click.Location = new System.Drawing.Point(768, 330);
            this.btn_formExtra_click.Margin = new System.Windows.Forms.Padding(4);
            this.btn_formExtra_click.Name = "btn_formExtra_click";
            this.btn_formExtra_click.Size = new System.Drawing.Size(100, 32);
            this.btn_formExtra_click.TabIndex = 6;
            this.btn_formExtra_click.Text = "FormExtra";
            this.btn_formExtra_click.UseVisualStyleBackColor = true;
            this.btn_formExtra_click.Click += new System.EventHandler(this.btn_formExtra_click_Click);
            // 
            // btn_sair_click
            // 
            this.btn_sair_click.Location = new System.Drawing.Point(768, 370);
            this.btn_sair_click.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sair_click.Name = "btn_sair_click";
            this.btn_sair_click.Size = new System.Drawing.Size(100, 32);
            this.btn_sair_click.TabIndex = 7;
            this.btn_sair_click.Text = "Sair";
            this.btn_sair_click.UseVisualStyleBackColor = true;
            this.btn_sair_click.Click += new System.EventHandler(this.btn_sair_click_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.btn_sair_click);
            this.Controls.Add(this.btn_formExtra_click);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.txt_N2);
            this.Controls.Add(this.txt_N1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IbI_N1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calc";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbI_N1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_N1;
        private System.Windows.Forms.TextBox txt_N2;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button btn_formExtra_click;
        private System.Windows.Forms.Button btn_sair_click;
    }
}

