using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meuVeto = new int[10];
            for (int i =0;i<= 9; i++)
            {
                meuVeto[i] = i + 1;
            }
            /*for(int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Posição {0} = {1}", i, meuVeto[i]);
            }*/
            foreach (int numero in meuVeto)
            {
                Console.WriteLine("Posição {0} ", numero);
            }
            Console.WriteLine("O tamanho do vetor é {0}", meuVeto.Length);
            Console.ReadKey();
        }
    }
}
