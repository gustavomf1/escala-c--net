using EscalasAgent.Core.Entities;
using EscalasAgent.Infraestrutura.Context;
using EscalasAgent.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EscalasAgent
{
    public partial class FrmCadPessoa : Form
    {
        private IPessoaRepositorio repositorio;
        private IEquipeRepositorio equipeRepositorio;

        public FrmCadPessoa(IPessoaRepositorio repositorio, IEquipeRepositorio equipeRepositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
            this.equipeRepositorio = equipeRepositorio;
        }

        private void FrmCadPessoa_Load(object sender, EventArgs e)
        {
            cbEquipe.DataSource = equipeRepositorio.ListarTodos();
            cbEquipe.DisplayMember = "Name";
            cbEquipe.ValueMember = "id";

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
            txtcpf.Focus();
        }

        void limpar()
        {
            txtid.Text = string.Empty;
            txtativo.Text = string.Empty;
            txtcpf.Text = string.Empty;
            txtnome.Text = string.Empty;
            txtidequipe.Text = string.Empty;
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                var pessoa = carregaPropriedade();
                repositorio.Alterar(pessoa);
                Program.serviceProvider.GetRequiredService<DbContextEscolaAgent>().SaveChanges();
                pdados.Enabled = true;
                btnnovo.Enabled = false;
                btnlocalizar.Enabled = false;
                btnalterar.Enabled = false;
                btncancelar.Enabled = true;
                btnexcluir.Enabled = false;
                btnsalvar.Enabled = true;
                txtcpf.Focus();
            }
            else MessageBox.Show("Localize a categoria");

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcpf.Text != string.Empty)
                {
                    Pessoa pessoa = carregaPropriedade();

                    if (pessoa.Id == 0)
                    {
                        repositorio.Inserir(pessoa);
                    }
                    else
                    {
                        repositorio.Alterar(pessoa);
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

        public Pessoa carregaPropriedade()
        {
            Pessoa pessoa;

            if (txtid.Text != "")
            {
                pessoa = repositorio.Recuperar(p => p.Id == int.Parse(txtid.Text));
            }
            else pessoa = new Pessoa();

            pessoa.Id = txtid.Text == "" ? 0 : int.Parse(txtid.Text);
            pessoa.Cpf = txtcpf.Text;
            pessoa.Nome = txtnome.Text;
            pessoa.ativo = true;
            pessoa.dataCadasto = DateTime.Now;
            pessoa.IdEquipe = (int)cbEquipe.SelectedValue;
            pessoa.Email = txtemail.Text;
            pessoa.Senha = txtsenha.Text;
            return pessoa;
        }



        private void btncancelar_Click(object sender, EventArgs e)
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

        private void btnexcluir_Click(object sender, EventArgs e)
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

        private void btnlocalizar_Click(object sender, EventArgs e)
        {
            pdados.Enabled = false;
            btnnovo.Enabled = false;
            btnlocalizar.Enabled = false;
            btnalterar.Enabled = true;
            btncancelar.Enabled = true;
            btnexcluir.Enabled = true;
            btnsalvar.Enabled = false;

            var form2 = Program.serviceProvider
                .GetRequiredService<FrmConsultaPessoa>();
            form2.ShowDialog();

            if (form2.id > 0)
            {
                var cat = repositorio.Recuperar(p => p.Id == form2.id);
                txtid.Text = cat.Id.ToString();
                txtnome.Text = cat.Nome.ToString();
                txtcpf.Text = cat.Cpf.ToString();
                txtidequipe.Text = cat.IdEquipe.ToString();
                cbEquipe.SelectedValue = cat.IdEquipe;
            }
        }

    }
}
