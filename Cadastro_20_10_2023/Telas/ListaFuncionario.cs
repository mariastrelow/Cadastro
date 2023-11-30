using Cadastro_20_10_2023.Configuracoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_20_10_2023
{
    public partial class ListaFuncionario : Form
    {
        
    public ListaFuncionario()
        {
            InitializeComponent();
            Program.listaEmpresa.Clear();
            Consultar();
            foreach(Funcionario str in Program.listaFuncionario)
            {
                dataGridView1.Rows.Add(str.Id, str.Nome, str.Dt_Nascimento, str.Telefone, str.Email, str.RG, str.CPF, str.Funcao, str.Es_Civil, str.Salario);
            }
        }
       
        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM Funcionario");
                var leitor = comando.ExecuteReader();


                while (leitor.Read())
                {
                    Funcionario conexao1 = new Funcionario(leitor.GetString("id_fun"), leitor.GetString("nome_fun"), leitor.GetString("data_nasc_fun"), leitor.GetString("telefone_fun"), leitor.GetString("email_fun"), leitor.GetString("rg_fun"), leitor.GetString("cpf_fun"), leitor.GetString("funcao_fun"), leitor.GetString("estado_civil_fun"), Convert.ToDouble(leitor.GetString("salario_fun")));
                    Program.listaFuncionario.Add(conexao1);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
