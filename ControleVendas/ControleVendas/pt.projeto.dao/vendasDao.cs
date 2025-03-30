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
                conexao.Close();
                


                MessageBox.Show("Venda Criada com sucesso");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }

        }

        public void PagamentoitemVendas(Itensvendas obj)
        {
            try
            {

                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal)
                values(@venda_id, @produto_id, @quantidade, @subtotal)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@cliente_id", obj.venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executacmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);


                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();



                MessageBox.Show("Venda Criada com sucesso");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }

        }
    }
}
