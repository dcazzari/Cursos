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
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();
            carros.Add("Prisma");
            carros.Add("Corolla");
            carros.Add("Civic");
            carros.Add("Golf");
            lb_Carros.DataSource = carros;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Carro.Text == "")
            {
                MessageBox.Show("Digite um carro para adicionar.");
                tb_Carro.Clear();
                tb_Carro.Focus();
            }
            else
            {
                carros.Add(tb_Carro.Text);
                lb_Carros.DataSource = null;
                lb_Carros.DataSource = carros;
                tb_Carro.Clear();
            }


        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            try
            {
                carros.RemoveAt(lb_Carros.SelectedIndex);
                lb_Carros.DataSource = null;
                lb_Carros.DataSource = carros;
            }
            catch
            {
                MessageBox.Show("Não existe carro na lista.");
            }


        }

        private void btn_Obter_Click(object sender, EventArgs e)
        {
            tb_Carro.Text = carros[lb_Carros.SelectedIndex];
                
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            lb_Carros.DataSource = null;
            lb_Carros.DataSource = carros;
        }
    }
}
