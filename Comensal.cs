using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Comensal : IComensal
    {
        public int FactorMetabolico { get; set; }
        public int NivelCalorico { get; set; }

        public virtual string GustaPlato()
        {
            return "";
        }

        public virtual int Metabolizar(Menu menu)
        {
            return 0;
        }

        public void EsCalorico( Menu menu)
        {

            if(menu.TotalCalorias() >= NivelCalorico)
            {
                Console.WriteLine("Es muy calorico");

            }
            else
            {
                Console.WriteLine("No es tan calorico");
            }
        }
    }
}
