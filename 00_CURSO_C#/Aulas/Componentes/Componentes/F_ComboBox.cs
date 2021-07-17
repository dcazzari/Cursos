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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_Selecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbb_Tranposrtes.Text);
        }

        private void btn_Resetar_Click(object sender, EventArgs e)
        {
            cbb_Tranposrtes.Items.Clear();
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Onibûs");
            tr.Add("Trêm");

            cbb_Tranposrtes.Items.AddRange(tr.ToArray());
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            cbb_Tranposrtes.Items.Clear();
        }

        private void cbb_Tranposrtes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Item.Text = cbb_Tranposrtes.Text;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Item.Text == "")
            {
                MessageBox.Show("Digite um item para adicionar");
                txt_Item.Clear();
                txt_Item.Focus();
                
            }
            else
            {
                if (cbb_Tranposrtes.FindString(txt_Item.Text) < 0)
                {
                    cbb_Tranposrtes.Items.Add(txt_Item.Text);
                    txt_Item.Clear();
                    txt_Item.Focus();
                }
                else
                {
                    MessageBox.Show("Item já está presente na lista");
                    txt_Item.Clear();
                    txt_Item.Focus();
                }


            }
        }
    }
}
