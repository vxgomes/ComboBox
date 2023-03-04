namespace ComboBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNumeros = new System.Windows.Forms.ComboBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha um numero de 1 a 12 :";
            // 
            // comboBoxNumeros
            // 
            this.comboBoxNumeros.FormattingEnabled = true;
            this.comboBoxNumeros.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxNumeros.Location = new System.Drawing.Point(346, 130);
            this.comboBoxNumeros.Name = "comboBoxNumeros";
            this.comboBoxNumeros.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNumeros.TabIndex = 1;
            this.comboBoxNumeros.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumeros_SelectedIndexChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(473, 126);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(236, 30);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Escolha um numero e clique aqui!";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(599, 334);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(99, 36);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.Text = "SAIR";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(257, 223);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 39);
            this.labelResultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.comboBoxNumeros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNumeros;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelResultado;
    }
}

