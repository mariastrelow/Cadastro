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
            foreach(Funcionario str in Program.listaFuncionario)
            {
                dataGridView1.Rows.Add(str.Id, str.Nome, str.Dt_Nascimento, str.Telefone, str.Email, str.RG, str.CPF, str.Funcao, str.Es_Civil, str.Salario, str.Rua, str.Numero, str.Avenida, str.Estado, str.Cidade, str.Complemento);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TelaCadastro tela = new TelaCadastro();
            dataGridView1.Rows.Add(tela.listaFuncionario);
        }
    }
}
