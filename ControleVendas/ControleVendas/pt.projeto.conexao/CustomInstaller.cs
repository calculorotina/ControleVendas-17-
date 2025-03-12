using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration.Install;
//using ControleVendas.pt.projeto.conexao;
using System.Drawing.Text;
//using ControleVendas.pt.projeto.dao;
//using ControleVendas.pt.projeto.model;
using System.Web;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Configuration.Provider;


namespace ControleVendas.pt.projeto.conexao
{
    [RunInstaller(true)]
    public class CustomInstaller : Installer
    {
        //public required MySqlConnection conexao;
        //MySqlConnection conn = new MySqlConnection();
        //ConnectionFactory connectionFactory = new ConnectionFactory();
        
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            
            base.Install(stateSaver);
            InstallMySQL();
            
        }

        private void InstallMySQL()
        {
            try
            {
                string installerPath = Path.Combine(Context.Parameters["targetdir"], "mysql-installer-community-8.0.23.0.msi");

                // Executar instalador do MySQL
                Process process = new Process();
                process.StartInfo.FileName = "msiexec.exe";
                process.StartInfo.Arguments = $"/i \"{installerPath}\" /quiet /qn /norestart /log install_mysql.log";
                process.Start();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                throw new InstallException($"Erro ao instalar o MySQL: {ex.Message}");
            }
        }

        private void ConfigureDatabase()
        {
            try
            {
                
                string connectionString = "server=localhost; user ID=root; password=12345;port=3306";
                string scriptPath = Path.Combine(Context.Parameters["targetdir"], "setup.sql");
                string conexao = ConfigurationManager.ConnectionStrings["vendas"].ConnectionString;
                //private string connectionString;
                MySqlConnection conn = new MySqlConnection(connectionString);
                
                    //conn.Open();

                    if (File.Exists(scriptPath))
                    {
                        string script = File.ReadAllText(scriptPath);

                        MySqlCommand cmd = new MySqlCommand(script);
                        
                        cmd.ExecuteNonQuery();
                        
                    }
                    else
                    {
                        throw new InstallException($"Arquivo de script não encontrado: {scriptPath}");
                    }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao configurar o banco de dados: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");

                throw new InstallException($"Erro ao configurar o banco de dados: {ex.Message}");
            }
        }
        
    }
}
