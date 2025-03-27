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

namespace ControleVendas.pt.projeto.view
{
    public partial class frmVendas : Form
    {
        Produtos p = new Produtos();
        ProdutosDao pdao = new ProdutosDao();

        clientes c = new clientes();
        ClienteDao clienteDao = new ClienteDao();

        int qtd;
        decimal preco;
        decimal subtotal, total;
        DataTable carrinho = new DataTable();
        public frmVendas()
        {
            InitializeComponent();
            carrinho.Columns.Add("Codigo", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaprodutos.DataSource = carrinho;

        }

        private void txtcodigoproduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                p = pdao.ListarProdutosCodigo(int.Parse(txtcodigoproduto.Text));

                txtcodigoproduto.Text = p.codigo.ToString();
                txtdescricaoproduto.Text = p.descricao.ToString();
                txtpreco.Text = p.preco.ToString();
            }
        }

        private void txtcodigocliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                c = clienteDao.ListarClientesCodigo(int.Parse(txtcodigocliente.Text));

                txtcodigocliente.Text = c.codigo.ToString();
                txtnome.Text = c.nome.ToString();

            }
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            qtd = int.Parse(txtquantidade.Text);
            preco = decimal.Parse(txtpreco.Text);

            subtotal = qtd * preco;
            total += subtotal;

            carrinho.Rows.Add(int.Parse(txtcodigoproduto.Text), txtdescricaoproduto.Text, qtd, preco, subtotal);
            txttotal.Text = total.ToString();

            txtcodigoproduto.Clear();
            txtdescricaoproduto.Clear();
            txtquantidade.Clear();
            txtpreco.Clear();

            txtcodigocliente.Focus();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            decimal subproduto = decimal.Parse(tabelaprodutos.CurrentRow.Cells[4].Value.ToString());
            int indice = tabelaprodutos.CurrentRow.Index;
            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subproduto;
            txttotal.Text = total.ToString();
            MessageBox.Show("Produto removido do carrinho com sucesso");
        }
    }
}
