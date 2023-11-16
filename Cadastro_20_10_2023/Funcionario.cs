using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_20_10_2023
{
    public class Funcionario
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Funcao { get; set; }
        public string Es_Civil { get; set; }
        public double Salario { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Avenida { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public Funcionario()
        {
        
        }
        public Funcionario(string id, string nome, DateTime dt_Nascimento, int telefone, string email, string rG, string cPF, string funcao, string es_Civil, double salario, string rua, int numero, string avenida, string estado, string cidade, string complemento)
        {
            Id = id;
            Nome = nome;
            Dt_Nascimento = dt_Nascimento;
            Telefone = telefone;
            Email = email;
            RG = rG;
            CPF = cPF;
            Funcao = funcao;
            Es_Civil = es_Civil;
            Salario = salario;
            Rua = rua;
            Numero = numero;
            Avenida = avenida;
            Estado = estado;
            Cidade = cidade;
            Complemento = complemento;
        }
    }
    
}
