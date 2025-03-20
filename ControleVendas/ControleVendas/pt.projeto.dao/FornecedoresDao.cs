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
    public class FornecedoresDao
    {

        private MySqlConnection conexao;

        public FornecedoresDao()
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

        public DataTable ListarFornecedores()
        {
            DataTable tabelafornecedor = new DataTable();
            try
            {
                string sql = "select * from tb_fornecedores";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                conexao.Open();
                da.Fill(tabelafornecedor);
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

            return tabelafornecedor;
        }

        public void apagarFornecedores(Fornecedores obj)
        {
            try
            {
                string sql = "delete from tb_fornecedores where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor apagado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }
        }

        public void editarFornecedores(Fornecedores obj)
        {
            try
            {
                string sql = @"update tb_fornecedores set nome=@nome, endereco=@morada, cnpj=@cnpj, cep=@cep,
                             email=@email, telefone=@telefone, celular=@telemovel, numero=@numero, estado=@estado, complemento=@complemento, bairro=@bairro, cidade=@cidade where id=@id";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@morada", obj.morada);
                executacmd.Parameters.AddWithValue("@cnpp", obj.cnpj);
                executacmd.Parameters.AddWithValue("@cpf", obj.cp);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@telemovel", obj.telemovel);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);



                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Fornecedor editado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro na query sql" + erro.Message);
            }
        }

        public void CriarFornecedores(Fornecedores obj)
        {
            try
            {
                string sql = @"insert into tb_fornecedores(nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                values(@nome, @cnpj, @email, @telefone, @telemovel, @cep, @Morada, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@telemovel", obj.telemovel);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@Morada", obj.morada);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
                ListarFornecedores();


                MessageBox.Show("Fornecedor Criado com sucesso");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }

        }

    }
}
