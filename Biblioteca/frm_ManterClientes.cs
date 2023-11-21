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
    public partial class frm_ManterClientes : Form
    {
        public frm_ManterClientes()
        {
            InitializeComponent();
        }

        private void frm_ManterClientes_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Exemplares_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SubBibliSofi1_Click(object sender, EventArgs e)
        {

        }

        private void btn_CriarCliente_Click(object sender, EventArgs e)
        {
            frm_EditarPefilClietne frm_EditarPefilClietne = new frm_EditarPefilClietne(this);
            frm_EditarPefilClietne.ShowDialog();

        }

        private void lv_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ExcluirCliente_Click(object sender, EventArgs e)
        {
            lv_clientes.Items.RemoveAt(lv_clientes.SelectedIndices[0]);
        }

        private void btn_Sair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
