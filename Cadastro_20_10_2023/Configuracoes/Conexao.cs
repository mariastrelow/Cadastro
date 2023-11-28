using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Cadastro_20_10_2023.Configuracoes
{

    class Conexao
    {
        private string _servidor = "localhost";
        private string _porta = "3306";
        private string _usuario = "root";
        private string _senha = "root";
        private string _bancoDadosNome = "Empresa_X2A";
        private MySqlConnection connection;
        private MySqlCommand command;
        public Conexao()
        {
            try
            {
                connection = new MySqlConnection($"server={_servidor};database={_bancoDadosNome};port={_porta};user={_usuario};password={_senha}");
                connection.Open();
            }

            catch (Exception e)
            {
                throw e;
            }
        }
        public MySqlCommand Comando(string comando)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = comando;
                return command;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}