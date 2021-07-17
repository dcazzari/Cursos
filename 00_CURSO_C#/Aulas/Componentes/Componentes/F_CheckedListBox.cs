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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_Selecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach(string t in clb_Transportes.CheckedItems) 
            {
                txt += t + ", ";
            }

            MessageBox.Show(txt);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            clb_Transportes.Items.Clear();
        }

        private void btn_Resetar_Click(object sender, EventArgs e)
        {
            clb_Transportes.Items.Clear();
            //clb_Transportes.Items.Add("Carro", false);
            //clb_Transportes.Items.Add("Avião", false);
            //clb_Transportes.Items.Add("Navio", false);
            //clb_Transportes.Items.Add("Onibûs", false);
            //clb_Transportes.Items.Add("Trêm", false);

            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Onibûs");
            tr.Add("Trêm");

            clb_Transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_Item.Text == "")
            {
                MessageBox.Show("Digite um item para adicionar");
                txt_Item.Clear();
                txt_Item.Focus();
            }
            else
            {
                clb_Transportes.Items.Add(txt_Item.Text, false);
                txt_Item.Clear();
                txt_Item.Focus();

            }

        }
    }
}
