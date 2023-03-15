using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coiso_do_ferneko
{
    public class Endereco
    {
        private string Rua;
        private string Numero;
        private string CEP;
        private string Bairro;
        private string Cidade;
        private string Estado;


        public Endereco(string rua, string numero, string cep, string bairro, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            CEP = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public void setRua(string rua) 
        { Rua = rua; }

        public string getRua() 
        {  return Rua; }

        public void setNumero(string numero) 
        {  Numero = numero; }

        public string getNumero() 
        {  return Numero; }

        public void setCEP(string cep) 
        { CEP = cep; }

        public string getCEP(string cep) 
        { return CEP; }

        public void setBairro(string bairro) 
        { Bairro = bairro; }

        public string getBairro(string bairro) 
        { return Bairro; }

        public void setCidade(string cidade) 
        { Cidade = cidade; }

        public string getCidade(string cidade) 
        { return Cidade; }

        public void setEstado(string estado)
        { Estado = estado; }

        public string getEstado(string estado) 
        { return Estado; }
    }

    
}
