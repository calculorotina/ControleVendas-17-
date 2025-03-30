using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ControleVendas.pt.projeto.conexao;

namespace ControleVendas.pt.projeto.conection
{
    public class MySqlConnection
    {

        string conexao = ConfigurationManager.ConnectionStrings["vendas"].ConnectionString;
        private string connectionString;

        public MySqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //return new MySqlConnection(conexao);

    }
}
