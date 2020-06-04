using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    public sealed class Moto : Veiculo
    {
        public double CapacidadeTanque { get; set; }
        public override string Ligar()
        {
            return "A moto está ligada";
        }
        public override string Desligar()
        {
            return "A moto está desligada";
        }

        public override string Abastecer()
        {
            return "A moto está abastecida";
        }
    }
}
