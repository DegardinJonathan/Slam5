using System;
using System.Collections.Generic;
using System.Text;

namespace Exo_3_héritage
{
    class Camion:Vehicule
    {
        protected int essieux;
        protected bool semiRemorque;

        public Camion(string immatriculation,int annéeConstruction,string marque,string modele,int essieux, bool semiRemorque) :base(immatriculation,annéeConstruction,marque,modele)
        {
            this.essieux = essieux;
            this.semiRemorque = semiRemorque;
        }
        public void Afficher()
        {
            
            string semi;
            
            
            if (semiRemorque == false)
            {
                semi = "Camion";
            }
            else
            {
                semi = "Semi Remorque";
            }
            Console.WriteLine(semi + "avec {0} essieux",essieux);
            base.ToString();
        }
    }
}
