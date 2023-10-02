using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Sedentario : Comensal
    {
        
        public Sedentario() 
        { 
            this.FactorMetabolico = 3;
            this.NivelCalorico = 1500;


        }

        public override string GustaPlato()
        {
            return "SI";

        }

        public override int Metabolizar(Menu menu)
        {
            int caloriasFinales = menu.TotalCalorias() * FactorMetabolico - 120;
            Console.WriteLine($"Cantidad de calorias a metabolizar son {caloriasFinales}");
            return caloriasFinales;
        }


    }
}
