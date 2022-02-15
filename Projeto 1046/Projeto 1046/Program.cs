using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');

            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            int total;
            if (A < B)
            {
                total = B - A;

            }
            else
            {
                total = 24 - A + B;
            }
            Console.WriteLine("O JOGO DUROU " + total + " HORA(S)");

            //Console.ReadLine();
        }
    }

}
