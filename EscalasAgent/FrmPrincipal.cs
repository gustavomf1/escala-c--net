using EscalasAgent.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalasAgent
{
    public partial class FrmPrincipal : Form
    {
        private IPessoaRepositorio repositorio;
        public FrmPrincipal(IPessoaRepositorio repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form2 = Program.serviceProvider
                .GetRequiredService<FrmCadPessoa>())
                form2.ShowDialog();
        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form2 = Program.serviceProvider
                .GetRequiredService<FrmCadEquipe>())
                form2.ShowDialog();
        }

        private void escalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form2 = Program.serviceProvider
                .GetRequiredService<FrmCadEscala>())
                form2.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            var frm = 
                Program.serviceProvider.GetRequiredService<FrmLogin>();
            frm.ShowDialog();
            if (frm.IdPessoa > 0)
            {
                var pessoa = repositorio.Recuperar(p => p.Id == frm.IdPessoa);

                lbllogin.Text = "Bem-Vindo " + pessoa.Nome;
            }
            else
                this.Close();
        }
    }
}
