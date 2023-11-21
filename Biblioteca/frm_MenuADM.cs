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
    public partial class frm_MenuADM : Form
    {
        public frm_MenuADM()
        {
            InitializeComponent();
        }

        private void btn_VerExemplares_Click(object sender, EventArgs e)
        {
            frm_ManterExemplares f = new frm_ManterExemplares();
            f.ShowDialog();
        }

        private void btn_VerClientes_Click(object sender, EventArgs e)
        {
            frm_ManterClientes f = new frm_ManterClientes();
            f.ShowDialog();
        }

        private void btn_Sair2_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
