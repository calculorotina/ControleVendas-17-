using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleVendas.pt.projeto.dao;
using ControleVendas.pt.projeto.model;
using ControleVendas.pt.projeto.view;

namespace ControleVendas.pt.projeto.view
{
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Models().LimparDados(this);
        }

        private void cmdgravar_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();
            obj.nome = txtnome.Text;
            obj.morada = txtmorada.Text;
            obj.cnpj = txtcnpj.Text;
            obj.cep = txtcep.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.telemovel = txtcelular.Text;
            obj.numero = txtnumero.Text;
            obj.estado = txtestado.Text;
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;

            FornecedoresDao dao = new FornecedoresDao();
            dao.CriarFornecedores(obj);

            tabelafornecedorgrid.DataSource = dao.ListarFornecedores();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();
            obj.codigo = int.Parse(txtcodigo.Text);
            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.telemovel = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.morada = txtmorada.Text;
            obj.numero = txtnumero.Text;
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtestado.Text;

            FornecedoresDao dao = new FornecedoresDao();
            dao.editarFornecedores(obj);

            tabelafornecedorgrid.DataSource = dao.ListarFornecedores();
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();

            obj.codigo = int.Parse(txtcodigo.Text);


            FornecedoresDao dao = new FornecedoresDao();
            dao.apagarFornecedores(obj);

            tabelafornecedorgrid.DataSource = dao.ListarFornecedores();
        }

        private void tabelafornecedor_Click(object sender, EventArgs e)
        {

        }

        private void tabelafornecedorgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelafornecedorgrid.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelafornecedorgrid.CurrentRow.Cells[1].Value.ToString();
            txtmorada.Text = tabelafornecedorgrid.CurrentRow.Cells[7].Value.ToString();
            txtcnpj.Text = tabelafornecedorgrid.CurrentRow.Cells[2].Value.ToString();
            txtcep.Text = tabelafornecedorgrid.CurrentRow.Cells[6].Value.ToString();
            txttelefone.Text = tabelafornecedorgrid.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = tabelafornecedorgrid.CurrentRow.Cells[5].Value.ToString();
            txtemail.Text = tabelafornecedorgrid.CurrentRow.Cells[3].Value.ToString();
            txtnumero.Text = tabelafornecedorgrid.CurrentRow.Cells[8].Value.ToString();
            txtestado.Text = tabelafornecedorgrid.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = tabelafornecedorgrid.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = tabelafornecedorgrid.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = tabelafornecedorgrid.CurrentRow.Cells[11].Value.ToString();

            tabfornecedor1.SelectedTab = tabelafornecedor;
        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            tabelafornecedorgrid.DefaultCellStyle.ForeColor = Color.Black;

            FornecedoresDao dao = new FornecedoresDao();
            tabelafornecedorgrid.DataSource = dao.ListarFornecedores();
        }
    }
}
