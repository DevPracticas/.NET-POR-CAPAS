using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogica
{
   

    public class clSumar
    {
        int numero1, numero2;

        public clSumar(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int sumar()
        {
            return numero1 + numero2;
        }
    }
}
