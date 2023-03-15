using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coiso_do_ferneko
{
    internal class Cliente
    {
        public int Id;
        public string Name;
        public string Telefone;
        private Endereco Endereco;
            
        public Cliente(int id, string name, string telefone, Endereco endereco)
        {
            Id = id;
            Name = name;
            Telefone = telefone;
            Endereco = endereco;
        }

        public int getId()
        {
            return Id; 
        }

        public void setId(int id)
        {
            Id = id;
        }

        public string getName()
        {
            return Name;
        }

        public void setName(string name)
        {
            Name = name;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
        public Endereco getEndereco()
        {
            return Endereco;
        }

        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }
    }
}

    
