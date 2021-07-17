using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Veiculos : Form
    {
        F_Principal f;
        public F_Veiculos(String v, F_Principal fp)
        {
            InitializeComponent();

            tb_Veiculos_Mostrar.Text = v;
            fp.num = 10;
            f = fp;
        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.tb_ListaVeiculos.Text = tb_Veiculos_Mostrar.Text;
        }
    }
}
