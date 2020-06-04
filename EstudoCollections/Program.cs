using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> listaNumeros = new List<int>();
            for (int i = 0; i <= 19; i++)
            {
                listaNumeros.Add(i);
            }
            foreach (int numero in listaNumeros)
            {
                Console.WriteLine("{0}", numero);
            }
            Console.ReadKey();*/
            /*Dictionary<string, string> meuDicionario = new Dictionary<string, string>();
            meuDicionario.Add("Adicionar", "Significa somar");
            meuDicionario.Add("Subtrair", "Significa diminuir");
            foreach(string chave in meuDicionario.Keys)
            {
                Console.WriteLine("{0} significa {1}", chave, meuDicionario[chave]);
            }*/
            Dictionary<int, string> meuDicionario = new Dictionary<int, string>();
            meuDicionario.Add(1, "Numero 1");
            meuDicionario.Add(2, "Numero 2");
            meuDicionario.Add(3, "Numero 3");
            foreach (int chave in meuDicionario.Keys)
            {
                Console.WriteLine("{0} é {1}", chave, meuDicionario[chave]);
            }
            Console.ReadKey();
        }
    }
}
