namespace Biblioteca
{
    partial class frm_EditarExemplares
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_IDlivro = new System.Windows.Forms.Label();
            this.lb_ISBN = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_autor = new System.Windows.Forms.Label();
            this.lb_genero = new System.Windows.Forms.Label();
            this.lb_editora = new System.Windows.Forms.Label();
            this.txtbm_id = new System.Windows.Forms.TextBox();
            this.txtbm_titulo = new System.Windows.Forms.TextBox();
            this.txtbm_autor = new System.Windows.Forms.TextBox();
            this.txtbm_ISBN = new System.Windows.Forms.MaskedTextBox();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lb_capalivro = new System.Windows.Forms.Label();
            this.txtbm_editora = new System.Windows.Forms.TextBox();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbm_idioma = new System.Windows.Forms.TextBox();
            this.lb_idioma = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.txtbm_datapublicacao = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Novo Livro :";
            // 
            // lb_IDlivro
            // 
            this.lb_IDlivro.AutoSize = true;
            this.lb_IDlivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IDlivro.Location = new System.Drawing.Point(47, 93);
            this.lb_IDlivro.Name = "lb_IDlivro";
            this.lb_IDlivro.Size = new System.Drawing.Size(42, 25);
            this.lb_IDlivro.TabIndex = 1;
            this.lb_IDlivro.Text = "ID :";
            this.lb_IDlivro.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_ISBN
            // 
            this.lb_ISBN.AutoSize = true;
            this.lb_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ISBN.Location = new System.Drawing.Point(20, 147);
            this.lb_ISBN.Name = "lb_ISBN";
            this.lb_ISBN.Size = new System.Drawing.Size(69, 25);
            this.lb_ISBN.TabIndex = 2;
            this.lb_ISBN.Text = "ISBN :";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(32, 206);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(71, 25);
            this.lb_titulo.TabIndex = 3;
            this.lb_titulo.Text = "Título :";
            // 
            // lb_autor
            // 
            this.lb_autor.AutoSize = true;
            this.lb_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_autor.Location = new System.Drawing.Point(33, 245);
            this.lb_autor.Name = "lb_autor";
            this.lb_autor.Size = new System.Drawing.Size(70, 25);
            this.lb_autor.TabIndex = 4;
            this.lb_autor.Text = "Autor :";
            // 
            // lb_genero
            // 
            this.lb_genero.AutoSize = true;
            this.lb_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_genero.Location = new System.Drawing.Point(5, 285);
            this.lb_genero.Name = "lb_genero";
            this.lb_genero.Size = new System.Drawing.Size(98, 25);
            this.lb_genero.TabIndex = 5;
            this.lb_genero.Text = "Gêneros :";
            // 
            // lb_editora
            // 
            this.lb_editora.AutoSize = true;
            this.lb_editora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_editora.Location = new System.Drawing.Point(540, 99);
            this.lb_editora.Name = "lb_editora";
            this.lb_editora.Size = new System.Drawing.Size(84, 25);
            this.lb_editora.TabIndex = 6;
            this.lb_editora.Text = "Editora :";
            // 
            // txtbm_id
            // 
            this.txtbm_id.Location = new System.Drawing.Point(95, 99);
            this.txtbm_id.Name = "txtbm_id";
            this.txtbm_id.Size = new System.Drawing.Size(159, 20);
            this.txtbm_id.TabIndex = 8;
            // 
            // txtbm_titulo
            // 
            this.txtbm_titulo.Location = new System.Drawing.Point(109, 211);
            this.txtbm_titulo.Name = "txtbm_titulo";
            this.txtbm_titulo.Size = new System.Drawing.Size(238, 20);
            this.txtbm_titulo.TabIndex = 10;
            // 
            // txtbm_autor
            // 
            this.txtbm_autor.Location = new System.Drawing.Point(109, 251);
            this.txtbm_autor.Name = "txtbm_autor";
            this.txtbm_autor.Size = new System.Drawing.Size(238, 20);
            this.txtbm_autor.TabIndex = 11;
            // 
            // txtbm_ISBN
            // 
            this.txtbm_ISBN.Location = new System.Drawing.Point(109, 153);
            this.txtbm_ISBN.Mask = "0000000000000";
            this.txtbm_ISBN.Name = "txtbm_ISBN";
            this.txtbm_ISBN.Size = new System.Drawing.Size(80, 20);
            this.txtbm_ISBN.TabIndex = 13;
            this.txtbm_ISBN.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // image1
            // 
            this.image1.Image = global::Biblioteca.Properties.Resources.anexo;
            this.image1.Location = new System.Drawing.Point(695, 270);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(201, 187);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image1.TabIndex = 14;
            this.image1.TabStop = false;
            this.image1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_capalivro
            // 
            this.lb_capalivro.AutoSize = true;
            this.lb_capalivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_capalivro.Location = new System.Drawing.Point(526, 270);
            this.lb_capalivro.Name = "lb_capalivro";
            this.lb_capalivro.Size = new System.Drawing.Size(145, 25);
            this.lb_capalivro.TabIndex = 15;
            this.lb_capalivro.Text = "Capa do Livro :";
            // 
            // txtbm_editora
            // 
            this.txtbm_editora.Location = new System.Drawing.Point(641, 104);
            this.txtbm_editora.Name = "txtbm_editora";
            this.txtbm_editora.Size = new System.Drawing.Size(223, 20);
            this.txtbm_editora.TabIndex = 16;
            this.txtbm_editora.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // cb_genero
            // 
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Items.AddRange(new object[] {
            "Mistério ",
            "Suspense ",
            "Terror",
            "Aventura ",
            "Fantasia"});
            this.cb_genero.Location = new System.Drawing.Point(109, 291);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(121, 21);
            this.cb_genero.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 63);
            this.button1.TabIndex = 18;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(577, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 63);
            this.button2.TabIndex = 19;
            this.button2.Text = "Limpar Campos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbm_idioma
            // 
            this.txtbm_idioma.Location = new System.Drawing.Point(641, 167);
            this.txtbm_idioma.Name = "txtbm_idioma";
            this.txtbm_idioma.Size = new System.Drawing.Size(223, 20);
            this.txtbm_idioma.TabIndex = 21;
            // 
            // lb_idioma
            // 
            this.lb_idioma.AutoSize = true;
            this.lb_idioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idioma.Location = new System.Drawing.Point(540, 161);
            this.lb_idioma.Name = "lb_idioma";
            this.lb_idioma.Size = new System.Drawing.Size(81, 25);
            this.lb_idioma.TabIndex = 20;
            this.lb_idioma.Text = "Idioma :";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(464, 220);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(192, 25);
            this.lb_data.TabIndex = 22;
            this.lb_data.Text = "Data de Publicação :";
            this.lb_data.Click += new System.EventHandler(this.lb_data_Click);
            // 
            // txtbm_datapublicacao
            // 
            this.txtbm_datapublicacao.Location = new System.Drawing.Point(662, 225);
            this.txtbm_datapublicacao.Mask = "00/00/0000";
            this.txtbm_datapublicacao.Name = "txtbm_datapublicacao";
            this.txtbm_datapublicacao.Size = new System.Drawing.Size(67, 20);
            this.txtbm_datapublicacao.TabIndex = 23;
            this.txtbm_datapublicacao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            // 
            // frm_EditarExemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.txtbm_datapublicacao);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.txtbm_idioma);
            this.Controls.Add(this.lb_idioma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_genero);
            this.Controls.Add(this.txtbm_editora);
            this.Controls.Add(this.lb_capalivro);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.txtbm_ISBN);
            this.Controls.Add(this.txtbm_autor);
            this.Controls.Add(this.txtbm_titulo);
            this.Controls.Add(this.txtbm_id);
            this.Controls.Add(this.lb_editora);
            this.Controls.Add(this.lb_genero);
            this.Controls.Add(this.lb_autor);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.lb_ISBN);
            this.Controls.Add(this.lb_IDlivro);
            this.Controls.Add(this.label1);
            this.Name = "frm_EditarExemplares";
            this.Text = "EditarExemplares";
            this.Load += new System.EventHandler(this.frm_EditarExemplares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_IDlivro;
        private System.Windows.Forms.Label lb_ISBN;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label lb_autor;
        private System.Windows.Forms.Label lb_genero;
        private System.Windows.Forms.Label lb_editora;
        private System.Windows.Forms.TextBox txtbm_id;
        private System.Windows.Forms.TextBox txtbm_titulo;
        private System.Windows.Forms.TextBox txtbm_autor;
        private System.Windows.Forms.MaskedTextBox txtbm_ISBN;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.Label lb_capalivro;
        private System.Windows.Forms.TextBox txtbm_editora;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbm_idioma;
        private System.Windows.Forms.Label lb_idioma;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.MaskedTextBox txtbm_datapublicacao;
    }
}