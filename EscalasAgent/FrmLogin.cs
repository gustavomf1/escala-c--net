using EscalasAgent.Interfaces;
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
    public partial class FrmLogin : Form
    {
        private IPessoaRepositorio repositorio;
        public int IdPessoa = 0;
        public FrmLogin(IPessoaRepositorio repositorio)
        {
            this.repositorio = repositorio;
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtemail.Text != "" && txtsenha.Text != "")
            {
                var pessoa = repositorio.Recuperar(f =>
                f.Email == txtemail.Text && f.Senha == txtsenha.Text);
                if (pessoa != null)
                {
                    IdPessoa = pessoa.Id;
                    this.Close();
                }
                else
                    MessageBox.Show("Dados incorretos.");
            }
            else
                MessageBox.Show("Informar login e senha!");
        }
    }
}
