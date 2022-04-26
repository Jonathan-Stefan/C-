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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void bt_pesquisa_Click(object sender, EventArgs e)
        {
            if (nomeDoVideo.Text == "")
            {
                MessageBox.Show("Digite o nome de um video");
                nomeDoVideo.Focus();
                return;
            }
            listaDeVideos.Text += nomeDoVideo.Text + ", ";

            nomeDoVideo.Clear();
            nomeDoVideo.Focus();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            listaDeVideos.Clear();
            nomeDoVideo.Clear();
            nomeDoVideo.Focus();            
        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            videosCurtidos videosCurtidos = new videosCurtidos(listaDeVideos.Text);
            videosCurtidos.ShowDialog();
        }

        private void nomeDoVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void visualizarVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Curtidos curtidos = new Curtidos();
            curtidos.ShowDialog();

        }

        private void listaDeCurtidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaDeCurtidos listaDeCurtidos = new listaDeCurtidos();
            listaDeCurtidos.ShowDialog();

        }
    }


}
