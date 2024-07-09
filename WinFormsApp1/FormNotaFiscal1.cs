using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormNotaFiscal1 : Form
    {
        public FormNotaFiscal1()
        {
            InitializeComponent();
        }

        private void FormNotaFiscal1_Load(object sender, EventArgs e)
        {
            // Exibe detales
            listViewItens.View = View.Details;
            // Permitir Selecionar Linha
            listViewItens.FullRowSelect = true;
            // Exibir linha no listView
            listViewItens.GridLines = true;
            // Permitir que usuario edit texto
            listViewItens.LabelEdit = true;

            listViewItens.Columns.Add("Codigo", 200, HorizontalAlignment.Left);
            listViewItens.Columns.Add("Nome", 400, HorizontalAlignment.Left);
            listViewItens.Columns.Add("Valor", 200, HorizontalAlignment.Left);
            textBox2.Text = "0";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.SubItems.Add(cbxProduto.Text);
            listViewItem.SubItems.Add(txtValor.Text);
            listViewItens.Items.Add(listViewItem);

            decimal valorTotal = Convert.ToDecimal(textBox2.Text) + Convert.ToDecimal(txtValor.Text);
            textBox2.Text = valorTotal.ToString();
            textBox3.Text = valorTotal.ToString();

            cbxProduto.Text = string.Empty;
            txtValor.Text = string.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                txtCNPJ.Text = "11111111111";
                textBox1.Text = "Rua 1111111111111, N: 11111111111";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                txtCNPJ.Text = "2222222222";
                textBox1.Text = "Rua 2222222222, N: 222222222";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                txtCNPJ.Text = "33333333333333";
                textBox1.Text = "Rua 333333333333, N: 333333333333";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }
    }
}
