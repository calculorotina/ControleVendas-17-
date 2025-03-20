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

            tabelafornecedorgrid.DataSource = dao.listarFornecedores();
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            Fornecedores obj = new Fornecedores();

            obj.codigo = int.Parse(txtcodigo.Text);


            FornecedoresDao dao = new FornecedoresDao();
            dao.apagarFornecedores(obj);

            tabelafornecedorgrid.DataSource = dao.ListarFornecedores();
        }
    }
}
