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
using MySql.Data.MySqlClient;



namespace ControleVendas.pt.projeto.view
{
    public partial class frmFuncionarios : Form
    {
        private MySqlConnection conexao;
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void cmdgravar_Click(object sender, EventArgs e)
        {

            Funcionarios obj = new Funcionarios();
            obj.nome = txtnomefunc.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemailfunc.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = txtcargo.Text;
            obj.nivel_acesso = txtacesso.Text;
            obj.telefone = txttelfunc.Text;
            obj.telemovel = txttlmfunc.Text;
            obj.cep = txtcep.Text;
            obj.Morada = txtmorfunc.Text;
            obj.numero = txtnumero.Text;
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtestado.Text;

            FuncionariosDao dao = new FuncionariosDao();
            dao.CriarFuncionarios(obj);

            tabelafunc.DataSource = dao.ListarFuncionarios();

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {

            tabelafunc.DefaultCellStyle.ForeColor = Color.Black;

            FuncionariosDao dao = new FuncionariosDao();
            tabelafunc.DataSource = dao.ListarFuncionarios();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            Funcionarios obj = new Funcionarios();

            
            obj.nome = txtnomefunc.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemailfunc.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = txtcargo.Text;
            obj.nivel_acesso = txtacesso.Text;
            obj.telefone = txttelfunc.Text;
            obj.telemovel = txttlmfunc.Text;
            obj.cep = txtcep.Text;
            obj.Morada = txtmorfunc.Text;
            obj.numero = txtnumero.Text;
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtestado.Text;

            FuncionariosDao dao = new FuncionariosDao();
            dao.editarFuncionarios(obj);

            tabelafunc.DataSource = dao.ListarFuncionarios();
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            Funcionarios obj = new Funcionarios();

            obj.cpf = txtcpf.Text;


            FuncionariosDao dao = new FuncionariosDao();
            dao.apagarFuncionarios(obj);

            tabelafunc.DataSource = dao.ListarFuncionarios();
        }

        private void tabelafunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtnomefunc.Text = tabelafunc.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelafunc.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelafunc.CurrentRow.Cells[3].Value.ToString();
            txtemailfunc.Text = tabelafunc.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = tabelafunc.CurrentRow.Cells[5].Value.ToString();
            txtcargo.Text = tabelafunc.CurrentRow.Cells[6].Value.ToString();
            txtacesso.Text = tabelafunc.CurrentRow.Cells[7].Value.ToString();
            txttelfunc.Text = tabelafunc.CurrentRow.Cells[8].Value.ToString();
            txttlmfunc.Text = tabelafunc.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = tabelafunc.CurrentRow.Cells[10].Value.ToString();
            txtmorfunc.Text = tabelafunc.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = tabelafunc.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = tabelafunc.CurrentRow.Cells[11].Value.ToString();
            txtbairro.Text = tabelafunc.CurrentRow.Cells[13].Value.ToString();
            txtcidade.Text = tabelafunc.CurrentRow.Cells[14].Value.ToString();
            txtestado.Text = tabelafunc.CurrentRow.Cells[15].Value.ToString();

            listafunc.SelectedTab = tabfunc;
        }

        private void tabelafunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabfunc_Click(object sender, EventArgs e)
        {

        }
    }
}


