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
using ControleVendas.pt.projeto.view;
using ControleVendas.pt.projeto.view;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ControleVendas.pt.projeto.view
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menucriarproduto_Click(object sender, EventArgs e)
        {
            frmProdutos prod = new frmProdutos();
            prod.ShowDialog();
        }

        private void menucriarcliente_Click(object sender, EventArgs e)
        {
            frmclientes telamenu = new frmclientes();
            telamenu.ShowDialog();
        }

        private void menulistarcliente_Click(object sender, EventArgs e)
        {
            frmclientes telamenu = new frmclientes();
            telamenu.lista.SelectedTab = telamenu.ListaClientes;
            telamenu.ShowDialog();

        }

        private void menucriarfuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarios telafunc = new frmFuncionarios();
            telafunc.ShowDialog();
        }

        private void menulistarfuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarios telafunc = new frmFuncionarios();
            telafunc.listafunc.SelectedTab = telafunc.tablistfunc;
            telafunc.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            menudata.Text = DateTime.Now.ToShortDateString();
            timer1.Start();




            //menuutilizador.Text = log.txtemail.ToString();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            menuhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void menucriarvenda_Click(object sender, EventArgs e)
        {
            frmVendas telavendas = new frmVendas();
            telavendas.ShowDialog();
        }

        private void menucriarfornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedores forn = new frmFornecedores();
            forn.ShowDialog();
        }

        private void menulistarfornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedores forn = new frmFornecedores();
            forn.tabfornecedor1.SelectedTab = forn.tablistaforn;
            forn.ShowDialog();
        }

        private void menulistarproduto_Click(object sender, EventArgs e)
        {
            frmProdutos prod = new frmProdutos();
            prod.tabelaprodutos.SelectedTab = prod.tablistprodutos;
            prod.ShowDialog();
        }
    }
}
