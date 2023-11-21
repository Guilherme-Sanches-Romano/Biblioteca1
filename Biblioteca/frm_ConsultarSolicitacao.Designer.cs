namespace Biblioteca
{
    partial class frm_ConsultarSolicitacao
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
            this.btn_Sair2 = new System.Windows.Forms.Button();
            this.lbl_SubBibliSofi2 = new System.Windows.Forms.Label();
            this.btn_RemoverEm = new System.Windows.Forms.Button();
            this.lbl_TituloSol = new System.Windows.Forms.Label();
            this.lv_emprestimocliente = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_editora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_idioma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_datapublicacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sair2
            // 
            this.btn_Sair2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Sair2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sair2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair2.Location = new System.Drawing.Point(590, 536);
            this.btn_Sair2.Name = "btn_Sair2";
            this.btn_Sair2.Size = new System.Drawing.Size(109, 62);
            this.btn_Sair2.TabIndex = 17;
            this.btn_Sair2.Text = "Sair";
            this.btn_Sair2.UseVisualStyleBackColor = false;
            // 
            // lbl_SubBibliSofi2
            // 
            this.lbl_SubBibliSofi2.AutoSize = true;
            this.lbl_SubBibliSofi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubBibliSofi2.Location = new System.Drawing.Point(12, 573);
            this.lbl_SubBibliSofi2.Name = "lbl_SubBibliSofi2";
            this.lbl_SubBibliSofi2.Size = new System.Drawing.Size(135, 25);
            this.lbl_SubBibliSofi2.TabIndex = 16;
            this.lbl_SubBibliSofi2.Text = "Biblioteca IHC";
            this.lbl_SubBibliSofi2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_RemoverEm
            // 
            this.btn_RemoverEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_RemoverEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_RemoverEm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RemoverEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoverEm.Location = new System.Drawing.Point(53, 423);
            this.btn_RemoverEm.Name = "btn_RemoverEm";
            this.btn_RemoverEm.Size = new System.Drawing.Size(303, 62);
            this.btn_RemoverEm.TabIndex = 13;
            this.btn_RemoverEm.Text = "Remover Empréstrimo";
            this.btn_RemoverEm.UseVisualStyleBackColor = false;
            // 
            // lbl_TituloSol
            // 
            this.lbl_TituloSol.AutoSize = true;
            this.lbl_TituloSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloSol.Location = new System.Drawing.Point(12, 9);
            this.lbl_TituloSol.Name = "lbl_TituloSol";
            this.lbl_TituloSol.Size = new System.Drawing.Size(249, 31);
            this.lbl_TituloSol.TabIndex = 12;
            this.lbl_TituloSol.Text = "Títulos Solicitados :";
            this.lbl_TituloSol.Click += new System.EventHandler(this.lbl_TituloDisp_Click);
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
            listViewItem1});
            this.lv_emprestimocliente.Location = new System.Drawing.Point(12, 62);
            this.lv_emprestimocliente.MultiSelect = false;
            this.lv_emprestimocliente.Name = "lv_emprestimocliente";
            this.lv_emprestimocliente.Size = new System.Drawing.Size(934, 338);
            this.lv_emprestimocliente.TabIndex = 24;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.coruja;
            this.pictureBox1.Location = new System.Drawing.Point(839, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 192);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frm_ConsultarSolicitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.lv_emprestimocliente);
            this.Controls.Add(this.btn_Sair2);
            this.Controls.Add(this.lbl_SubBibliSofi2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_RemoverEm);
            this.Controls.Add(this.lbl_TituloSol);
            this.Name = "frm_ConsultarSolicitacao";
            this.Text = "frm_ConsultarSolicitacao";
            this.Load += new System.EventHandler(this.frm_ConsultarSolicitacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sair2;
        private System.Windows.Forms.Label lbl_SubBibliSofi2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_RemoverEm;
        private System.Windows.Forms.Label lbl_TituloSol;
        private System.Windows.Forms.ListView lv_emprestimocliente;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_editora;
        private System.Windows.Forms.ColumnHeader col_autor;
        public System.Windows.Forms.ColumnHeader col_ISBN;
        private System.Windows.Forms.ColumnHeader col_idioma;
        private System.Windows.Forms.ColumnHeader col_datapublicacao;
    }
}