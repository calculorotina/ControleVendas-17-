using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleVendas.pt.projeto.dao;
using ControleVendas.pt.projeto.model;
using ControleVendas.pt.projeto.view;
using MySql.Data.MySqlClient;

namespace ControleVendas.pt.projeto.view
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void tabprodutos_Click(object sender, EventArgs e)
        {

        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            FornecedoresDao dao = new FornecedoresDao();
            txtfornecedor.DataSource = dao.ListarFornecedores();
            txtfornecedor.DisplayMember = "nome";
            txtfornecedor.ValueMember = "id";

            dataproduto.DefaultCellStyle.ForeColor = Color.Black;

            ProdutosDao prod = new ProdutosDao();
            dataproduto.DataSource = prod.ListarProdutos();
        }

        private void dataproduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdescricao.Text = dataproduto.CurrentRow.Cells[0].Value.ToString();
            numericUpDown1.Text = dataproduto.CurrentRow.Cells[1].Value.ToString();
            txtquantidade.Text = dataproduto.CurrentRow.Cells[7].Value.ToString();
            numericUpDown1.Text = dataproduto.CurrentRow.Cells[2].Value.ToString();
            txtfamilia.Text = dataproduto.CurrentRow.Cells[6].Value.ToString();
            txtfornecedor.Text = dataproduto.CurrentRow.Cells[4].Value.ToString();

            tabelaprodutos.SelectedTab = tabprodutos;
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Models().LimparDados(this);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            Produtos obj = new Produtos();
            Fornecedores forn = new Fornecedores();
            obj.descricao = txtdescricao.Text;
            obj.preco = numericUpDown1.Text;
            obj.quantidade = txtquantidade.Text;
            obj.familia = txtfamilia.Text;
            forn.nome = txtfornecedor.Text;

            ProdutosDao dao = new ProdutosDao();
            dao.CriarProdutos(obj);

            dataproduto.DataSource = dao.ListarProdutos();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Produtos obj = new Produtos();
            obj.codigo = txtcodigo.Text;
            obj.descricao = txtdescricao.Text;
            obj.preco = System.Convert.ToString(txtpreco.Text);
            obj.quantidade = txtquantidade.Text;
            obj.familia = txtfamilia.Text;
            //obj.for_id = txtfornecedor.Text;

            ProdutosDao dao = new ProdutosDao();
            dao.editarProdutos(obj);

            dataproduto.DataSource = dao.ListarProdutos();
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            Produtos obj = new Produtos();

            obj.codigo = txtcodigo.Text;


            ProdutosDao dao = new ProdutosDao();
            dao.apagarProdutos(obj);

            dataproduto.DataSource = dao.ListarProdutos();
        }

        private void dataproduto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dataproduto.CurrentRow.Cells[0].Value.ToString();
            txtdescricao.Text = dataproduto.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = dataproduto.CurrentRow.Cells[2].Value.ToString();
            txtquantidade.Text = dataproduto.CurrentRow.Cells[3].Value.ToString();
            txtfamilia.Text = dataproduto.CurrentRow.Cells[4].Value.ToString();
            txtfornecedor.Text = dataproduto.CurrentRow.Cells[5].Value.ToString();

            tabelaprodutos.SelectedTab = tabprodutos;
        }

        private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            ProdutosDao dao = new ProdutosDao();

            dataproduto.DataSource = dao.pesquisaProdutos(nome);
        }
    }
    }

