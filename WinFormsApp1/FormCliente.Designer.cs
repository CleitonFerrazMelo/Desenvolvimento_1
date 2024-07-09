namespace WinFormsApp1
{
    partial class FormCliente
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
            btnSalvar = new Button();
            textBox1 = new TextBox();
            txtCnpj = new Label();
            label1 = new Label();
            txtRazaoSocial = new TextBox();
            label2 = new Label();
            txtInscricaoEstadual = new TextBox();
            label3 = new Label();
            txtEndereco = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(522, 306);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 27);
            textBox1.TabIndex = 1;
            // 
            // txtCnpj
            // 
            txtCnpj.AutoSize = true;
            txtCnpj.Location = new Point(12, 9);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(41, 20);
            txtCnpj.TabIndex = 2;
            txtCnpj.Text = "CNPJ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 4;
            label1.Text = "Razão Social";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(12, 130);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(467, 27);
            txtRazaoSocial.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 9);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 6;
            label2.Text = "Inscrição Estadual";
            // 
            // txtInscricaoEstadual
            // 
            txtInscricaoEstadual.Location = new Point(333, 42);
            txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            txtInscricaoEstadual.Size = new Size(283, 27);
            txtInscricaoEstadual.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 8;
            label3.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(12, 202);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(604, 27);
            txtEndereco.TabIndex = 7;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 346);
            Controls.Add(label3);
            Controls.Add(txtEndereco);
            Controls.Add(label2);
            Controls.Add(txtInscricaoEstadual);
            Controls.Add(label1);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtCnpj);
            Controls.Add(textBox1);
            Controls.Add(btnSalvar);
            Name = "FormCliente";
            Text = "FormCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox textBox1;
        private Label txtCnpj;
        private Label label1;
        private TextBox txtRazaoSocial;
        private Label label2;
        private TextBox txtInscricaoEstadual;
        private Label label3;
        private TextBox txtEndereco;
    }
}