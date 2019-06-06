using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Contador
    {
        int valor = 0;

        public void Incrementar()
        {
            valor += 1;
        }

        public int Valor { get { return valor; }  }
    }
}
