using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal interface IComensal
    {

        public int Metabolizar(Menu menu);

        public string GustaPlato();

        public void EsCalorico(Menu menu);

    }
}
