using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage
{
    class Mammifère
    {
        protected string nom;
        protected string lieuHabitation;
        protected string monCrie;
        protected bool jeSuisDomestique;

        public Mammifère(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique)
        {
            this.Nom = nom;
            LieuHabitation = lieuHabitation;
            this.MonCrie = monCrie;
            this.JeSuisDomestique = jeSuisDomestique;
        }

        protected bool JeSuisDomestique { get => jeSuisDomestique; set => jeSuisDomestique = value; }
        protected string MonCrie { get => monCrie; set => monCrie = value; }
        protected string LieuHabitation { get => lieuHabitation; set => lieuHabitation = value; }
        protected string Nom { get => nom; set => nom = value; }

        public bool JeSuisDangereux()
        {
            if(jeSuisDomestique == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Afficher()
        {
            Console.WriteLine("Nom : {0}\nLieu Habitation = {1}\nMon crie = {2}\nSuis-je domestique = {3}", Nom, LieuHabitation, MonCrie, JeSuisDomestique);
            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}
