namespace WinFormsApp1
{
    partial class FormNotaFiscal1
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
            comboBox1 = new ComboBox();
            txtCliente = new Label();
            panel1 = new Panel();
            listViewItens = new ListView();
            btnAdicionar = new Button();
            txtValor = new TextBox();
            lblValor = new Label();
            lblCodigoProduto = new Label();
            cbxProduto = new ComboBox();
            txtCNPJ = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cliente 1", "Cliente 2", "Cliente 3" });
            comboBox1.Location = new Point(12, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(412, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtCliente
            // 
            txtCliente.AutoSize = true;
            txtCliente.Location = new Point(12, 21);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(55, 20);
            txtCliente.TabIndex = 9;
            txtCliente.Text = "Cliente";
            // 
            // panel1
            // 
            panel1.Controls.Add(listViewItens);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(lblValor);
            panel1.Controls.Add(lblCodigoProduto);
            panel1.Controls.Add(cbxProduto);
            panel1.Location = new Point(12, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 243);
            panel1.TabIndex = 12;
            // 
            // listViewItens
            // 
            listViewItens.Location = new Point(3, 85);
            listViewItens.Name = "listViewItens";
            listViewItens.Size = new Size(679, 121);
            listViewItens.TabIndex = 17;
            listViewItens.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(588, 35);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 16;
            btnAdicionar.Text = "adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(437, 35);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 15;
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(437, 11);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(43, 20);
            lblValor.TabIndex = 14;
            lblValor.Text = "Valor";
            // 
            // lblCodigoProduto
            // 
            lblCodigoProduto.AutoSize = true;
            lblCodigoProduto.Location = new Point(3, 11);
            lblCodigoProduto.Name = "lblCodigoProduto";
            lblCodigoProduto.Size = new Size(62, 20);
            lblCodigoProduto.TabIndex = 13;
            lblCodigoProduto.Text = "Produto";
            // 
            // cbxProduto
            // 
            cbxProduto.FormattingEnabled = true;
            cbxProduto.Items.AddRange(new object[] { "Produto 1", "Produto 2", "Produto 3" });
            cbxProduto.Location = new Point(3, 34);
            cbxProduto.Name = "cbxProduto";
            cbxProduto.Size = new Size(412, 28);
            cbxProduto.TabIndex = 12;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(449, 45);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Size = new Size(287, 27);
            txtCNPJ.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(449, 21);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 17;
            label1.Text = "CNPJ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 115);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(724, 27);
            textBox1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 19;
            label2.Text = "Endereço";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(510, 635);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(642, 635);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 21;
            button2.Text = "Emitir Nota";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 450);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(193, 27);
            textBox2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 426);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 22;
            label3.Text = "Base ICMS";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(277, 450);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(193, 27);
            textBox3.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 426);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 24;
            label4.Text = "Valor Total Produtos";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(15, 523);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(721, 94);
            textBox4.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 500);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 27;
            label5.Text = "Pagamento";
            // 
            // FormNotaFiscal1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 710);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtCNPJ);
            Controls.Add(panel1);
            Controls.Add(txtCliente);
            Controls.Add(comboBox1);
            Name = "FormNotaFiscal1";
            Text = "FormNotaFiscal1";
            Load += FormNotaFiscal1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label txtCliente;
        private Panel panel1;
        private Button btnAdicionar;
        private TextBox txtValor;
        private Label lblValor;
        private Label lblCodigoProduto;
        private ComboBox cbxProduto;
        private ListView listViewItens;
        private TextBox txtCNPJ;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
    }
}