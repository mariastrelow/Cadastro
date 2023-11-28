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
                    em.Telefone = Convert.ToInt32(txbox_telefone.Text);
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

                    em.Rua = txbox_rua.Text;
                    em.Numero = Convert.ToInt32(txbox_numero.Text);
                    em.Avenida = txbox_avenida.Text;
                    em.Estado = txbox_estado.Text;
                    em.Cidade = txbox_cidade.Text;
                    em.Complemento = txbox_complemento.Text;

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
