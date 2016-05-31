using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fatoracaounica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero que deseja fatorar");
            int n = Int32.Parse(Console.ReadLine());

            List<int> fatores = Fatoracao.fatorar(n);

            Console.Write("{0} = ", n);

            Console.Write("{0}", fatores[0]);

            int size = fatores.Count;

            for(int i=1;i<size;i++)
            {
                Console.Write(".{0}", fatores[i]);
            }

            Console.WriteLine("");

            Console.WriteLine("Pressione um botao para continuar....");

            Console.ReadKey();
        }
    }
}
