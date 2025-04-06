using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleVendas.pt.projeto.model;
using MySql.Data.MySqlClient;
//using ControleVendas.pt.projeto.dao;
using System.Diagnostics.Metrics;

namespace ControleVendas.pt.projeto.dao
{
    public class vendasDao
    {
        private MySqlConnection conexao;

        public vendasDao()
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

        public void PagamentoVendas(vendas obj)
        {
            try
            {

                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes)
                values(@cliente_id, @data, @total_venda, @observacoes)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@data", obj.data);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executacmd.Parameters.AddWithValue("@observacoes", obj.observacoes);
                

                conexao.Open();
                executacmd.ExecuteNonQuery();
                
                


                MessageBox.Show("Venda Criada com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }

        }

        public int RetornaId()
        {
            try
            {
                int idvenda = 0;
                string sql = @"select max(id) id from tb_vendas";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {
                    idvenda = reader.GetInt32("id");
                    conexao.Close();

                }
                return idvenda;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro" + erro);
                conexao.Close();
                return 0;
            }

        }
    }
}
