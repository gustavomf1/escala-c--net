

using EscalasAgent;

namespace FrmPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadPessoa frmCadPessoa = new FrmCadPessoa();
            InitializeComponent();
        }
    }
}
