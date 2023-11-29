namespace projetinho
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            this.confirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.tex_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_numero = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edit = new System.Windows.Forms.Button();
            this.DataDeNacimento = new System.Windows.Forms.DateTimePicker();
            this.deletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmar
            // 
            this.confirmar.Location = new System.Drawing.Point(78, 317);
            this.confirmar.Margin = new System.Windows.Forms.Padding(4);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(203, 76);
            this.confirmar.TabIndex = 1;
            this.confirmar.Text = "confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "numero";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(91, 29);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 23);
            this.txt_nome.TabIndex = 4;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "senha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "data_de_nacimento";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "endereço";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(91, 166);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(100, 23);
            this.textEndereco.TabIndex = 9;
            this.textEndereco.TextChanged += new System.EventHandler(this.textEndereco_TextChanged);
            // 
            // tex_email
            // 
            this.tex_email.Location = new System.Drawing.Point(91, 74);
            this.tex_email.Name = "tex_email";
            this.tex_email.Size = new System.Drawing.Size(100, 23);
            this.tex_email.TabIndex = 14;
            this.tex_email.TextChanged += new System.EventHandler(this.tex_email_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "e_mail";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(912, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(91, 120);
            this.txt_numero.Mask = "(999) 000-0000";
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 23);
            this.txt_numero.TabIndex = 17;
            this.txt_numero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_numero_MaskInputRejected);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(91, 258);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 23);
            this.txtSenha.TabIndex = 19;
            this.txtSenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtSenha_MaskInputRejected);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(88, 445);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(374, 97);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "nome";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "e-mail";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "numero";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "endereço";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(289, 317);
            this.edit.Margin = new System.Windows.Forms.Padding(4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(203, 76);
            this.edit.TabIndex = 21;
            this.edit.Text = "ediatar";
            this.edit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataDeNacimento
            // 
            this.DataDeNacimento.CustomFormat = "";
            this.DataDeNacimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDeNacimento.Location = new System.Drawing.Point(88, 213);
            this.DataDeNacimento.Name = "DataDeNacimento";
            this.DataDeNacimento.Size = new System.Drawing.Size(200, 23);
            this.DataDeNacimento.TabIndex = 22;
            this.DataDeNacimento.ValueChanged += new System.EventHandler(this.TextDataDeNacimentoo_ValueChanged);
            // 
            // deletar
            // 
            this.deletar.Location = new System.Drawing.Point(500, 317);
            this.deletar.Margin = new System.Windows.Forms.Padding(4);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(203, 76);
            this.deletar.TabIndex = 23;
            this.deletar.Text = "deletar";
            this.deletar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.deletar.UseVisualStyleBackColor = true;
            this.deletar.Click += new System.EventHandler(this.deletar_Click);
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.deletar);
            this.Controls.Add(this.DataDeNacimento);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tex_email);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formlogin";
            this.Text = "editar";
            this.Load += new System.EventHandler(this.Formlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox tex_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txt_numero;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.DateTimePicker DataDeNacimento;
        private System.Windows.Forms.Button deletar;
    }
}