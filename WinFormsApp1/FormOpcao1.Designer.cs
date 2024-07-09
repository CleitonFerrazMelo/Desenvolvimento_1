namespace WinFormsApp1
{
    partial class FormOpcao1
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
            btnCliente = new Button();
            btnProduto = new Button();
            btnNota1 = new Button();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(25, 25);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(109, 48);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProduto
            // 
            btnProduto.Location = new Point(200, 25);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(111, 48);
            btnProduto.TabIndex = 1;
            btnProduto.Text = "Produto";
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click;
            // 
            // btnNota1
            // 
            btnNota1.Location = new Point(381, 25);
            btnNota1.Name = "btnNota1";
            btnNota1.Size = new Size(145, 48);
            btnNota1.TabIndex = 2;
            btnNota1.Text = "Nota Fiscal";
            btnNota1.UseVisualStyleBackColor = true;
            btnNota1.Click += btnNota1_Click;
            // 
            // FormOpcao1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNota1);
            Controls.Add(btnProduto);
            Controls.Add(btnCliente);
            Name = "FormOpcao1";
            Text = "Opção 1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCliente;
        private Button btnProduto;
        private Button btnNota1;
    }
}