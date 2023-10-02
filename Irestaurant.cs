using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal interface Irestaurant
    {
        public void PreguntarSiGusto(Comensal comensal);
        public void RegistrarPrecioMenu(Menu menu);
        public void RellenarListaCalorias(Menu menu);
        public void RegistarListaCalorias();
        public void MostrarCaloriasTotales(Menu menu);
        public void MostrarCadaCaloria(Menu menu);

        

    }
}
