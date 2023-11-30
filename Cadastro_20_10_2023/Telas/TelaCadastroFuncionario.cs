using Cadastro_20_10_2023.Configuracoes;
using Google.Protobuf.WellKnownTypes;
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
    public partial class TelaCadastroFuncionario : Form
    {
        public TelaCadastroFuncionario()
        {
            InitializeComponent();
        }
       
        void Inserir(Funcionario f)
        {
            try
            {
                string nomeFunc = f.Nome;
                string dataNascimento = f.Dt_Nascimento;

                string cpfFunc = f.CPF;
                string rg = f.RG;
                string telefone = f.Telefone;
                string email = f.Email;
                string endereco = f.Rua + f.Avenida + f.Numero + f.Cidade + f.Estado + f.Complemento;
                string estadoCivil = f.Es_Civil;
                string funcao = f.Funcao;
                double salario = f.Salario;

                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO Funcionario (nome_fun, data_nasc_fun, cpf_fun, rg_fun, telefone_fun, email_fun, endereco_fun, estado_civil_fun, funcao_fun, salario_fun) VALUES (@nome, @dataNascimento, @cpf, @rg, @telefone, @email, @endereco, @estadoCivil, @funcao, @salario)");
                comando.Parameters.AddWithValue("@nome", nomeFunc);
                comando.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                comando.Parameters.AddWithValue("@cpf", cpfFunc);
                comando.Parameters.AddWithValue("@rg", rg);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@endereco", endereco);
                comando.Parameters.AddWithValue("@estadoCivil", estadoCivil);
                comando.Parameters.AddWithValue("@funcao", funcao);
                comando.Parameters.AddWithValue("@salario", salario);


                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Funcionario cadastrado com sucesso");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            
            
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
            try
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
                    Funcionario f = new Funcionario();
                    f.Nome = txbox_nome.Text;
                    f.Dt_Nascimento = txbox_dn.Text;
                    f.Telefone = txbox_telefone.Text;
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

                    Program.listaFuncionario.Add(f);
                    Inserir(f);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaInicial t = new TelaInicial();
            t.AbrirFormulario(new TelaCadastroFuncionario());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
