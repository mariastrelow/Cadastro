﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_20_10_2023
{
    public class Empresa
    {
        public string Id { get; set; }
        public string NFantasia { get; set; }
        public string RSocial { get; set; }
        public string SCadastral { get; set; }
        public string CNPJ { get; set; }
        public  string DInicio { get; set; }
        public string RTribunal { get; set; }
        public string Telefone { get; set; }
        public string CSocial { get; set; }
        public string CPF { get; set; }
        public string Tipo { get; set; }
        public string NProprietario { get; set; }
        public string PEmpresa { get; set; }
        public string NJuridica { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Avenida { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }

        public Empresa()
        {

        }
        public Empresa(string id, string nFantasia, string rSocial, string sCadastral, string cNPJ, string dInicio, string rTribunal, string telefone, string cSocial, string cPF, string tipo, string nProprietario, string pEmpresa, string nJuridica, string rua, string numero, string avenida, string estado, string cidade, string complemento)
        {
            Id = id;
            NFantasia = nFantasia;
            RSocial = rSocial;
            SCadastral = sCadastral;
            CNPJ = cNPJ;
            DInicio = dInicio;
            RTribunal = rTribunal;
            Telefone = telefone;
            CSocial = cSocial;
            CPF = cPF;
            Tipo = tipo;
            NProprietario = nProprietario;
            PEmpresa = pEmpresa;
            NJuridica = nJuridica;
            Rua = rua;
            Numero = numero;
            Avenida = avenida;
            Estado = estado;
            Cidade = cidade;
            Complemento = complemento;
        }
    }
}
