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
        public frmVendas()
        {
            InitializeComponent();
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
    }
}
