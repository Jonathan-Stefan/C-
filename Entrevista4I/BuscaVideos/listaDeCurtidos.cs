using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaVideos
{
    public partial class listaDeCurtidos : Form
    {
        public listaDeCurtidos()
        {
            InitializeComponent();
        }

        private void bt_mostrarselecionados_Click(object sender, EventArgs e)
        {
            String txt = "";
            foreach(string t in listaGostei.CheckedItems)
            {
                txt += t + ", ";
            }
    

            MessageBox.Show(txt);
        }

        private void bt_adicionarNovoVideo_Click(object sender, EventArgs e)
        {
            if (tb_addVideo.Text != "")
            {
                listaGostei.Items.Add(tb_addVideo.Text);
                tb_addVideo.Clear(); ;
                tb_addVideo.Focus();
            }
        }
    }
}
