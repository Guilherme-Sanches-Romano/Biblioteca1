namespace Biblioteca
{
    partial class frm_ManterExemplares
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "01",
            "Pequeno Principe",
            "Grupo Companhia das Letras",
            "Antoine de Saint-Exupéry",
            "9788522005239",
            "Português",
            "06/04/1943",
            "Aventura"}, -1);
            this.btn_Sair1 = new System.Windows.Forms.Button();
            this.lbl_SubBibliSofi1 = new System.Windows.Forms.Label();
            this.btn_ConsultarEm = new System.Windows.Forms.Button();
            this.btn_SolicitarEm = new System.Windows.Forms.Button();
            this.lbl_Exemplares = new System.Windows.Forms.Label();
            this.lv_exemplares = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_editora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_idioma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_datapublicacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.col_genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sair1
            // 
            this.btn_Sair1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Sair1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sair1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair1.Location = new System.Drawing.Point(675, 518);
            this.btn_Sair1.Name = "btn_Sair1";
            this.btn_Sair1.Size = new System.Drawing.Size(109, 62);
            this.btn_Sair1.TabIndex = 17;
            this.btn_Sair1.Text = "Voltar";
            this.btn_Sair1.UseVisualStyleBackColor = false;
            this.btn_Sair1.Click += new System.EventHandler(this.btn_Sair1_Click);
            // 
            // lbl_SubBibliSofi1
            // 
            this.lbl_SubBibliSofi1.AutoSize = true;
            this.lbl_SubBibliSofi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubBibliSofi1.Location = new System.Drawing.Point(12, 555);
            this.lbl_SubBibliSofi1.Name = "lbl_SubBibliSofi1";
            this.lbl_SubBibliSofi1.Size = new System.Drawing.Size(135, 25);
            this.lbl_SubBibliSofi1.TabIndex = 16;
            this.lbl_SubBibliSofi1.Text = "Biblioteca IHC";
            this.lbl_SubBibliSofi1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_SubBibliSofi1.Click += new System.EventHandler(this.lbl_SubBibliSofi1_Click);
            // 
            // btn_ConsultarEm
            // 
            this.btn_ConsultarEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_ConsultarEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ConsultarEm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConsultarEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultarEm.Location = new System.Drawing.Point(244, 426);
            this.btn_ConsultarEm.Name = "btn_ConsultarEm";
            this.btn_ConsultarEm.Size = new System.Drawing.Size(122, 62);
            this.btn_ConsultarEm.TabIndex = 14;
            this.btn_ConsultarEm.Text = "Excluir";
            this.btn_ConsultarEm.UseVisualStyleBackColor = false;
            this.btn_ConsultarEm.Click += new System.EventHandler(this.btn_ConsultarEm_Click);
            // 
            // btn_SolicitarEm
            // 
            this.btn_SolicitarEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_SolicitarEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_SolicitarEm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SolicitarEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SolicitarEm.Location = new System.Drawing.Point(86, 426);
            this.btn_SolicitarEm.Name = "btn_SolicitarEm";
            this.btn_SolicitarEm.Size = new System.Drawing.Size(118, 62);
            this.btn_SolicitarEm.TabIndex = 13;
            this.btn_SolicitarEm.Text = "Criar";
            this.btn_SolicitarEm.UseVisualStyleBackColor = false;
            this.btn_SolicitarEm.Click += new System.EventHandler(this.btn_SolicitarEm_Click);
            // 
            // lbl_Exemplares
            // 
            this.lbl_Exemplares.AutoSize = true;
            this.lbl_Exemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exemplares.Location = new System.Drawing.Point(35, 22);
            this.lbl_Exemplares.Name = "lbl_Exemplares";
            this.lbl_Exemplares.Size = new System.Drawing.Size(171, 31);
            this.lbl_Exemplares.TabIndex = 12;
            this.lbl_Exemplares.Text = "Exemplares :";
            this.lbl_Exemplares.Click += new System.EventHandler(this.lbl_TituloDisp_Click);
            // 
            // lv_exemplares
            // 
            this.lv_exemplares.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_nome,
            this.col_editora,
            this.col_autor,
            this.col_ISBN,
            this.col_idioma,
            this.col_datapublicacao,
            this.col_genero});
            this.lv_exemplares.Cursor = System.Windows.Forms.Cursors.Default;
            this.lv_exemplares.FullRowSelect = true;
            this.lv_exemplares.HideSelection = false;
            this.lv_exemplares.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lv_exemplares.Location = new System.Drawing.Point(12, 56);
            this.lv_exemplares.MultiSelect = false;
            this.lv_exemplares.Name = "lv_exemplares";
            this.lv_exemplares.Size = new System.Drawing.Size(934, 335);
            this.lv_exemplares.TabIndex = 24;
            this.lv_exemplares.UseCompatibleStateImageBehavior = false;
            this.lv_exemplares.View = System.Windows.Forms.View.Details;
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 31;
            // 
            // col_nome
            // 
            this.col_nome.Text = "Nome";
            this.col_nome.Width = 170;
            // 
            // col_editora
            // 
            this.col_editora.Text = "Editora";
            this.col_editora.Width = 208;
            // 
            // col_autor
            // 
            this.col_autor.Text = "Autor";
            this.col_autor.Width = 159;
            // 
            // col_ISBN
            // 
            this.col_ISBN.Text = "ISBN";
            this.col_ISBN.Width = 111;
            // 
            // col_idioma
            // 
            this.col_idioma.Text = "Idioma";
            this.col_idioma.Width = 81;
            // 
            // col_datapublicacao
            // 
            this.col_datapublicacao.Text = "Data de publicação";
            this.col_datapublicacao.Width = 109;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.coruja;
            this.pictureBox1.Location = new System.Drawing.Point(839, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 192);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // col_genero
            // 
            this.col_genero.Text = "Gênero";
            // 
            // frm_ManterExemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.lv_exemplares);
            this.Controls.Add(this.btn_Sair1);
            this.Controls.Add(this.lbl_SubBibliSofi1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ConsultarEm);
            this.Controls.Add(this.btn_SolicitarEm);
            this.Controls.Add(this.lbl_Exemplares);
            this.Name = "frm_ManterExemplares";
            this.Text = "frm_ManterExemplares";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sair1;
        private System.Windows.Forms.Label lbl_SubBibliSofi1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ConsultarEm;
        private System.Windows.Forms.Button btn_SolicitarEm;
        private System.Windows.Forms.Label lbl_Exemplares;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_editora;
        private System.Windows.Forms.ColumnHeader col_autor;
        public System.Windows.Forms.ColumnHeader col_ISBN;
        private System.Windows.Forms.ColumnHeader col_idioma;
        private System.Windows.Forms.ColumnHeader col_datapublicacao;
        public System.Windows.Forms.ListView lv_exemplares;
        private System.Windows.Forms.ColumnHeader col_genero;
    }
}