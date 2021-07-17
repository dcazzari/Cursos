
namespace Componentes
{
    partial class F_DateTimePicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.tb_DataCompleta = new System.Windows.Forms.TextBox();
            this.tb_Dia = new System.Windows.Forms.TextBox();
            this.tb_Mes = new System.Windows.Forms.TextBox();
            this.tb_Ano = new System.Windows.Forms.TextBox();
            this.btn_ObterData = new System.Windows.Forms.Button();
            this.tb_NovoAno = new System.Windows.Forms.TextBox();
            this.tb_NovoMes = new System.Windows.Forms.TextBox();
            this.tb_NovoDia = new System.Windows.Forms.TextBox();
            this.btn_AlterarData = new System.Windows.Forms.Button();
            this.btn_DataAtu = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_Data
            // 
            this.dtp_Data.Location = new System.Drawing.Point(28, 22);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(427, 23);
            this.dtp_Data.TabIndex = 0;
            // 
            // tb_DataCompleta
            // 
            this.tb_DataCompleta.Enabled = false;
            this.tb_DataCompleta.Location = new System.Drawing.Point(28, 64);
            this.tb_DataCompleta.Name = "tb_DataCompleta";
            this.tb_DataCompleta.Size = new System.Drawing.Size(427, 23);
            this.tb_DataCompleta.TabIndex = 1;
            // 
            // tb_Dia
            // 
            this.tb_Dia.Enabled = false;
            this.tb_Dia.Location = new System.Drawing.Point(28, 105);
            this.tb_Dia.Name = "tb_Dia";
            this.tb_Dia.Size = new System.Drawing.Size(139, 23);
            this.tb_Dia.TabIndex = 2;
            // 
            // tb_Mes
            // 
            this.tb_Mes.Enabled = false;
            this.tb_Mes.Location = new System.Drawing.Point(173, 104);
            this.tb_Mes.Name = "tb_Mes";
            this.tb_Mes.Size = new System.Drawing.Size(153, 23);
            this.tb_Mes.TabIndex = 3;
            // 
            // tb_Ano
            // 
            this.tb_Ano.Enabled = false;
            this.tb_Ano.Location = new System.Drawing.Point(332, 104);
            this.tb_Ano.Name = "tb_Ano";
            this.tb_Ano.Size = new System.Drawing.Size(123, 23);
            this.tb_Ano.TabIndex = 4;
            // 
            // btn_ObterData
            // 
            this.btn_ObterData.Location = new System.Drawing.Point(481, 21);
            this.btn_ObterData.Name = "btn_ObterData";
            this.btn_ObterData.Size = new System.Drawing.Size(143, 23);
            this.btn_ObterData.TabIndex = 5;
            this.btn_ObterData.Text = "Obter Data";
            this.btn_ObterData.UseVisualStyleBackColor = true;
            this.btn_ObterData.Click += new System.EventHandler(this.btn_ObterData_Click);
            // 
            // tb_NovoAno
            // 
            this.tb_NovoAno.Location = new System.Drawing.Point(332, 231);
            this.tb_NovoAno.Name = "tb_NovoAno";
            this.tb_NovoAno.Size = new System.Drawing.Size(123, 23);
            this.tb_NovoAno.TabIndex = 8;
            // 
            // tb_NovoMes
            // 
            this.tb_NovoMes.Location = new System.Drawing.Point(173, 231);
            this.tb_NovoMes.Name = "tb_NovoMes";
            this.tb_NovoMes.Size = new System.Drawing.Size(153, 23);
            this.tb_NovoMes.TabIndex = 7;
            // 
            // tb_NovoDia
            // 
            this.tb_NovoDia.Location = new System.Drawing.Point(28, 232);
            this.tb_NovoDia.Name = "tb_NovoDia";
            this.tb_NovoDia.Size = new System.Drawing.Size(139, 23);
            this.tb_NovoDia.TabIndex = 6;
            // 
            // btn_AlterarData
            // 
            this.btn_AlterarData.Location = new System.Drawing.Point(481, 230);
            this.btn_AlterarData.Name = "btn_AlterarData";
            this.btn_AlterarData.Size = new System.Drawing.Size(143, 23);
            this.btn_AlterarData.TabIndex = 9;
            this.btn_AlterarData.Text = "Alterar Data";
            this.btn_AlterarData.UseVisualStyleBackColor = true;
            this.btn_AlterarData.Click += new System.EventHandler(this.btn_AlterarData_Click);
            // 
            // btn_DataAtu
            // 
            this.btn_DataAtu.Location = new System.Drawing.Point(481, 63);
            this.btn_DataAtu.Name = "btn_DataAtu";
            this.btn_DataAtu.Size = new System.Drawing.Size(143, 23);
            this.btn_DataAtu.TabIndex = 10;
            this.btn_DataAtu.Text = "Obter data Atual";
            this.btn_DataAtu.UseVisualStyleBackColor = true;
            this.btn_DataAtu.Click += new System.EventHandler(this.btn_DataAtu_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(211, 295);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(222, 37);
            this.btn_Limpar.TabIndex = 11;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_DataAtu);
            this.Controls.Add(this.btn_AlterarData);
            this.Controls.Add(this.tb_NovoAno);
            this.Controls.Add(this.tb_NovoMes);
            this.Controls.Add(this.tb_NovoDia);
            this.Controls.Add(this.btn_ObterData);
            this.Controls.Add(this.tb_Ano);
            this.Controls.Add(this.tb_Mes);
            this.Controls.Add(this.tb_Dia);
            this.Controls.Add(this.tb_DataCompleta);
            this.Controls.Add(this.dtp_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_DateTimePicker";
            this.Text = "F_DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.TextBox tb_DataCompleta;
        private System.Windows.Forms.TextBox tb_Dia;
        private System.Windows.Forms.TextBox tb_Mes;
        private System.Windows.Forms.TextBox tb_Ano;
        private System.Windows.Forms.Button btn_ObterData;
        private System.Windows.Forms.TextBox tb_NovoAno;
        private System.Windows.Forms.TextBox tb_NovoMes;
        private System.Windows.Forms.TextBox tb_NovoDia;
        private System.Windows.Forms.Button btn_AlterarData;
        private System.Windows.Forms.Button btn_DataAtu;
        private System.Windows.Forms.Button btn_Limpar;
    }
}