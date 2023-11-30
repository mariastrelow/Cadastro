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
    public partial class TelaCadastroEmpresa : Form
    {
        public TelaCadastroEmpresa()
        {
            InitializeComponent();
        }

        public void Inserir(Empresa em)
        {
            string nFantasia = em.NFantasia;
            string rSocial = em.RSocial;
            string sCadastral = em.SCadastral;
            string cnpj = em.CNPJ;
            string data = em.DInicio;
            string rTribunal = em.RTribunal;
            string telefone = em.Telefone;
            string cSocial = em.CSocial;
            string tipo = em.Tipo;
            string cpf = em.CPF;
            string pempresa = em.PEmpresa;
            string nproprietario = em.NProprietario;
            string njuridica = em.NJuridica;
            string rua = em.Rua;
            string numero = em.Numero;
            string avenida = em.Avenida;
            string estado = em.Estado;
            string cidade = em.Cidade;
            string complemento = em.Complemento;

            Conexao conexao = new Conexao();

            var comando = conexao.Comando("INSERT INTO Empresa (nomef_emp, rsocial_emp, scadastral_emp, cnpj_emp, dinicio_emp, rtribunal_emp, telefone_emp, csocial_emp, cpf_emp, tipo_emp, nproprietario_emp, pempresa_emp, njuridica_emp, rua_emp, numero_emp, avenida_emp, cidade_emp,complemento_emp ) VALUES " + "(@nomef, @rsocial, @scadastral, @cnpj, @dinicio, @rtribunal, @telefone, @csocial, @cpf, @tipo, @nproprietario, @pempresa, @njuridica, @rua, @numero, @avenida, @cidade, @complemento)");
            comando.Parameters.AddWithValue("@nomef", nFantasia);
            comando.Parameters.AddWithValue("@rsocial", rSocial);
            comando.Parameters.AddWithValue("@scadastral", sCadastral);
            comando.Parameters.AddWithValue("@cnpj", cnpj);
            comando.Parameters.AddWithValue("@dinicio", data);
            comando.Parameters.AddWithValue("@rtribunal", rTribunal);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@csocial", cSocial);
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@nproprietario", nproprietario);
            comando.Parameters.AddWithValue("@pempresa", pempresa);
            comando.Parameters.AddWithValue("@njuridica", njuridica);
            comando.Parameters.AddWithValue("@rua", rua);
            comando.Parameters.AddWithValue("@numero", numero);
            comando.Parameters.AddWithValue("@avenida", avenida);
            comando.Parameters.AddWithValue("@cidade", cidade);
            comando.Parameters.AddWithValue("@complemento", complemento);

            var resultado = comando.ExecuteNonQuery();

            if (resultado > 0)
            {
                MessageBox.Show("Empresa cadastrado com sucesso");
            }

        }
        private void txbox_cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (Verificador.ValidarCNPJ(txbox_cnpj.Text) == false)
            {
                MessageBox.Show("O CNPJ inserido é invalido!");
            }
            if (Verificador.ValidaCPF(txbox_cpf.Text) == false)
            {
                MessageBox.Show("O CPF inserido é invalido!");
            }
            else
            {
                try
                {
                    Empresa em = new Empresa();
                    em.NFantasia = txbox_nf.Text;
                    em.RSocial = txbox_rs.Text;
                    em.SCadastral = txbox_sc.Text;
                    em.CNPJ = txbox_cnpj.Text;
                    em.DInicio = txbox_da.Text;
                    if (rdbox_lp.Checked)
                    {
                        em.RTribunal = "Lucro Presumido";

                    }
                    else if (rdbox_sn.Checked)
                    {
                        em.RTribunal = "Simples Nacional";
                    }
                    else if (rdbox_r.Checked)
                    {
                        em.RTribunal = "Real";
                    }
                    else
                    {
                        em.RTribunal = null;
                    }
                    em.Telefone = txbox_telefone.Text;
                    if (rdbox_Tm.Checked)
                    {
                        em.Tipo = "Matriz";
                    }
                    else if (rdbox_Tf.Checked)
                    {
                        em.Tipo = "Filial";
                    }
                    else
                    {
                        em.Tipo = null;
                    }

                    if (rdbox_PEp.Checked)
                    {
                        em.PEmpresa = "Pequena";
                    }
                    else if (rdbox_Pg.Checked)
                    {
                        em.PEmpresa = "Grande";
                    }
                    else if (rdbox_Pm.Checked)
                    {
                        em.PEmpresa = "Média";
                    }
                    em.NProprietario = txbox_np.Text;
                    em.NJuridica = txbox_nj.Text;
                    em.CSocial = txbox_cs.Text;
                    em.CPF = txbox_cpf.Text;

                    em.Rua = txbox_rua.Text;
                    em.Numero = txbox_numero.Text;
                    em.Avenida = txbox_avenida.Text;
                    em.Estado = txbox_estado.Text;
                    em.Cidade = txbox_cidade.Text;
                    em.Complemento = txbox_complemento.Text;

                    Program.listaEmpresa.Add(em);
                    Inserir(em);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

        }

    }
}


