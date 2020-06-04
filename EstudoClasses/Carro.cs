using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    public class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }
        private List<Dono> antigosDonos;
        public void AdicionarAntigoDono(Dono dono)
        {
            antigosDonos.Add(dono);
        }
        public List<Dono> GetAntigosDonos()
        {
            return antigosDonos;
        }
        public Carro()
        {
            this.antigosDonos = new List<Dono>();
            this.NumeroPortas = 4;
        }
        public Carro(string nomeCarro)
        {
            this.Nome = nomeCarro;
        }
        public Carro(string marcaCarro, int numeroPortas)
        {
            this.Marca = marcaCarro;
            this.NumeroPortas = numeroPortas;
        } 
        public Carro(int numeroPortas)
        {
            this.NumeroPortas = numeroPortas;
        }
        public Carro(string marca, string nome, int quantidadePortas = 4)
        {
            this.Nome = nome;
            this.Marca = marca;
            this.NumeroPortas = quantidadePortas;
        }
        public override string Ligar()
        {
            return "O carro está ligado";
        }

        public override string Desligar()
        {
            return "O carro está desligado";
        }

        public override string Abastecer()
        {
            return "O carro está abastecido";
        }
    }
}
