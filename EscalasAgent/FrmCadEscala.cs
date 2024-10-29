using EscalasAgent.Core.Entities;
using EscalasAgent.Infraestrutura.Context;
using EscalasAgent.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace EscalasAgent
{
    public partial class FrmCadEscala : Form
    {
        private IPessoaRepositorio pessoaRepositorio;
        private IEquipeRepositorio equipeRepositorio;
        private IEscalaRepositorio escalaRepositorio;

        public FrmCadEscala(IEscalaRepositorio escalaRepositorio, IPessoaRepositorio pessoaRepositorio,
            IEquipeRepositorio equipeRepositorio)
        {
            InitializeComponent();
            this.escalaRepositorio = escalaRepositorio;
            this.equipeRepositorio = equipeRepositorio;
            this.pessoaRepositorio = pessoaRepositorio;
        }

        private void FrmCadEscala_Load(object sender, EventArgs e)
        {
            cbequipe.DataSource = equipeRepositorio.ListarTodos();
            cbequipe.DisplayMember = "Name";
            cbequipe.ValueMember = "id";

            cbpessoasextras.DataSource = pessoaRepositorio.ListarTodos();
            cbpessoasextras.DisplayMember = "Nome";
            cbpessoasextras.ValueMember = "id";

            pdados.Enabled = false;
            btnnovo.Enabled = true;
            btnlocalizar.Enabled = true;
            btnalterar.Enabled = false;
            btncancelar.Enabled = false;
            btnexcluir.Enabled = false;
            btnsalvar.Enabled = false;
        }

        void limpar()
        {
            txtid.Text = string.Empty;
            txttitulo.Text = string.Empty;
            txtdescricao.Text = string.Empty;
            cbpessoasextras.Text = string.Empty;
            cbequipe.Text = string.Empty;
        }

        public Escala carregaPropriedade()
        {
            Escala escala;

            if (txtid.Text != "")
            {
                escala = escalaRepositorio.Recuperar(e => e.Id == int.Parse(txtid.Text));
            }
            else escala = new Escala();

            escala.Id = txtid.Text == "" ? 0 : int.Parse(txtid.Text);
            escala.Descricao = txtdescricao.Text;
            escala.Titulo = txttitulo.Text;
            escala.Data = dtdata.Value;
            escala.IdEquipe = (int)cbequipe.SelectedValue;
            return escala;
        }

        private void btnnovo_Click_1(object sender, EventArgs e)
        {
            pdados.Enabled = true;
            btnnovo.Enabled = false;
            btnlocalizar.Enabled = false;
            btnalterar.Enabled = false;
            btncancelar.Enabled = true;
            btnexcluir.Enabled = false;
            btnsalvar.Enabled = true;
            limpar();
            txttitulo.Focus();
        }

        private void btnsalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txttitulo.Text != string.Empty)
                {
                    Escala escala = carregaPropriedade();

                    if (escala.Id == 0)
                    {
                        escalaRepositorio.Inserir(escala);
                    }
                    else
                    {
                        escalaRepositorio.Alterar(escala);
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
                .GetRequiredService<FrmConsultaEscala>();
            form2.ShowDialog();

            if (form2.id > 0)
            {
                var escala = escalaRepositorio.Recuperar(p => p.Id == form2.id);
                txtid.Text = escala.Id.ToString();
                txttitulo.Text = escala.Titulo.ToString();
                txtdescricao.Text = escala.Descricao.ToString();
                txtidequipe.Text = escala.IdEquipe.ToString();
                cbequipe.SelectedValue = escala.IdEquipe;
                cbpessoasextras.Text = escala.PessoasExtras.ToString();
            }
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

        private void btnalterar_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                var escala = carregaPropriedade();
                escalaRepositorio.Alterar(escala);
                Program.serviceProvider.GetRequiredService<DbContextEscolaAgent>().SaveChanges();
                pdados.Enabled = true;
                btnnovo.Enabled = false;
                btnlocalizar.Enabled = false;
                btnalterar.Enabled = false;
                btncancelar.Enabled = true;
                btnexcluir.Enabled = false;
                btnsalvar.Enabled = true;
                txtdescricao.Focus();
            }
            else MessageBox.Show("Localize a escala");
        }

        private void btnexcluir_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {

                var escala = carregaPropriedade();
                escalaRepositorio.Excluir(escala);
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
            else MessageBox.Show("Localize a escala");
        }
    }
}
