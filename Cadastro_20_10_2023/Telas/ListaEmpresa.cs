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
            foreach (Empresa str in Program.listaEmpresa)
            {
                dataGridView1.Rows.Add(str.Id, str.NFantasia, str.RSocial, str.SCadastral, str.CNPJ, str.DInicio, str.RTribunal, str.Telefone, str.CSocial, str.CPF, str.Tipo, str.NProprietario, str.PEmpresa, str.NJuridica, str.Rua, str.Numero, str.Avenida, str.Estado, str.Cidade, str.Complemento);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
