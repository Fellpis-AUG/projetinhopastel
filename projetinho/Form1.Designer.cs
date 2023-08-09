namespace projetinho
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
            this.btnPronto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbsize = new System.Windows.Forms.Label();
            this.txbFlavor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPronto
            // 
            this.btnPronto.Location = new System.Drawing.Point(159, 60);
            this.btnPronto.Name = "btnPronto";
            this.btnPronto.Size = new System.Drawing.Size(212, 91);
            this.btnPronto.TabIndex = 0;
            this.btnPronto.Text = "preparar pastel";
            this.btnPronto.UseVisualStyleBackColor = true;
            this.btnPronto.Click += new System.EventHandler(this.btnPronto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 2;
            // 
            // txbsize
            // 
            this.txbsize.AutoSize = true;
            this.txbsize.Location = new System.Drawing.Point(12, 60);
            this.txbsize.Name = "txbsize";
            this.txbsize.Size = new System.Drawing.Size(48, 13);
            this.txbsize.TabIndex = 5;
            this.txbsize.Text = "tamanho";
            // 
            // txbFlavor
            // 
            this.txbFlavor.AutoSize = true;
            this.txbFlavor.Location = new System.Drawing.Point(12, 115);
            this.txbFlavor.Name = "txbFlavor";
            this.txbFlavor.Size = new System.Drawing.Size(33, 13);
            this.txbFlavor.TabIndex = 6;
            this.txbFlavor.Text = "sabor";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(394, 171);
            this.Controls.Add(this.txbFlavor);
            this.Controls.Add(this.txbsize);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPronto);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnstore;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btnPronto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txbsize;
        private System.Windows.Forms.Label txbFlavor;
    }
}

