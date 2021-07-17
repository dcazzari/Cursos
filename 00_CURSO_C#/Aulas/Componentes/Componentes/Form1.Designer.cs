
namespace Componentes
{
    partial class F_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.tb_Veiculo = new System.Windows.Forms.TextBox();
            this.tb_ListaVeiculos = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Valor_Num = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Menu_Componentes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Comp_Sub_Checkbox = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Comp_Sub_CheckedListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Comp_Sub_ComboBox = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Comp_Sub_DateTimePicker = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Comp_Sub_LinkLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Comp_Sub_ListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um Veiculo:";
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(300, 107);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // tb_Veiculo
            // 
            this.tb_Veiculo.Location = new System.Drawing.Point(94, 108);
            this.tb_Veiculo.Name = "tb_Veiculo";
            this.tb_Veiculo.Size = new System.Drawing.Size(200, 23);
            this.tb_Veiculo.TabIndex = 2;
            // 
            // tb_ListaVeiculos
            // 
            this.tb_ListaVeiculos.Location = new System.Drawing.Point(94, 148);
            this.tb_ListaVeiculos.Multiline = true;
            this.tb_ListaVeiculos.Name = "tb_ListaVeiculos";
            this.tb_ListaVeiculos.Size = new System.Drawing.Size(281, 199);
            this.tb_ListaVeiculos.TabIndex = 3;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(94, 353);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(281, 23);
            this.btn_Limpar.TabIndex = 4;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(94, 383);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(281, 23);
            this.btn_Mostrar.TabIndex = 5;
            this.btn_Mostrar.Text = "Mostrar Veiculos";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_Valor_Num
            // 
            this.btn_Valor_Num.Location = new System.Drawing.Point(94, 412);
            this.btn_Valor_Num.Name = "btn_Valor_Num";
            this.btn_Valor_Num.Size = new System.Drawing.Size(281, 23);
            this.btn_Valor_Num.TabIndex = 6;
            this.btn_Valor_Num.Text = "Mostrar Valor de num";
            this.btn_Valor_Num.UseVisualStyleBackColor = true;
            this.btn_Valor_Num.Click += new System.EventHandler(this.btn_Valor_Num_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Componentes});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(487, 24);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Menu_Componentes
            // 
            this.Menu_Componentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Comp_Sub_Checkbox,
            this.Menu_Comp_Sub_CheckedListBox,
            this.Menu_Comp_Sub_ComboBox,
            this.Menu_Comp_Sub_DateTimePicker,
            this.Menu_Comp_Sub_LinkLabel,
            this.Menu_Comp_Sub_ListBox});
            this.Menu_Componentes.Name = "Menu_Componentes";
            this.Menu_Componentes.Size = new System.Drawing.Size(94, 20);
            this.Menu_Componentes.Text = "Componentes";
            // 
            // Menu_Comp_Sub_Checkbox
            // 
            this.Menu_Comp_Sub_Checkbox.Name = "Menu_Comp_Sub_Checkbox";
            this.Menu_Comp_Sub_Checkbox.Size = new System.Drawing.Size(157, 22);
            this.Menu_Comp_Sub_Checkbox.Text = "CheckBox";
            this.Menu_Comp_Sub_Checkbox.Click += new System.EventHandler(this.Menu_Comp_Sub_Checkbox_Click);
            // 
            // Menu_Comp_Sub_CheckedListBox
            // 
            this.Menu_Comp_Sub_CheckedListBox.Name = "Menu_Comp_Sub_CheckedListBox";
            this.Menu_Comp_Sub_CheckedListBox.Size = new System.Drawing.Size(157, 22);
            this.Menu_Comp_Sub_CheckedListBox.Text = "CheckedListBox";
            this.Menu_Comp_Sub_CheckedListBox.Click += new System.EventHandler(this.Menu_Comp_Sub_CheckedListBox_Click);
            // 
            // Menu_Comp_Sub_ComboBox
            // 
            this.Menu_Comp_Sub_ComboBox.Name = "Menu_Comp_Sub_ComboBox";
            this.Menu_Comp_Sub_ComboBox.Size = new System.Drawing.Size(157, 22);
            this.Menu_Comp_Sub_ComboBox.Text = "ComboBox";
            this.Menu_Comp_Sub_ComboBox.Click += new System.EventHandler(this.Menu_Comp_Sub_ComboBox_Click);
            // 
            // Menu_Comp_Sub_DateTimePicker
            // 
            this.Menu_Comp_Sub_DateTimePicker.Name = "Menu_Comp_Sub_DateTimePicker";
            this.Menu_Comp_Sub_DateTimePicker.Size = new System.Drawing.Size(157, 22);
            this.Menu_Comp_Sub_DateTimePicker.Text = "DateTimePicker";
            this.Menu_Comp_Sub_DateTimePicker.Click += new System.EventHandler(this.Menu_Comp_Sub_DateTimePicker_Click);
            // 
            // Menu_Comp_Sub_LinkLabel
            // 
            this.Menu_Comp_Sub_LinkLabel.Name = "Menu_Comp_Sub_LinkLabel";
            this.Menu_Comp_Sub_LinkLabel.Size = new System.Drawing.Size(157, 22);
            this.Menu_Comp_Sub_LinkLabel.Text = "LinkLabel";
            this.Menu_Comp_Sub_LinkLabel.Click += new System.EventHandler(this.Menu_Comp_Sub_LinkLabel_Click);
            // 
            // Menu_Comp_Sub_ListBox
            // 
            this.Menu_Comp_Sub_ListBox.Name = "Menu_Comp_Sub_ListBox";
            this.Menu_Comp_Sub_ListBox.Size = new System.Drawing.Size(157, 22);
            this.Menu_Comp_Sub_ListBox.Text = "ListBox";
            this.Menu_Comp_Sub_ListBox.Click += new System.EventHandler(this.Menu_Comp_Sub_ListBox_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 464);
            this.Controls.Add(this.btn_Valor_Num);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.tb_ListaVeiculos);
            this.Controls.Add(this.tb_Veiculo);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes - CFB Cursos";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.TextBox tb_Veiculo;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_Valor_Num;
        public System.Windows.Forms.TextBox tb_ListaVeiculos;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Componentes;
        private System.Windows.Forms.ToolStripMenuItem Menu_Comp_Sub_Checkbox;
        private System.Windows.Forms.ToolStripMenuItem Menu_Comp_Sub_CheckedListBox;
        private System.Windows.Forms.ToolStripMenuItem Menu_Comp_Sub_ComboBox;
        private System.Windows.Forms.ToolStripMenuItem Menu_Comp_Sub_DateTimePicker;
        private System.Windows.Forms.ToolStripMenuItem Menu_Comp_Sub_LinkLabel;
        private System.Windows.Forms.ToolStripMenuItem Menu_Comp_Sub_ListBox;
    }
}

