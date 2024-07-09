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
    public partial class FormOpcao1 : Form
    {
        public FormOpcao1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.ShowDialog();
        }

        private void btnNota1_Click(object sender, EventArgs e)
        {
            FormNotaFiscal1 formNotaFiscal1 = new FormNotaFiscal1();
            formNotaFiscal1.ShowDialog();
        }
    }
}
