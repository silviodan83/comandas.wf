namespace Comandas.Wf
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            new FormCardapio().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
