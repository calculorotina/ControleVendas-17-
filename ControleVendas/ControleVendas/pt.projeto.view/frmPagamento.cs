using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleVendas.pt.projeto.model;
using ControleVendas.pt.projeto.view;
using MySqlX.XDevAPI;
using ControleVendas.pt.projeto.dao;

namespace ControleVendas.pt.projeto.view
{
    public partial class frmPagamento : Form
    {
        clientes cliente = new clientes();
        DataTable carrinho = new DataTable();
        DateTime data;
        decimal dinheiro, cartao, troco;
        public frmPagamento(clientes cliente, DataTable carrinho, DateTime data)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.data = data;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {

        }

        private void btnpagamento_Click(object sender, EventArgs e)
        {
            vendas obj = new vendas();
            frmVendas vendas = new frmVendas();
            obj.cliente_id = int.Parse(vendas.txtcodigocliente.Text);
            obj.data = DateTime.Parse(vendas.txtdata.Text);
            obj.total_venda = Decimal.Parse(vendas.txttotal.Text);
            //obj.observacoes = txtlocalidade.Text;


            vendasDao dao = new vendasDao();
            dao.PagamentoVendas(obj);

            //tabelacliente.DataSource = dao.ListarClientes();

            //falta esta parte

            Itensvendas venda = new Itensvendas();

            //venda.venda_id = int.Parse(carrinho.Columns.Add("subtotal"));
            //venda.produto_id = DateTime.Parse(vendas.txtdata.Text);
            //venda.quantidade = Decimal.Parse(vendas.txttotal.Text);
            //venda.subtotal = Decimal.Parse();

            dao.PagamentoitemVendas(venda);
        }
        //falta esta parte
        private void txtdinheiro_KeyPress(object sender, KeyPressEventArgs e, decimal v, decimal t, decimal tr)
        {

        }

        /*private void txtdinheiro_TextChanged(object sender, EventArgs e, decimal v, decimal t, decimal tr)
        {
            try
            {
                v = decimal.Parse(txtdinheiro.Text);
                t = decimal.Parse(txttotal.Text);
                tr = decimal.Parse(txttroco.Text);
                tr = v - t;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu algo errado, verifique o codigo" + erro);
            }
        }*/
    }
}
