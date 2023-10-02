using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Restaurant restaurant = new Restaurant(); // Creamos un restaurant

            Menu menu1 = new Menu();                   // Creamos 3 menus
            Thread.Sleep(200);                         //  puse un retraso sino me repetia los valores el Random.next()
            Menu menu2 = new Menu();
            Thread.Sleep(200);
            Menu menu3 = new Menu();

            restaurant.MostrarCadaCaloria(menu1);      // El restaurant nos muestra las calorias del menu
            restaurant.MostrarCaloriasTotales(menu1);

            restaurant.MostrarCadaCaloria(menu2); 
            restaurant.MostrarCaloriasTotales(menu2);

            restaurant.MostrarCadaCaloria(menu3); 
            restaurant.MostrarCaloriasTotales(menu3);

            Comensal comensal1 = new Sedentario();  // Creamos los comensales usando diferentes clases
            Comensal comensal2 = new Nomade();
            Comensal comensal3 = new Nosedecide();
            Comensal comensal4 = new Sedentario();
            Comensal comensal5 = new Nomade();

            comensal1.EsCalorico(menu1);           // La funcion esCalorico compara calorias totales con nivel calorico.
            comensal1.Metabolizar(menu1);                                     
            restaurant.PreguntarSiGusto(comensal1); // El Restaurant pregunta al comensal si le gusto el plato.

            comensal2.EsCalorico(menu2);
            comensal2.Metabolizar(menu2);
            restaurant.PreguntarSiGusto(comensal2);

            comensal3.EsCalorico(menu2);
            comensal3.Metabolizar(menu2);
            restaurant.PreguntarSiGusto(comensal3);

            comensal4.EsCalorico(menu3);
            comensal4.Metabolizar(menu3);
            restaurant.PreguntarSiGusto(comensal4);

            comensal5.EsCalorico(menu1);
            comensal5.Metabolizar(menu1);
            restaurant.PreguntarSiGusto(comensal5);

            restaurant.RegistrarPrecioMenu(menu1);  // Guardamos en un txt el precio de cada menu.
            restaurant.RegistrarPrecioMenu(menu2);
            restaurant.RegistrarPrecioMenu(menu3);

            restaurant.RellenarListaCalorias(menu1); // llenamos la lista con las calorias de todos los ingredientes.
            restaurant.RellenarListaCalorias(menu2);
            restaurant.RellenarListaCalorias(menu3);

            restaurant.RegistarListaCalorias();     // finalmente guardamos en un txt la lista de calorias.









        }
    }
}
