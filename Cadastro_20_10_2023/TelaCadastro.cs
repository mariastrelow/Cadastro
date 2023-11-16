using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cadastro_20_10_2023
{
    public partial class TelaCadastro : Form
    {
        bool transicao;
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelChildForm1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            TelaInicial T = new TelaInicial();
            T.Show();
            this.Hide();
        }

        private void selecionado_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Verificador.ValidaCPF(txbox_cpf.Text) == false)
            {
                MessageBox.Show("CPF invalido");
            }
            else if (Verificador.ValidarEmail(txbox_email.Text) == false)
            {
                MessageBox.Show("E-mail invalido");
            }
            else
            {
                try
                {
                    Funcionario f = new Funcionario();
                    f.Nome = txbox_nome.Text;
                    f.Dt_Nascimento = Convert.ToDateTime(txbox_dn.Text);
                    f.Telefone = Convert.ToInt32(txbox_telefone.Text);
                    f.Email = txbox_email.Text;
                    f.CPF = txbox_cpf.Text;
                    f.RG = txbox_rg.Text;
                    f.Funcao = txbox_funcao.Text;
                    f.Es_Civil = txbox_ec.Text;
                    f.Salario = Convert.ToDouble(txbox_salario.Text);
                    f.Rua = txbox_rua.Text;
                    f.Numero = Convert.ToInt32(txbox_numero.Text);
                    f.Avenida = txbox_avenida.Text;
                    f.Estado = txbox_estado.Text;
                    f.Cidade = txbox_cidade.Text;
                    f.Complemento = txbox_complemento.Text;
                    MessageBox.Show("Cadastrado com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro! Verifique se todos os parametros foram inseridos corretamente.");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
