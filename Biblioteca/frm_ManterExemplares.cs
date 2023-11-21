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
    public partial class frm_ManterExemplares : Form
    {
        public frm_ManterExemplares()
        {
            InitializeComponent();
        }

        private void lbl_TituloDisp_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SubBibliSofi1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ConsultarEm_Click(object sender, EventArgs e)
        {
            lv_exemplares.Items.RemoveAt(lv_exemplares.SelectedIndices[0]); 
        }

        private void btn_SolicitarEm_Click(object sender, EventArgs e)
        {
            frm_EditarExemplares frm_EditarExemplares = new frm_EditarExemplares(this);
            frm_EditarExemplares.ShowDialog();
        }

        private void btn_Sair1_Click(object sender, EventArgs e)
        {
 
            this.Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
