using System;

namespace Biblioteca
{
    partial class frm_EditarPefilClietne
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_IdCliente = new System.Windows.Forms.Label();
            this.lbl_CEP = new System.Windows.Forms.Label();
            this.lbl_DataCadastro = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.lbl_Emprestimos = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.txtbm_NomeDoCliente = new System.Windows.Forms.TextBox();
            this.txtbm_Endereco = new System.Windows.Forms.TextBox();
            this.txtbm_Tel = new System.Windows.Forms.TextBox();
            this.txtbm_CPF = new System.Windows.Forms.MaskedTextBox();
            this.txtbm_cadastrocliente = new System.Windows.Forms.MaskedTextBox();
            this.txtbm_CEP = new System.Windows.Forms.MaskedTextBox();
            this.lv_emprestimocliente = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_editora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_idioma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_datapublicacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_criarperfil = new System.Windows.Forms.Button();
            this.txtbm_idcliente = new System.Windows.Forms.TextBox();
            this.image1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(239, 27);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(75, 25);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome: ";
            // 
            // lbl_IdCliente
            // 
            this.lbl_IdCliente.AutoSize = true;
            this.lbl_IdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdCliente.Location = new System.Drawing.Point(12, 252);
            this.lbl_IdCliente.Name = "lbl_IdCliente";
            this.lbl_IdCliente.Size = new System.Drawing.Size(42, 25);
            this.lbl_IdCliente.TabIndex = 2;
            this.lbl_IdCliente.Text = "ID :";
            // 
            // lbl_CEP
            // 
            this.lbl_CEP.AutoSize = true;
            this.lbl_CEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CEP.Location = new System.Drawing.Point(742, 76);
            this.lbl_CEP.Name = "lbl_CEP";
            this.lbl_CEP.Size = new System.Drawing.Size(59, 25);
            this.lbl_CEP.TabIndex = 4;
            this.lbl_CEP.Text = "CEP:";
            this.lbl_CEP.Click += new System.EventHandler(this.lbl_CEP_Click);
            // 
            // lbl_DataCadastro
            // 
            this.lbl_DataCadastro.AutoSize = true;
            this.lbl_DataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataCadastro.Location = new System.Drawing.Point(649, 28);
            this.lbl_DataCadastro.Name = "lbl_DataCadastro";
            this.lbl_DataCadastro.Size = new System.Drawing.Size(152, 25);
            this.lbl_DataCadastro.TabIndex = 6;
            this.lbl_DataCadastro.Text = "Cadastrado em:";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPF.Location = new System.Drawing.Point(246, 78);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(58, 25);
            this.lbl_CPF.TabIndex = 8;
            this.lbl_CPF.Text = "CPF:";
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tel.Location = new System.Drawing.Point(246, 177);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(95, 25);
            this.lbl_Tel.TabIndex = 10;
            this.lbl_Tel.Text = "Telefone:";
            // 
            // lbl_Emprestimos
            // 
            this.lbl_Emprestimos.AutoSize = true;
            this.lbl_Emprestimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emprestimos.Location = new System.Drawing.Point(12, 293);
            this.lbl_Emprestimos.Name = "lbl_Emprestimos";
            this.lbl_Emprestimos.Size = new System.Drawing.Size(136, 25);
            this.lbl_Emprestimos.TabIndex = 12;
            this.lbl_Emprestimos.Text = "Empréstimos :";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Endereco.Location = new System.Drawing.Point(239, 127);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(102, 25);
            this.lbl_Endereco.TabIndex = 13;
            this.lbl_Endereco.Text = "Endereço:";
            // 
            // txtbm_NomeDoCliente
            // 
            this.txtbm_NomeDoCliente.Location = new System.Drawing.Point(305, 33);
            this.txtbm_NomeDoCliente.Name = "txtbm_NomeDoCliente";
            this.txtbm_NomeDoCliente.Size = new System.Drawing.Size(338, 20);
            this.txtbm_NomeDoCliente.TabIndex = 16;
            // 
            // txtbm_Endereco
            // 
            this.txtbm_Endereco.Location = new System.Drawing.Point(340, 132);
            this.txtbm_Endereco.Name = "txtbm_Endereco";
            this.txtbm_Endereco.Size = new System.Drawing.Size(218, 20);
            this.txtbm_Endereco.TabIndex = 18;
            // 
            // txtbm_Tel
            // 
            this.txtbm_Tel.Location = new System.Drawing.Point(340, 182);
            this.txtbm_Tel.Name = "txtbm_Tel";
            this.txtbm_Tel.Size = new System.Drawing.Size(218, 20);
            this.txtbm_Tel.TabIndex = 19;
            // 
            // txtbm_CPF
            // 
            this.txtbm_CPF.Location = new System.Drawing.Point(305, 81);
            this.txtbm_CPF.Mask = "000.000.000-00";
            this.txtbm_CPF.Name = "txtbm_CPF";
            this.txtbm_CPF.Size = new System.Drawing.Size(84, 20);
            this.txtbm_CPF.TabIndex = 20;
            this.txtbm_CPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtbm_cadastrocliente
            // 
            this.txtbm_cadastrocliente.Location = new System.Drawing.Point(818, 33);
            this.txtbm_cadastrocliente.Mask = "00/00/0000";
            this.txtbm_cadastrocliente.Name = "txtbm_cadastrocliente";
            this.txtbm_cadastrocliente.Size = new System.Drawing.Size(70, 20);
            this.txtbm_cadastrocliente.TabIndex = 21;
            this.txtbm_cadastrocliente.ValidatingType = typeof(System.DateTime);
            // 
            // txtbm_CEP
            // 
            this.txtbm_CEP.Location = new System.Drawing.Point(818, 83);
            this.txtbm_CEP.Mask = "00000-00";
            this.txtbm_CEP.Name = "txtbm_CEP";
            this.txtbm_CEP.Size = new System.Drawing.Size(55, 20);
            this.txtbm_CEP.TabIndex = 22;
            this.txtbm_CEP.ValidatingType = typeof(System.DateTime);
            // 
            // lv_emprestimocliente
            // 
            this.lv_emprestimocliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_nome,
            this.col_editora,
            this.col_autor,
            this.col_ISBN,
            this.col_idioma,
            this.col_datapublicacao});
            this.lv_emprestimocliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.lv_emprestimocliente.HideSelection = false;
            this.lv_emprestimocliente.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lv_emprestimocliente.Location = new System.Drawing.Point(12, 330);
            this.lv_emprestimocliente.MultiSelect = false;
            this.lv_emprestimocliente.Name = "lv_emprestimocliente";
            this.lv_emprestimocliente.Size = new System.Drawing.Size(934, 268);
            this.lv_emprestimocliente.TabIndex = 23;
            this.lv_emprestimocliente.UseCompatibleStateImageBehavior = false;
            this.lv_emprestimocliente.View = System.Windows.Forms.View.Details;
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 31;
            // 
            // col_nome
            // 
            this.col_nome.Text = "Nome";
            this.col_nome.Width = 271;
            // 
            // col_editora
            // 
            this.col_editora.Text = "Editora";
            this.col_editora.Width = 213;
            // 
            // col_autor
            // 
            this.col_autor.Text = "Autor";
            this.col_autor.Width = 140;
            // 
            // col_ISBN
            // 
            this.col_ISBN.Text = "ISBN";
            this.col_ISBN.Width = 102;
            // 
            // col_idioma
            // 
            this.col_idioma.Text = "Idioma";
            this.col_idioma.Width = 62;
            // 
            // col_datapublicacao
            // 
            this.col_datapublicacao.Text = "Data de publicação";
            this.col_datapublicacao.Width = 111;
            // 
            // btn_criarperfil
            // 
            this.btn_criarperfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_criarperfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_criarperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criarperfil.Location = new System.Drawing.Point(792, 233);
            this.btn_criarperfil.Name = "btn_criarperfil";
            this.btn_criarperfil.Size = new System.Drawing.Size(132, 63);
            this.btn_criarperfil.TabIndex = 24;
            this.btn_criarperfil.Text = "Criar perfil ";
            this.btn_criarperfil.UseVisualStyleBackColor = false;
            this.btn_criarperfil.Click += new System.EventHandler(this.btn_criarperfil_Click);
            // 
            // txtbm_idcliente
            // 
            this.txtbm_idcliente.Location = new System.Drawing.Point(60, 258);
            this.txtbm_idcliente.Name = "txtbm_idcliente";
            this.txtbm_idcliente.Size = new System.Drawing.Size(45, 20);
            this.txtbm_idcliente.TabIndex = 25;
            // 
            // image1
            // 
            this.image1.Image = global::Biblioteca.Properties.Resources.imagemperfil;
            this.image1.Location = new System.Drawing.Point(12, 12);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(218, 225);
            this.image1.TabIndex = 15;
            this.image1.TabStop = false;
            this.image1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_EditarPefilClietne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.txtbm_idcliente);
            this.Controls.Add(this.btn_criarperfil);
            this.Controls.Add(this.lv_emprestimocliente);
            this.Controls.Add(this.txtbm_CEP);
            this.Controls.Add(this.txtbm_cadastrocliente);
            this.Controls.Add(this.txtbm_CPF);
            this.Controls.Add(this.txtbm_Tel);
            this.Controls.Add(this.txtbm_Endereco);
            this.Controls.Add(this.txtbm_NomeDoCliente);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.lbl_Emprestimos);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.lbl_DataCadastro);
            this.Controls.Add(this.lbl_CEP);
            this.Controls.Add(this.lbl_IdCliente);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "frm_EditarPefilClietne";
            this.Text = "frm_PerfilCliente";
            this.Load += new System.EventHandler(this.frm_EditarPefilClietne_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_IdCliente;
        private System.Windows.Forms.Label lbl_CEP;
        private System.Windows.Forms.Label lbl_DataCadastro;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.Label lbl_Emprestimos;
        private System.Windows.Forms.Label lbl_Endereco;
        private EventHandler label1_Click;
        private EventHandler label4_Click;
        private EventHandler lbl_CPFUsuario_Click;
        private EventHandler frm_PerfilCliente_Load;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.TextBox txtbm_NomeDoCliente;
        private System.Windows.Forms.TextBox txtbm_Endereco;
        private System.Windows.Forms.TextBox txtbm_Tel;
        private System.Windows.Forms.MaskedTextBox txtbm_CPF;
        private System.Windows.Forms.MaskedTextBox txtbm_cadastrocliente;
        private System.Windows.Forms.MaskedTextBox txtbm_CEP;
        private System.Windows.Forms.ListView lv_emprestimocliente;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_editora;
        private System.Windows.Forms.ColumnHeader col_autor;
        public System.Windows.Forms.ColumnHeader col_ISBN;
        private System.Windows.Forms.ColumnHeader col_idioma;
        private System.Windows.Forms.ColumnHeader col_datapublicacao;
        private System.Windows.Forms.Button btn_criarperfil;
        private System.Windows.Forms.TextBox txtbm_idcliente;
    }
}