using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Menu : Restaurant
    {

        public List<int> ListaIngredientes = new List<int>(); // Lista de ingredientes
        public Menu()
        { 
            Random random = new Random();
            
            for(int i =0; i <5; i++)
            {
                ListaIngredientes.Add(random.Next(200,600));
            }

        }
        public int TotalCalorias()
        {
            int total = 0;

            foreach (var cal in ListaIngredientes)
            {
                total += cal;
            }
            return total;
        }       
    }
}
