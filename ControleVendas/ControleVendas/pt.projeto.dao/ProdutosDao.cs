using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleVendas.pt.projeto.model;
using MySql.Data.MySqlClient;
using ControleVendas.pt.projeto.dao;
using System.Diagnostics.Metrics;
//using ControleVendas.pt.projeto.view;

namespace ControleVendas.pt.projeto.dao
{
    public class ProdutosDao
    {
        private MySqlConnection conexao;

        public ProdutosDao()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        public class ConnectionFactory
        {
            public MySqlConnection getConnection()
            {
                string connectionString = "Server=localhost;Database=vendas;Uid=root;Pwd=12345;";
                return new MySqlConnection(connectionString);
            }
        }

        public DataTable ListarProdutos()
        {
            DataTable dataproduto = new DataTable();
            try
            {
                string sql = "select * from tb_produtos";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                conexao.Open();
                da.Fill(dataproduto);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na query SQL: " + erro.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            return dataproduto;
        }

        public void apagarProdutos(Produtos obj)
        {
            try
            {
                string sql = "delete from tb_produtos where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto apagado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }
        }

        public void CriarProdutos(Produtos obj)
        {
            try
            {
                
                string sql = @"insert into tb_produtos (descricao, preco, quantidade, familia, for_id)
                values(@descricao, @preco, @quantidade, @familia, @for_id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmd.Parameters.AddWithValue("@familia", obj.familia);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
                ListarProdutos();


                MessageBox.Show("Produto Criado com sucesso");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }

        }

        public void editarProdutos(Produtos obj)
        {
            try
            {
                string sql = @"update tb_produtos set descricao=@descricao, preco=@preco, quantidade=@quantidade, familia=@familia, for_id=@for_id where id=@id";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmd.Parameters.AddWithValue("@familia", obj.familia);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);


                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Produto editado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro na query sql" + erro.Message);
            }
        }

        public DataTable pesquisaProdutos(string descricao)
        {
            DataTable dataproduto = new DataTable();
            try
            {
                string sql = "select * from tb_produtos where descricao like @descricao";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", descricao);


                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(dataproduto);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na query SQL: " + erro.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

            return dataproduto;
        }
    }
}
