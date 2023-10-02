using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Nomade: Comensal
    {
        
            public Nomade()
            {
                this.FactorMetabolico = 1;
                this.NivelCalorico = 2000;
            }
            public override string GustaPlato()
            {
                return "NO";

            }
            public override int Metabolizar(Menu menu)
            {
                int caloriasFinales = menu.TotalCalorias() * FactorMetabolico - 200;
                Console.WriteLine($"Cantidad de calorias a metabolizar son {caloriasFinales}");
                return caloriasFinales;
            }

    }
}
