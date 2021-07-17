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
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void btn_ObterData_Click(object sender, EventArgs e)
        {
            tb_DataCompleta.Text = dtp_Data.Text;

            tb_Dia.Text = dtp_Data.Value.Day.ToString();
            tb_Mes.Text = dtp_Data.Value.Month.ToString();
            tb_Ano.Text = dtp_Data.Value.Year.ToString();
        }

        private void btn_AlterarData_Click(object sender, EventArgs e)
        {

            int a, m, d;

            a = Int32.Parse(tb_NovoAno.Text);
            m = Int32.Parse(tb_NovoMes.Text);
            d = Int32.Parse(tb_NovoDia.Text);

            DateTime dt = new DateTime(a, m, d);

            dtp_Data.Value = dt;

            tb_DataCompleta.Text = dtp_Data.Text;
            tb_Dia.Text = dtp_Data.Value.Day.ToString();
            tb_Mes.Text = dtp_Data.Value.Month.ToString();
            tb_Ano.Text = dtp_Data.Value.Year.ToString();



        }

        private void btn_DataAtu_Click(object sender, EventArgs e)
        {
            dtp_Data.Value = DateTime.Today;
            
            tb_DataCompleta.Text = dtp_Data.Text;

            tb_Dia.Text = dtp_Data.Value.Day.ToString();
            tb_Mes.Text = dtp_Data.Value.Month.ToString();
            tb_Ano.Text = dtp_Data.Value.Year.ToString();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_Ano.Clear();
            tb_Mes.Clear();
            tb_Dia.Clear();
            tb_NovoAno.Clear();
            tb_NovoDia.Clear();
            tb_NovoMes.Clear();
            tb_DataCompleta.Clear();
        }
    }
}
