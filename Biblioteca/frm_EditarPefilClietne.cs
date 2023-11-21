using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteca
{
    public partial class frm_EditarPefilClietne : Form
    {
        frm_ManterClientes fc;
        public frm_EditarPefilClietne(frm_ManterClientes f)
        {
            InitializeComponent();
            fc = f;
        }

        private void frm_EditarPefilClietne_Load(object sender, EventArgs e)
        {

        }

        private void lbl_CEP_Click(object sender, EventArgs e)
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

    private void lbl_NomeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lbl_EnderecoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frm_EditarPefilClietne_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_criarperfil_Click(object sender, EventArgs e)
        {
            string[] cliente = new string[7];
            
            if(txtbm_idcliente.Text == "" || txtbm_NomeDoCliente.Text == "" || txtbm_CPF.Text == "" || txtbm_Endereco.Text == "" 
                || txtbm_Tel.Text == "" || txtbm_CEP.Text == "" || txtbm_cadastrocliente.Text == "" )
            {
                MessageBox.Show("todos os campos devem estar preechidos");
                txtbm_NomeDoCliente.Focus();
                return;          
            }
            else
            {
                cliente[0] = txtbm_idcliente.Text;
                cliente[1] = txtbm_NomeDoCliente.Text;
                cliente[2] = txtbm_CPF.Text;
                cliente[3] = txtbm_Endereco.Text;
                cliente[4] = txtbm_Tel.Text;
                cliente[5] = txtbm_CEP.Text;
                cliente[6] = txtbm_cadastrocliente.Text;

                ListViewItem l = new ListViewItem(cliente);
                fc.lv_clientes.Items.Add(l);
                this.Close();
            }

        }
    }
}
