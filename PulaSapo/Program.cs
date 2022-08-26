using System;

namespace PulaSapo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Entre com o número pulos e de canos: ");
            string[] valores = Console.ReadLine().Split(' ');
            int pulos = int.Parse(valores[0]);
            int numeroCanos = int.Parse(valores[1]);
            bool WIN = true;
            Console.Write("Entre com as alturas dos canos : ");
            string[] Cano = Console.ReadLine().Split(' ');
            int[] Canos = new int[numeroCanos];
            
             

            for (int i = 0; i < numeroCanos; i++)
            {
               Canos[i] = int.Parse(Cano[i]);
            }
            for (int i = 0; i< (numeroCanos - 1); i++)
            {
                if ((Canos[i] - Canos[i+1]) < (-pulos))
                {
                    WIN = false;
                }
                else if ((Canos[i]- Canos[i + 1]) > (pulos))
                {
                    WIN = false;
                }
            }
            if (WIN == true)
            {
                Console.WriteLine("YOU WIN");
            }
            else 
            {
                Console.WriteLine("GAME OVER");
            }
           
        }
    }
}
