using System;
using System.Collections.Generic;
using System.Text;

namespace PulaSapo
{
    class Pulo
    {
        public int Pulos { get; set; }
        public int NumeroCanos { get; set; }
       

        public Pulo(int pulos, int numeroCanos)
        {
            Pulos = pulos;
            NumeroCanos = numeroCanos;
            
        }
        public string Sapo()
        {
            
            if (NumeroCanos > Pulos)
            {
                return "YOU WIN";
            }
            else
            {
                return"GAME OVER!!!";
            }
        }
    }
}
