using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcaVideos
{
    public partial class F_abaPesquisa : Form
    {
        public F_abaPesquisa()
        {
            InitializeComponent();
        }

        private void bt_addVideo_Click(object sender, EventArgs e)
        {
            if (tb_nomeVideo.Text != "")
            {
                clb_listavideos.Items.Add(tb_nomeVideo.Text);
                tb_nomeVideo.Clear(); ;
                tb_nomeVideo.Focus();
            }
        }

        private void tb_mostrar_Click(object sender, EventArgs e)
        {
            String txt = "";
            foreach (string t in clb_listavideos.CheckedItems)
            {
                txt += t + ", ";
            }


            MessageBox.Show(txt);
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            clb_listavideos.Items.Clear();
            tb_nomeVideo.Focus();
        }
    }
}
