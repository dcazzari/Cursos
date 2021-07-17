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
    public partial class F_Principal : Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (tb_Veiculo.Text == "")
            {
                MessageBox.Show("Digite um veiculo: ");
                tb_Veiculo.Focus();
                return;

            }
            else
            {
                tb_ListaVeiculos.Text += tb_Veiculo.Text + ", ";
                tb_Veiculo.Clear();
                tb_Veiculo.Focus();
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_Veiculo.Clear();
            tb_ListaVeiculos.Clear();
            tb_Veiculo.Focus();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_ListaVeiculos.Text, this);
            //f_Veiculos.Show() - exibe a janela permitindo mudar o foco das janelas
            f_Veiculos.ShowDialog(); //exibe janela fixando, para voltar para principal ela precisa ser fechada 
            
        }

        private void btn_Valor_Num_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Comp_Sub_Checkbox_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void Menu_Comp_Sub_CheckedListBox_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }

        private void Menu_Comp_Sub_ComboBox_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }

        private void Menu_Comp_Sub_DateTimePicker_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }

        private void Menu_Comp_Sub_LinkLabel_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();
        }

        private void Menu_Comp_Sub_ListBox_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }
    }
}
