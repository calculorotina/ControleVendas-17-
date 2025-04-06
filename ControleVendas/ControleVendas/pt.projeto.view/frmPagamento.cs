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
using MySql.Data.MySqlClient;

namespace ControleVendas.pt.projeto.view
{
    public partial class frmPagamento : Form
    {
        private MySqlConnection conexao;

        clientes cliente = new clientes();
        DataTable carrinho = new DataTable();
        DateTime data;
        //decimal c, t, tr;

        public class ConnectionFactory
        {
            public MySqlConnection getConnection()
            {
                string connectionString = "Server=localhost;Database=vendas;Uid=root;Pwd=12345;";
                return new MySqlConnection(connectionString);
            }
        }

        public frmPagamento(clientes cliente, DataTable carrinho, DateTime data)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.data = data;
            this.conexao = new ConnectionFactory().getConnection();
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            txttroco.Text = "0,00";
            txtdinheiro.Text = "0,00";
            txtcartao.Text = "0,00";
        }

        private void btnpagamento_Click(object sender, EventArgs e)
        {
            try
            {
                decimal d, c, troco, totalpago, total;

                d = decimal.Parse(txtdinheiro.Text);
                c = decimal.Parse(txtcartao.Text);
                total = decimal.Parse(txttotal.Text);

                totalpago = d + c;

                if (totalpago <= total)
                {
                    MessageBox.Show("O total pago é menor que o total de venda");
                } else
                {
                    troco = totalpago - total;
                    vendas venda = new vendas();

                    venda.cliente_id = cliente.id;
                    venda.data = data;
                    venda.total_venda = total;
                    venda.observacoes = txtobservacoes.Text;

                    vendasDao vd = new vendasDao();
                    txttroco.Text = troco.ToString();

                    vd.PagamentoVendas(venda);
                }

                

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        //falta esta parte
        private void txtdinheiro_KeyPress(object sender, KeyPressEventArgs e, decimal v, decimal t, decimal tr)
        {

        }

        private void txtdinheiro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtdinheiro_KeyUp(object sender, KeyEventArgs e)
        {
            
        }


    }
}
