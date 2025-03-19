using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using ControleVendas.pt.projeto.model;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using ControleVendas.pt.projeto.dao;
using ControleVendas.pt.projeto.view;

namespace ControleVendas.pt.projeto.dao
{
    
    internal class FuncionariosDao
    {
        private MySqlConnection conexao;

        public FuncionariosDao()
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

        public void CriarFuncionarios(Funcionarios obj)
        {
            try
            {
                string sql = @"insert into tb_funcionarios(nome, rg, cpf, email, senha, cargo, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                values(@nome, @rg, @cpf, @email, @senha, @cargo, @telefone, @telemovel, @cep, @Morada, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@telemovel", obj.telemovel);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@Morada", obj.Morada);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
                ListarFuncionarios();


                MessageBox.Show("Funcionario Criado com sucesso");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }

        }

        public DataTable ListarFuncionarios()
        {
            DataTable tabelafunc = new DataTable();
            try
            {
                string sql = "select * from tb_funcionarios";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                conexao.Open();
                da.Fill(tabelafunc);
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

            return tabelafunc;
        }

        public void apagarFuncionarios(Funcionarios obj)
        {
            try
            {
                string sql = "delete from tb_funcionarios where cpf=@cpf";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario apagado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }
        }

        public void editarFuncionarios(Funcionarios obj)
        {
            try
            {
                string sql = @"update tb_funcionarios set nome=@nome, rg=@rg, cpf=@cpf, email=@email, senha=@senha, cargo=@cargo, nivel_acesso=@nivel_acesso, telefone=@telefone, celular=@telemovel, cep=@cep, endereco=@Morada, 
                              numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado where cpf=@cpf";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@telemovel", obj.telemovel);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@Morada", obj.Morada);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);



                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Funcionario editado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro na query sql" + erro.Message);
            }
        }

        public bool Login(string email, string senha)
        {
            string sql = @"select * from tb_funcionarios where email = @email and senha = @senha";

            MySqlCommand executacmd = new MySqlCommand(sql, conexao);
            executacmd.Parameters.AddWithValue("@email", email);
            executacmd.Parameters.AddWithValue("@senha", senha);

            conexao.Open();

            MySqlDataReader reader = executacmd.ExecuteReader();

            if (reader.Read())
            {
                //string nivel = reader.GetString("nivel");
                string nome = reader.GetString("nome");

                
                MessageBox.Show("Seja bem vindo ao sistema Controle de vendas" + nome);

                Menu telamenu = new Menu();
                telamenu.menuutilizador.Text = nome;

                //frmFuncionarios telamenu = new frmFuncionarios();
                //telamenu.Show();
                frmLogin login = new frmLogin();
                login.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos");
                return false;
            }
        }
    }
}
