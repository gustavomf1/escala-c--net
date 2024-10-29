using EscalasAgent.Core.Entities;
using EscalasAgent.Infraestrutura.Context;
using EscalasAgent.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EscalasAgent
{
    public partial class FrmCadEquipe : Form
    {

        private IEquipeRepositorio repositorio;

        public FrmCadEquipe(IEquipeRepositorio repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private void FrmCadPessoa_Load(object sender, EventArgs e)
        {
            pdados.Enabled = false;
            btnnovo.Enabled = true;
            btnlocalizar.Enabled = true;
            btnalterar.Enabled = false;
            btncancelar.Enabled = false;
            btnexcluir.Enabled = false;
            btnsalvar.Enabled = false;
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            pdados.Enabled = true;
            btnnovo.Enabled = false;
            btnlocalizar.Enabled = false;
            btnalterar.Enabled = false;
            btncancelar.Enabled = true;
            btnexcluir.Enabled = false;
            btnsalvar.Enabled = true;
            limpar();
            txtnome.Focus();
        }

        void limpar()
        {
            txtid.Text = string.Empty;
            txtnome.Text = string.Empty;
        }

        public Equipe carregaPropriedade()
        {
            Equipe equipe;

            if (txtid.Text != "")
            {
                equipe = repositorio.Recuperar(p => p.Id == int.Parse(txtid.Text));
            }
            else equipe = new Equipe();

            equipe.Id = txtid.Text == "" ? 0 : int.Parse(txtid.Text);
            equipe.Name = txtnome.Text;
            return equipe;
        }

        private void btnlocalizar_Click_1(object sender, EventArgs e)
        {
            pdados.Enabled = false;
            btnnovo.Enabled = false;
            btnlocalizar.Enabled = false;
            btnalterar.Enabled = true;
            btncancelar.Enabled = true;
            btnexcluir.Enabled = true;
            btnsalvar.Enabled = false;

            var form2 = Program.serviceProvider
                .GetRequiredService<FrmConsultaEquipe>();
            form2.ShowDialog();

            if (form2.id > 0)
            {
                var equipe = repositorio.Recuperar(p => p.Id == form2.id);
                txtid.Text = equipe.Id.ToString();
                txtnome.Text = equipe.Name.ToString();
            }
        }

        private void btnalterar_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                var equipe = carregaPropriedade();
                repositorio.Alterar(equipe);
                Program.serviceProvider.GetRequiredService<DbContextEscolaAgent>().SaveChanges();
                pdados.Enabled = true;
                btnnovo.Enabled = false;
                btnlocalizar.Enabled = false;
                btnalterar.Enabled = false;
                btncancelar.Enabled = true;
                btnexcluir.Enabled = false;
                btnsalvar.Enabled = true;
                txtnome.Focus();
            }
            else MessageBox.Show("Localize a equipe!");
        }

        private void btnsalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtnome.Text != string.Empty)
                {
                    Equipe equipe = carregaPropriedade();

                    if (equipe.Id == 0)
                    {
                        repositorio.Inserir(equipe);
                    }
                    else
                    {
                        repositorio.Alterar(equipe);
                    }

                    Program.serviceProvider.GetRequiredService<DbContextEscolaAgent>().SaveChanges();

                    MessageBox.Show("Salvo com sucesso");

                    limpar();

                    pdados.Enabled = false;
                    btnnovo.Enabled = true;
                    btnlocalizar.Enabled = true;
                    btnalterar.Enabled = false;
                    btncancelar.Enabled = false;
                    btnexcluir.Enabled = false;
                    btnsalvar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            limpar();
            pdados.Enabled = false;
            btnnovo.Enabled = true;
            btnlocalizar.Enabled = true;
            btnalterar.Enabled = false;
            btncancelar.Enabled = false;
            btnexcluir.Enabled = false;
            btnsalvar.Enabled = false;
        }

        private void btnexcluir_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {

                var pessoa = carregaPropriedade();
                repositorio.Excluir(pessoa);
                Program.serviceProvider.GetRequiredService<DbContextEscolaAgent>().SaveChanges();
                MessageBox.Show("Excluido com sucesso!");
                limpar();
                pdados.Enabled = false;
                btnnovo.Enabled = true;
                btnlocalizar.Enabled = true;
                btnalterar.Enabled = false;
                btncancelar.Enabled = false;
                btnexcluir.Enabled = false;
                btnsalvar.Enabled = false;
            }
            else MessageBox.Show("Localize a categoria");
        }
    }


}

