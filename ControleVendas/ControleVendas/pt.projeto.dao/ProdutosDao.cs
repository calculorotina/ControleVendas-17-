using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
    }
}
