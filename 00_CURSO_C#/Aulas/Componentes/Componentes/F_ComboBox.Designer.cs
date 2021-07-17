
namespace Componentes
{
    partial class F_ComboBox
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
            this.txt_Item = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Resetar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Selecionados = new System.Windows.Forms.Button();
            this.cbb_Tranposrtes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_Item
            // 
            this.txt_Item.Location = new System.Drawing.Point(201, 265);
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(185, 23);
            this.txt_Item.TabIndex = 12;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(201, 294);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(185, 45);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adicionar Item na Lista:";
            // 
            // btn_Resetar
            // 
            this.btn_Resetar.Location = new System.Drawing.Point(201, 134);
            this.btn_Resetar.Name = "btn_Resetar";
            this.btn_Resetar.Size = new System.Drawing.Size(196, 51);
            this.btn_Resetar.TabIndex = 9;
            this.btn_Resetar.Text = "Resetar Lista";
            this.btn_Resetar.UseVisualStyleBackColor = true;
            this.btn_Resetar.Click += new System.EventHandler(this.btn_Resetar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(201, 81);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(196, 47);
            this.btn_Limpar.TabIndex = 8;
            this.btn_Limpar.Text = "Limpar Lista";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Selecionados
            // 
            this.btn_Selecionados.Location = new System.Drawing.Point(201, 30);
            this.btn_Selecionados.Name = "btn_Selecionados";
            this.btn_Selecionados.Size = new System.Drawing.Size(196, 45);
            this.btn_Selecionados.TabIndex = 7;
            this.btn_Selecionados.Text = "Mostrar Selecionados";
            this.btn_Selecionados.UseVisualStyleBackColor = true;
            this.btn_Selecionados.Click += new System.EventHandler(this.btn_Selecionados_Click);
            // 
            // cbb_Tranposrtes
            // 
            this.cbb_Tranposrtes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Tranposrtes.FormattingEnabled = true;
            this.cbb_Tranposrtes.Items.AddRange(new object[] {
            "Avião",
            "Carro",
            "Navio",
            "Onibûs",
            "Trêm"});
            this.cbb_Tranposrtes.Location = new System.Drawing.Point(12, 34);
            this.cbb_Tranposrtes.Name = "cbb_Tranposrtes";
            this.cbb_Tranposrtes.Size = new System.Drawing.Size(174, 23);
            this.cbb_Tranposrtes.Sorted = true;
            this.cbb_Tranposrtes.TabIndex = 13;
            this.cbb_Tranposrtes.SelectedIndexChanged += new System.EventHandler(this.cbb_Tranposrtes_SelectedIndexChanged);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 367);
            this.Controls.Add(this.cbb_Tranposrtes);
            this.Controls.Add(this.txt_Item);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Resetar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Selecionados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ComboBox";
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Item;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Resetar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Selecionados;
        private System.Windows.Forms.ComboBox cbb_Tranposrtes;
    }
}