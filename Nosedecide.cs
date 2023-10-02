using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Nosedecide : Comensal
    {
        public Nosedecide()
        {
            this.FactorMetabolico = 2;
            this.NivelCalorico = 1750;

        }
        public override string GustaPlato()
        {
            return "No sabe";

        }
        public override int Metabolizar(Menu menu)
        {
            int caloriasFinales = menu.TotalCalorias() * FactorMetabolico - 150;
            Console.WriteLine($"Cantidad de calorias a metabolizar son {caloriasFinales}");
            return caloriasFinales;
        }
    }
}
