using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Marca = "Fiat";
            Dono donoJoao = new Dono();
            donoJoao.Nome = "João da Silva";
            donoJoao.Idade = 20;
            carro.AdicionarAntigoDono(donoJoao);
            Dono donoMaria = new Dono();
            donoMaria.Nome = "Maria da Silva";
            donoMaria.Idade = 28;
            carro.AdicionarAntigoDono(donoMaria);
            foreach (Dono dono in carro.GetAntigosDonos())
            {
                Console.WriteLine("Um dos antigos donos é: {0} de idade: {1}", dono.Nome, dono.Idade);
            }
            Console.WriteLine(carro.Ligar());
            //Poliimorfismo
            Veiculo meuCarro = new Carro();
            Veiculo minhaMoto = new Moto();
            Console.ReadKey();

        }
    }
}
