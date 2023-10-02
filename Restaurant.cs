using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Restaurant : Irestaurant
    {
        List<int> ListaCal = new List<int>();



        public void RellenarListaCalorias(Menu menu) 
        {
            foreach (var cal in menu.ListaIngredientes)
            {
                ListaCal.Add(cal);
            }
        }


        public void RegistrarPrecioMenu(Menu menu)
        {
            using (StreamWriter archivo = new StreamWriter("Costo menu.txt", true) )
            {
                archivo.WriteLine($"El costo de este menu es de: ${menu.TotalCalorias()}");
            }

        }

        public void MostrarCadaCaloria(Menu menu)
        {
            foreach (var cal in menu.ListaIngredientes)
            {
                Console.WriteLine($"Este ingrediente tiene {cal} calorias");
            }
        }

        public void MostrarCaloriasTotales(Menu menu)
        {
            int total = 0;

            foreach (var cal in menu.ListaIngredientes)
            {
                total += cal;
            }

            Console.WriteLine($"La cantidad total de calorias de este menu es: {total}\n");
        }

        public void PreguntarSiGusto(Comensal comensal)
        {
            string respuesta = comensal.GustaPlato();
            Console.WriteLine($"Le preguntamos al comensal si le gusto y respondio: {respuesta}\n");
        }

        public void RegistarListaCalorias()
        {
            ListaCal.Sort();

            using (StreamWriter archivo = new StreamWriter("Lista Calorias.txt", false))
            {
                foreach (var cal in ListaCal)
                {
                    archivo.WriteLine(cal);
                }
            }
        }
    }
}
