using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteca
{
    public partial class frm_EditarExemplares : Form
    {
        frm_ManterExemplares f;
        public frm_EditarExemplares(frm_ManterExemplares fm)
        {
            InitializeComponent();
            f = fm;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frm_EditarExemplares_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] exemplares = new string[8];

            if (txtbm_id.Text == "" || txtbm_ISBN.Text == "" || txtbm_titulo.Text == "" || txtbm_idioma.Text == ""
                || txtbm_editora.Text == "" || txtbm_datapublicacao.Text == "" || txtbm_autor.Text == "")
            {
                MessageBox.Show("todos os campos devem estar preechidos");
                txtbm_titulo.Focus();
                return;
            }
            else
            {
                exemplares[0] = txtbm_id.Text;
                exemplares[1] = txtbm_titulo.Text;
                exemplares[2] = txtbm_editora.Text;
                exemplares[3] = txtbm_autor.Text;
                exemplares[4] = txtbm_ISBN.Text;
                exemplares[5] = txtbm_idioma.Text;
                exemplares[6] = txtbm_datapublicacao.Text;
                exemplares[7] = cb_genero.Text;

                ListViewItem l = new ListViewItem(exemplares);
                f.lv_exemplares.Items.Add(l);
                this.Close();
            }
        }

        private void lb_data_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files (*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Um erro ocorreu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbm_autor.Clear();
            txtbm_datapublicacao.Clear();
            txtbm_editora.Clear();
            txtbm_id.Clear();
            txtbm_idioma.Clear();
            txtbm_ISBN.Clear();
            txtbm_titulo.Clear();
            cb_genero.Text = "";
            txtbm_id.Focus();

        }
    }
}