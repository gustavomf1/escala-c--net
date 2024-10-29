using EscalasAgent.Infraestrutura.Context;
namespace EscalasAgent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnacessar_Click(object sender, EventArgs e)
        {
            using (DbContextEscolaAgent db = new DbContextEscolaAgent())
            {

            }
        }
    }
}
