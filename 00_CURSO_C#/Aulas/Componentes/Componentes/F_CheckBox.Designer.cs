
namespace Componentes
{
    partial class F_CheckBox
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
            this.cb_Carro = new System.Windows.Forms.CheckBox();
            this.cb_Aviao = new System.Windows.Forms.CheckBox();
            this.cb_Navio = new System.Windows.Forms.CheckBox();
            this.cb_Onibus = new System.Windows.Forms.CheckBox();
            this.btn_SelecionarTrans = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Carro
            // 
            this.cb_Carro.AutoSize = true;
            this.cb_Carro.Location = new System.Drawing.Point(22, 29);
            this.cb_Carro.Name = "cb_Carro";
            this.cb_Carro.Size = new System.Drawing.Size(55, 19);
            this.cb_Carro.TabIndex = 0;
            this.cb_Carro.Text = "Carro";
            this.cb_Carro.UseVisualStyleBackColor = true;
            // 
            // cb_Aviao
            // 
            this.cb_Aviao.AutoSize = true;
            this.cb_Aviao.Location = new System.Drawing.Point(22, 75);
            this.cb_Aviao.Name = "cb_Aviao";
            this.cb_Aviao.Size = new System.Drawing.Size(56, 19);
            this.cb_Aviao.TabIndex = 1;
            this.cb_Aviao.Text = "Avião";
            this.cb_Aviao.UseVisualStyleBackColor = true;
            // 
            // cb_Navio
            // 
            this.cb_Navio.AutoSize = true;
            this.cb_Navio.Location = new System.Drawing.Point(22, 116);
            this.cb_Navio.Name = "cb_Navio";
            this.cb_Navio.Size = new System.Drawing.Size(57, 19);
            this.cb_Navio.TabIndex = 2;
            this.cb_Navio.Text = "Navio";
            this.cb_Navio.UseVisualStyleBackColor = true;
            // 
            // cb_Onibus
            // 
            this.cb_Onibus.AutoSize = true;
            this.cb_Onibus.Location = new System.Drawing.Point(22, 161);
            this.cb_Onibus.Name = "cb_Onibus";
            this.cb_Onibus.Size = new System.Drawing.Size(64, 19);
            this.cb_Onibus.TabIndex = 3;
            this.cb_Onibus.Text = "Onibûs";
            this.cb_Onibus.UseVisualStyleBackColor = true;
            // 
            // btn_SelecionarTrans
            // 
            this.btn_SelecionarTrans.Location = new System.Drawing.Point(117, 25);
            this.btn_SelecionarTrans.Name = "btn_SelecionarTrans";
            this.btn_SelecionarTrans.Size = new System.Drawing.Size(153, 69);
            this.btn_SelecionarTrans.TabIndex = 4;
            this.btn_SelecionarTrans.Text = "Selecionar";
            this.btn_SelecionarTrans.UseVisualStyleBackColor = true;
            this.btn_SelecionarTrans.Click += new System.EventHandler(this.btn_SelecionarTrans_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mostrar Form Filho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_SelecionarTrans);
            this.Controls.Add(this.cb_Onibus);
            this.Controls.Add(this.cb_Navio);
            this.Controls.Add(this.cb_Aviao);
            this.Controls.Add(this.cb_Carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SelecionarTrans;
        public System.Windows.Forms.CheckBox cb_Carro;
        public System.Windows.Forms.CheckBox cb_Aviao;
        public System.Windows.Forms.CheckBox cb_Navio;
        public System.Windows.Forms.CheckBox cb_Onibus;
        private System.Windows.Forms.Button button1;
    }
}