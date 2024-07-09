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
    public partial class FormOpcao2 : Form
    {
        public FormOpcao2()
        {
            InitializeComponent();
        }

        private void btnNota2_Click(object sender, EventArgs e)
        {
            FormNotaFiscal2 formNotaFiscal2 = new FormNotaFiscal2();
            formNotaFiscal2.ShowDialog();
        }
    }
}
