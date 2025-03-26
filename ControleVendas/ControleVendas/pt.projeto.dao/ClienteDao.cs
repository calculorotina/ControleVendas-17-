using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleVendas.pt.projeto.model;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using ControleVendas.pt.projeto.dao;


namespace ControleVendas.pt.projeto.dao
{
    public class ClienteDao
    {
        private MySqlConnection conexao;
        //clientes c = new clientes();
        //ClienteDao cdao = new ClienteDao();

        public ClienteDao()
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

        public DataTable ListarClientes()
        {
            DataTable tabelacliente = new DataTable();
            try
            {
                string sql = "select * from tb_clientes";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                conexao.Open();
                da.Fill(tabelacliente);
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

            return tabelacliente;
        }

        #region
        public void CriarCliente(clientes obj)
        {
            try
            {
                string sql = @"insert into tb_clientes(nome, morada, cp, localidade, email, telefone, telemovel, Condiçao_Pagamento, Modo_Pagamento)
                values(@nome, @morada, @cp, @localidade, @email, @telefone, @telemovel, @codpag, @modopag)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@morada", obj.morada);
                executacmd.Parameters.AddWithValue("@cp", obj.cp);
                executacmd.Parameters.AddWithValue("@localidade", obj.localidade);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@telemovel", obj.telemovel);
                executacmd.Parameters.AddWithValue("@codpag", obj.condpag);
                executacmd.Parameters.AddWithValue("@modopag", obj.modopag);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close() ;
                ListarClientes();
                

                MessageBox.Show("Cliente Criado com sucesso");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }
            
        }
        #endregion
        public void apagarClientes(clientes obj)
        {
            try
            {
                string sql = "delete from tb_clientes where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                
                MessageBox.Show("Cliente apagado com sucesso");

                conexao.Close();
                
            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }
        }
        public void editarClientes(clientes obj)
        {
            try
            {
                string sql = @"update tb_clientes set nome=@nome, morada=@morada, cp=@cp, localidade=@localidade,
                             email=@email, telefone=@telefone, telemovel=@telemovel, Condiçao_Pagamento=@codpag, Modo_Pagamento=@modopag where id=@id";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@morada", obj.morada);
                executacmd.Parameters.AddWithValue("@cp", obj.cp);
                executacmd.Parameters.AddWithValue("@localidade", obj.localidade);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@telemovel", obj.telemovel);
                executacmd.Parameters.AddWithValue("@codpag", obj.condpag);
                executacmd.Parameters.AddWithValue("@modopag", obj.modopag);



                conexao.Open();
                executacmd.ExecuteNonQuery();
                

                MessageBox.Show("Cliente editado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro na query sql" + erro.Message);
            }
        }

        public DataTable pesquisarClientes(string nome)
        {
            DataTable tabelacliente = new DataTable();
            try
            {
                string sql = "select * from tb_clientes where nome like @nome";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                
                executacmd.Parameters.AddWithValue("@nome", nome);


                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);
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

            return tabelacliente;
        }

        public DataTable pesquisarClientesbotao(string nome)
        {
            DataTable tabelacliente = new DataTable();
            try
            {
                
                string sql = "select * from tb_clientes where nome = @nome";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                
                executacmd.Parameters.AddWithValue("@nome", nome);


                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);
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

            return tabelacliente;
        }

        public clientes ListarClientesCodigo(int id)
        {
            try
            {
                string sql = "select * from tb_clientes where id=@id";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", id);
                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    clientes p = new clientes();
                    p.codigo = rs.GetInt32("id");
                    p.nome = rs.GetString("nome");
                    

                    return p;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao listar os clientes por codigo" + erro);
                return null;
            }


        }

    }
}
