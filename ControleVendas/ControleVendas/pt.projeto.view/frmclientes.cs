using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ControleVendas.pt.projeto.model;
using ControleVendas.pt.projeto.dao;

namespace ControleVendas.pt.projeto.view
{
    public partial class frmclientes : Form
    {
        private MySqlConnection conexao;
        public frmclientes()
        {
            InitializeComponent();
        }

        private void cmdgravar_Click(object sender, EventArgs e)
        {
            clientes obj = new clientes();
            obj.nome = txtnome.Text;
            obj.morada = txtmorada.Text;
            obj.cp = txtcp.Text;
            obj.localidade = txtlocalidade.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.telemovel = txttelemovel.Text;
            obj.condpag = txtcpag.Text;
            obj.modopag = txtmodopag.Text;

            ClienteDao dao = new ClienteDao();
            dao.CriarCliente(obj);

            tabelacliente.DataSource = dao.ListarClientes();

        }

        private void frmclientes_Load(object sender, EventArgs e)
        {
            tabelacliente.DefaultCellStyle.ForeColor = Color.Black;

            ClienteDao dao = new ClienteDao();
            tabelacliente.DataSource = dao.ListarClientes();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            clientes obj = new clientes();
            obj.codigo = int.Parse(txtcodigo.Text);
            obj.nome = txtnome.Text;
            obj.morada = txtmorada.Text;
            obj.cp = txtcp.Text;
            obj.localidade = txtlocalidade.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.telemovel = txttelemovel.Text;
            obj.condpag = txtcpag.Text;
            obj.modopag = txtmodopag.Text;

            ClienteDao dao = new ClienteDao();
            dao.editarClientes(obj);

            tabelacliente.DataSource = dao.ListarClientes();
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            clientes obj = new clientes();

            obj.codigo = int.Parse(txtcodigo.Text);


            ClienteDao dao = new ClienteDao();
            dao.apagarClientes(obj);

            tabelacliente.DataSource = dao.ListarClientes();
        }

        private void FichaCliente_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void FichaCliente_Click(object sender, EventArgs e)
        {

        }

        private void tabelacliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelacliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelacliente.CurrentRow.Cells[1].Value.ToString();
            txtmorada.Text = tabelacliente.CurrentRow.Cells[2].Value.ToString();
            txtcp.Text = tabelacliente.CurrentRow.Cells[3].Value.ToString();
            txtlocalidade.Text = tabelacliente.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = tabelacliente.CurrentRow.Cells[5].Value.ToString();
            txttelemovel.Text = tabelacliente.CurrentRow.Cells[6].Value.ToString();
            txtemail.Text = tabelacliente.CurrentRow.Cells[7].Value.ToString();
            txtcpag.Text = tabelacliente.CurrentRow.Cells[8].Value.ToString();
            txtmodopag.Text = tabelacliente.CurrentRow.Cells[9].Value.ToString();

            lista.SelectedTab = FichaCliente;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + textBox1.Text + "%";

            ClienteDao dao = new ClienteDao();

            tabelacliente.DataSource = dao.pesquisarClientes(nome);

            /*if (tabelacliente.Rows.Count == 0)
            {
                tabelacliente.DataSource = dao.ListarClientes();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;

            ClienteDao dao = new ClienteDao();

            tabelacliente.DataSource = dao.pesquisarClientesbotao(nome);

            /*if (tabelacliente.Rows.Count == 0)
            {
                tabelacliente.DataSource = dao.pesquisarClientesbotao(nome);
            }*/
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Models().LimparDados(this);
        }

        private void tabelacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
