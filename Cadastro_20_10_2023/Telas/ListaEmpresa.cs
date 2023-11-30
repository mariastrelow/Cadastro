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
    public partial class ListaEmpresa : Form
    {
        public ListaEmpresa()
        {
            InitializeComponent();
            Program.listaEmpresa.Clear();
            Consultar();
            foreach (Empresa str in Program.listaEmpresa)
            {
                dataGridView1.Rows.Add(str.Id, str.NFantasia, str.RSocial, str.SCadastral, str.CNPJ, str.DInicio, str.RTribunal, str.Telefone, str.CSocial, str.CPF, str.Tipo, str.NProprietario, str.PEmpresa, str.NJuridica, str.Rua, str.Numero, str.Avenida, str.Estado, str.Cidade, str.Complemento);
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
                    Empresa conexao1 = new Empresa(leitor.GetString("id_emp"), leitor.GetString("nomef_emp"), leitor.GetString("rsocial_emp"), leitor.GetString("scadastral_emp"), leitor.GetString("cnpj_emp"), leitor.GetString("dinicio_emp"), leitor.GetString("rtribunal_emp"), leitor.GetString("telefone_emp"), leitor.GetString("csocial_emp"), Convert.ToString(leitor.GetString("cpf_emp")), leitor.GetString("tipo_emp"), leitor.GetString("nproprietario_emp"), leitor.GetString("pempresa_emp"), leitor.GetString("njuridica_emp"), leitor.GetString("rua_emp"), leitor.GetString("numero_emp"), leitor.GetString("avenida_emp"), leitor.GetString("estado_emp"), leitor.GetString("cidade_emp"), leitor.GetString("complemento_emp"));
                    Program.listaEmpresa.Add(conexao1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            TelaInicial t = new TelaInicial();
            t.AbrirFormulario(new TelaCadastroEmpresa());
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
