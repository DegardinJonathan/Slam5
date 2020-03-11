using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage
{
    class Lion:Félin
    {
        public Lion(int nombrePattes,string nom,string lieuHabitation,string monCrie,bool jeSuisDomestique) : base(nombrePattes, nom, lieuHabitation, monCrie, jeSuisDomestique)
        {
            
        }
        public void Afficher()
        {
            Console.WriteLine("Nom : {0}\nLieu Habitation = {1}\nMon crie = {2}\nSuis-je domestique = {3}", base.Nom, base.lieuHabitation, base.MonCrie, base.JeSuisDomestique);
            Console.WriteLine("-------------------------------------------------------------");
        }

    }
}
