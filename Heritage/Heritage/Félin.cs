using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage
{
    class Félin:Mammifère
    {
        private int nombrePattes;

        public Félin(int nombrePattes,string nom,string lieuHabitation,string monCrie,bool jeSuisDomestique):base(nom,lieuHabitation,monCrie,jeSuisDomestique)
        {
            this.NombrePattes = nombrePattes;
        }

        protected int NombrePattes { get => nombrePattes; set => nombrePattes = value; }
    }
}
