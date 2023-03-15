using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coiso_do_ferneko
{
    public class Veiculos
    {
        public int NumeroRodas;
        public int NumeroPortas;
        public string Cor;
        public int NumeroAcentos;
        public bool PagaImposto;

        public string ExibirDados() 
        { return "Numero de portas: " + NumeroPortas + "   Cor: " + Cor; }


    }

    
}
