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
            
        }
    }
}
