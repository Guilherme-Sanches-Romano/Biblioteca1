namespace Biblioteca
{
    partial class frm_ManterClientes
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "01",
            "Eduardo da Costa",
            "42312354322",
            "Som Gonçalo",
            "4345333",
            "12332333",
            "1232322"}, -1);
            this.btn_Sair1 = new System.Windows.Forms.Button();
            this.lbl_SubBibliSofi1 = new System.Windows.Forms.Label();
            this.btn_ExcluirCliente = new System.Windows.Forms.Button();
            this.btn_CriarCliente = new System.Windows.Forms.Button();
            this.lbl_Exemplares = new System.Windows.Forms.Label();
            this.lv_clientes = new System.Windows.Forms.ListView();
            this.col_idcliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nomecliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_cpfcliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_enderecocliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_telefonecliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_cepcliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_cadastrocliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sair1
            // 
            this.btn_Sair1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Sair1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sair1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair1.Location = new System.Drawing.Point(663, 538);
            this.btn_Sair1.Name = "btn_Sair1";
            this.btn_Sair1.Size = new System.Drawing.Size(109, 62);
            this.btn_Sair1.TabIndex = 23;
            this.btn_Sair1.Text = "Voltar";
            this.btn_Sair1.UseVisualStyleBackColor = false;
            this.btn_Sair1.Click += new System.EventHandler(this.btn_Sair1_Click);
            // 
            // lbl_SubBibliSofi1
            // 
            this.lbl_SubBibliSofi1.AutoSize = true;
            this.lbl_SubBibliSofi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubBibliSofi1.Location = new System.Drawing.Point(30, 575);
            this.lbl_SubBibliSofi1.Name = "lbl_SubBibliSofi1";
            this.lbl_SubBibliSofi1.Size = new System.Drawing.Size(135, 25);
            this.lbl_SubBibliSofi1.TabIndex = 22;
            this.lbl_SubBibliSofi1.Text = "Biblioteca IHC";
            this.lbl_SubBibliSofi1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_SubBibliSofi1.Click += new System.EventHandler(this.lbl_SubBibliSofi1_Click);
            // 
            // btn_ExcluirCliente
            // 
            this.btn_ExcluirCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_ExcluirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirCliente.Location = new System.Drawing.Point(262, 446);
            this.btn_ExcluirCliente.Name = "btn_ExcluirCliente";
            this.btn_ExcluirCliente.Size = new System.Drawing.Size(122, 62);
            this.btn_ExcluirCliente.TabIndex = 20;
            this.btn_ExcluirCliente.Text = "Excluir";
            this.btn_ExcluirCliente.UseVisualStyleBackColor = false;
            this.btn_ExcluirCliente.Click += new System.EventHandler(this.btn_ExcluirCliente_Click);
            // 
            // btn_CriarCliente
            // 
            this.btn_CriarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_CriarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CriarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CriarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CriarCliente.Location = new System.Drawing.Point(104, 446);
            this.btn_CriarCliente.Name = "btn_CriarCliente";
            this.btn_CriarCliente.Size = new System.Drawing.Size(118, 62);
            this.btn_CriarCliente.TabIndex = 19;
            this.btn_CriarCliente.Text = "Criar";
            this.btn_CriarCliente.UseVisualStyleBackColor = false;
            this.btn_CriarCliente.Click += new System.EventHandler(this.btn_CriarCliente_Click);
            // 
            // lbl_Exemplares
            // 
            this.lbl_Exemplares.AutoSize = true;
            this.lbl_Exemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exemplares.Location = new System.Drawing.Point(29, 27);
            this.lbl_Exemplares.Name = "lbl_Exemplares";
            this.lbl_Exemplares.Size = new System.Drawing.Size(113, 31);
            this.lbl_Exemplares.TabIndex = 18;
            this.lbl_Exemplares.Text = "Clientes";
            this.lbl_Exemplares.Click += new System.EventHandler(this.lbl_Exemplares_Click);
            // 
            // lv_clientes
            // 
            this.lv_clientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_idcliente,
            this.col_nomecliente,
            this.col_cpfcliente,
            this.col_enderecocliente,
            this.col_cepcliente,
            this.col_telefonecliente,
            this.col_cadastrocliente});
            this.lv_clientes.FullRowSelect = true;
            this.lv_clientes.HideSelection = false;
            this.lv_clientes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.lv_clientes.Location = new System.Drawing.Point(12, 76);
            this.lv_clientes.MultiSelect = false;
            this.lv_clientes.Name = "lv_clientes";
            this.lv_clientes.Size = new System.Drawing.Size(934, 324);
            this.lv_clientes.TabIndex = 24;
            this.lv_clientes.UseCompatibleStateImageBehavior = false;
            this.lv_clientes.View = System.Windows.Forms.View.Details;
            this.lv_clientes.SelectedIndexChanged += new System.EventHandler(this.lv_clientes_SelectedIndexChanged);
            // 
            // col_idcliente
            // 
            this.col_idcliente.Text = "ID";
            this.col_idcliente.Width = 31;
            // 
            // col_nomecliente
            // 
            this.col_nomecliente.Text = "Nome";
            this.col_nomecliente.Width = 232;
            // 
            // col_cpfcliente
            // 
            this.col_cpfcliente.Text = "CPF";
            this.col_cpfcliente.Width = 90;
            // 
            // col_enderecocliente
            // 
            this.col_enderecocliente.Text = "Endereço";
            this.col_enderecocliente.Width = 275;
            // 
            // col_telefonecliente
            // 
            this.col_telefonecliente.DisplayIndex = 4;
            this.col_telefonecliente.Text = "telefone";
            this.col_telefonecliente.Width = 132;
            // 
            // col_cepcliente
            // 
            this.col_cepcliente.DisplayIndex = 5;
            this.col_cepcliente.Text = "CEP";
            this.col_cepcliente.Width = 62;
            // 
            // col_cadastrocliente
            // 
            this.col_cadastrocliente.Text = "Cadastro";
            this.col_cadastrocliente.Width = 91;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.coruja;
            this.pictureBox1.Location = new System.Drawing.Point(839, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 192);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frm_ManterClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.lv_clientes);
            this.Controls.Add(this.btn_Sair1);
            this.Controls.Add(this.lbl_SubBibliSofi1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ExcluirCliente);
            this.Controls.Add(this.btn_CriarCliente);
            this.Controls.Add(this.lbl_Exemplares);
            this.Name = "frm_ManterClientes";
            this.Text = "frm_ManterClientes";
            this.Load += new System.EventHandler(this.frm_ManterClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sair1;
        private System.Windows.Forms.Label lbl_SubBibliSofi1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ExcluirCliente;
        private System.Windows.Forms.Button btn_CriarCliente;
        private System.Windows.Forms.Label lbl_Exemplares;
        private System.Windows.Forms.ColumnHeader col_idcliente;
        private System.Windows.Forms.ColumnHeader col_nomecliente;
        private System.Windows.Forms.ColumnHeader col_cpfcliente;
        private System.Windows.Forms.ColumnHeader col_enderecocliente;
        private System.Windows.Forms.ColumnHeader col_cepcliente;
        private System.Windows.Forms.ColumnHeader col_telefonecliente;
        private System.Windows.Forms.ColumnHeader col_cadastrocliente;
        public System.Windows.Forms.ListView lv_clientes;
    }
}