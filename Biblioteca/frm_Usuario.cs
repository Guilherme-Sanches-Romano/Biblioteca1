using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frm_Usuario : Form
    {
        public frm_Usuario()
        {
            InitializeComponent();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            if (txtb_usuario.Text == "adm" && txtb_senha.Text == "senha")
            {
                frm_MenuADM frm_MenuADM = new frm_MenuADM();
                frm_MenuADM.ShowDialog();
                Close();
            }
           else if(txtb_usuario.Text == "usuario" && txtb_senha.Text == "senha")
            {
                frm_MostrarTitulo frm_MostrarTitulo = new frm_MostrarTitulo();
                frm_MostrarTitulo.ShowDialog();
                Close();
            }
            else
            {
                this.lbl_aviso.Visible = true;
            }
        }

        private void lbl_senha_Click(object sender, EventArgs e)
        {

        }

        private void lbl_usuario_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frm_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void lbl_aviso_Click(object sender, EventArgs e)
        {

        }
    }
}
