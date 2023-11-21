namespace Biblioteca
{
    partial class frm_Usuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Usuario));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_acessar = new System.Windows.Forms.Button();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txtb_usuario = new System.Windows.Forms.TextBox();
            this.txtb_senha = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(288, 46);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(409, 60);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Biblioteca IHC";
            this.lbl_Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // btn_acessar
            // 
            this.btn_acessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_acessar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_acessar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_acessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acessar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_acessar.Location = new System.Drawing.Point(389, 417);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(200, 62);
            this.btn_acessar.TabIndex = 1;
            this.btn_acessar.Text = "Acessar";
            this.btn_acessar.UseVisualStyleBackColor = false;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // lbl_aviso
            // 
            this.lbl_aviso.AutoSize = true;
            this.lbl_aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aviso.ForeColor = System.Drawing.Color.Red;
            this.lbl_aviso.Location = new System.Drawing.Point(385, 306);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(235, 20);
            this.lbl_aviso.TabIndex = 2;
            this.lbl_aviso.Text = "Senha ou usuário incorretos";
            this.lbl_aviso.Visible = false;
            this.lbl_aviso.Click += new System.EventHandler(this.lbl_aviso_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(192, 207);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(108, 29);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Usuário :";
            this.lbl_usuario.Click += new System.EventHandler(this.lbl_usuario_Click);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(206, 248);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(94, 29);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha :";
            this.lbl_senha.Click += new System.EventHandler(this.lbl_senha_Click);
            // 
            // txtb_usuario
            // 
            this.txtb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_usuario.Location = new System.Drawing.Point(313, 203);
            this.txtb_usuario.Name = "txtb_usuario";
            this.txtb_usuario.Size = new System.Drawing.Size(384, 33);
            this.txtb_usuario.TabIndex = 5;
            this.txtb_usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtb_senha
            // 
            this.txtb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_senha.Location = new System.Drawing.Point(313, 248);
            this.txtb_senha.Name = "txtb_senha";
            this.txtb_senha.PasswordChar = '*';
            this.txtb_senha.Size = new System.Drawing.Size(384, 33);
            this.txtb_senha.TabIndex = 6;
            this.txtb_senha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Black;
            this.imageList2.Images.SetKeyName(0, "coruja.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.coruja;
            this.pictureBox1.Location = new System.Drawing.Point(810, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 192);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtb_senha);
            this.Controls.Add(this.txtb_usuario);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_aviso);
            this.Controls.Add(this.btn_acessar);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "frm_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.frm_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_acessar;
        private System.Windows.Forms.Label lbl_aviso;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txtb_usuario;
        private System.Windows.Forms.TextBox txtb_senha;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

