namespace Biblioteca
{
    partial class frm_MostrarTitulo
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lbl_TituloDisp = new System.Windows.Forms.Label();
            this.btn_SolicitarEm = new System.Windows.Forms.Button();
            this.btn_ConsultarEm = new System.Windows.Forms.Button();
            this.lbl_SubBibliSofi1 = new System.Windows.Forms.Label();
            this.btn_Sair1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lv_titulosdisponiveis = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_editora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_idioma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_datapublicacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TituloDisp
            // 
            this.lbl_TituloDisp.AutoSize = true;
            this.lbl_TituloDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloDisp.Location = new System.Drawing.Point(35, 31);
            this.lbl_TituloDisp.Name = "lbl_TituloDisp";
            this.lbl_TituloDisp.Size = new System.Drawing.Size(242, 31);
            this.lbl_TituloDisp.TabIndex = 0;
            this.lbl_TituloDisp.Text = "Títulos Disponíveis";
            this.lbl_TituloDisp.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_SolicitarEm
            // 
            this.btn_SolicitarEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_SolicitarEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_SolicitarEm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SolicitarEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SolicitarEm.Location = new System.Drawing.Point(67, 391);
            this.btn_SolicitarEm.Name = "btn_SolicitarEm";
            this.btn_SolicitarEm.Size = new System.Drawing.Size(303, 62);
            this.btn_SolicitarEm.TabIndex = 2;
            this.btn_SolicitarEm.Text = "Solicitar Empréstimo";
            this.btn_SolicitarEm.UseVisualStyleBackColor = false;
            this.btn_SolicitarEm.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // btn_ConsultarEm
            // 
            this.btn_ConsultarEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_ConsultarEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ConsultarEm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConsultarEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultarEm.Location = new System.Drawing.Point(67, 459);
            this.btn_ConsultarEm.Name = "btn_ConsultarEm";
            this.btn_ConsultarEm.Size = new System.Drawing.Size(303, 62);
            this.btn_ConsultarEm.TabIndex = 3;
            this.btn_ConsultarEm.Text = "Consultar Empréstimo";
            this.btn_ConsultarEm.UseVisualStyleBackColor = false;
            this.btn_ConsultarEm.Click += new System.EventHandler(this.btn_ConsultarEm_Click);
            // 
            // lbl_SubBibliSofi1
            // 
            this.lbl_SubBibliSofi1.AutoSize = true;
            this.lbl_SubBibliSofi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubBibliSofi1.Location = new System.Drawing.Point(12, 564);
            this.lbl_SubBibliSofi1.Name = "lbl_SubBibliSofi1";
            this.lbl_SubBibliSofi1.Size = new System.Drawing.Size(135, 25);
            this.lbl_SubBibliSofi1.TabIndex = 10;
            this.lbl_SubBibliSofi1.Text = "Biblioteca IHC";
            this.lbl_SubBibliSofi1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_SubBibliSofi1.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Sair1
            // 
            this.btn_Sair1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Sair1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sair1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair1.Location = new System.Drawing.Point(645, 527);
            this.btn_Sair1.Name = "btn_Sair1";
            this.btn_Sair1.Size = new System.Drawing.Size(109, 62);
            this.btn_Sair1.TabIndex = 11;
            this.btn_Sair1.Text = "Sair";
            this.btn_Sair1.UseVisualStyleBackColor = false;
            this.btn_Sair1.Click += new System.EventHandler(this.btn_Sair1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.coruja;
            this.pictureBox1.Location = new System.Drawing.Point(839, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 192);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lv_titulosdisponiveis
            // 
            this.lv_titulosdisponiveis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_nome,
            this.col_editora,
            this.col_autor,
            this.col_ISBN,
            this.col_idioma,
            this.col_datapublicacao});
            this.lv_titulosdisponiveis.Cursor = System.Windows.Forms.Cursors.Default;
            this.lv_titulosdisponiveis.HideSelection = false;
            this.lv_titulosdisponiveis.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lv_titulosdisponiveis.Location = new System.Drawing.Point(12, 65);
            this.lv_titulosdisponiveis.MultiSelect = false;
            this.lv_titulosdisponiveis.Name = "lv_titulosdisponiveis";
            this.lv_titulosdisponiveis.Size = new System.Drawing.Size(934, 320);
            this.lv_titulosdisponiveis.TabIndex = 24;
            this.lv_titulosdisponiveis.UseCompatibleStateImageBehavior = false;
            this.lv_titulosdisponiveis.View = System.Windows.Forms.View.Details;
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
            // frm_MostrarTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.lv_titulosdisponiveis);
            this.Controls.Add(this.btn_Sair1);
            this.Controls.Add(this.lbl_SubBibliSofi1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ConsultarEm);
            this.Controls.Add(this.btn_SolicitarEm);
            this.Controls.Add(this.lbl_TituloDisp);
            this.Name = "frm_MostrarTitulo";
            this.Text = "frm_MostrarTitulo";
            this.Load += new System.EventHandler(this.frm_MostrarTitulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TituloDisp;
        private System.Windows.Forms.Button btn_SolicitarEm;
        private System.Windows.Forms.Button btn_ConsultarEm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_SubBibliSofi1;
        private System.Windows.Forms.Button btn_Sair1;
        private System.Windows.Forms.ListView lv_titulosdisponiveis;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_editora;
        private System.Windows.Forms.ColumnHeader col_autor;
        public System.Windows.Forms.ColumnHeader col_ISBN;
        private System.Windows.Forms.ColumnHeader col_idioma;
        private System.Windows.Forms.ColumnHeader col_datapublicacao;
    }
}