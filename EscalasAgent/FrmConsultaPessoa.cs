using EscalasAgent.Infraestrutura.Repository;
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
    public partial class FrmConsultaPessoa : Form
    {
        private IPessoaRepositorio repositorio;
        public int id;
        public FrmConsultaPessoa(IPessoaRepositorio repositorio)
        {
            this.repositorio = repositorio;
            InitializeComponent();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            var lista = repositorio.Listar(p => p.Nome.Contains(txtconsulta.Text));

            dgdados.DataSource = lista;
            if (lista.Count > 0)
            {
                //dgdados.Columns["nome coluna"].Visible = false;
                dgdados.Columns["Nome"].HeaderText = "Nome Completo";
            }
        }

        private void dgdados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dgdados.Rows[e.RowIndex].Cells[0].Value;
            this.Close();
        }

        private void dgdados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
