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
    public partial class frm_MostrarTitulo : Form
    {
        public frm_MostrarTitulo()
        {
            InitializeComponent();
        }

        private void frm_MostrarTitulo_Load(object sender, EventArgs e)
        {
            BackColor = frm_Usuario.DefaultBackColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            
           if(MessageBox.Show("Confirmar Solicitação de empréstimo","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                frm_MostrarTitulo f = new frm_MostrarTitulo();
                f.ShowDialog();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ConsultarEm_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sair1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
