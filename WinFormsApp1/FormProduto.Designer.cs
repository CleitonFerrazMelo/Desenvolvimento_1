namespace WinFormsApp1
{
    partial class FormProduto
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
            Nome = new Label();
            txtInscricaoEstadual = new TextBox();
            txtCnpj = new Label();
            txtCodigo = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(12, 103);
            Nome.Name = "Nome";
            Nome.Size = new Size(50, 20);
            Nome.TabIndex = 10;
            Nome.Text = "Nome";
            // 
            // txtInscricaoEstadual
            // 
            txtInscricaoEstadual.Location = new Point(12, 136);
            txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            txtInscricaoEstadual.Size = new Size(605, 27);
            txtInscricaoEstadual.TabIndex = 9;
            // 
            // txtCnpj
            // 
            txtCnpj.AutoSize = true;
            txtCnpj.Location = new Point(12, 21);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(58, 20);
            txtCnpj.TabIndex = 8;
            txtCnpj.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 54);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(283, 27);
            txtCodigo.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(523, 189);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 255);
            Controls.Add(btnSalvar);
            Controls.Add(Nome);
            Controls.Add(txtInscricaoEstadual);
            Controls.Add(txtCnpj);
            Controls.Add(txtCodigo);
            Name = "FormProduto";
            Text = "FormProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nome;
        private TextBox txtInscricaoEstadual;
        private Label txtCnpj;
        private TextBox txtCodigo;
        private Button btnSalvar;
    }
}