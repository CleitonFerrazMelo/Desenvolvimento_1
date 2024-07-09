namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOpcao1 tela1 = new FormOpcao1();
            tela1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormOpcao2 tela2 = new FormOpcao2();
            tela2.ShowDialog();
        }
    }
}
