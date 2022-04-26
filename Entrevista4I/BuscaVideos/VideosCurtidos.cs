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
    public partial class videosCurtidos : Form
    {
        public videosCurtidos(String v)
        {
            InitializeComponent();

            listaVideos.Text = v;
        }
    }
}
