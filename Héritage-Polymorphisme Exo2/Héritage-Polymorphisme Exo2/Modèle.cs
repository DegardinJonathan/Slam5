using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héritage_Polymorphisme_Exo2
{
    class Modèle
    {
        private string nom;
        private double prix;
        protected List<Option> optionsModèle;

        public Modèle(string nom , double prix)
        {
            this.nom = nom;
            this.prix = prix;
            optionsModèle = new List<Option>();
        }
        public double GetPrix
        {
            get
            {
                return prix;
            }
        }
        public void addOption(Option option)
        {
            optionsModèle.Add(option);
        }
        public Option this[int index]
        {
            get
            {
                return this.optionsModèle[index];
            }
        }
        public bool PossèdeOption(string libellé)
        {
            for (int i = 0; i < optionsModèle.Count; i++)
            {
                if (libellé == optionsModèle[i].GetLibelle())
                    return true;
            }
            return false;
        }
        public int Count
        {
            get
            {
                return this.optionsModèle.Count;
            }
        }
        public  virtual string ToString()
        {
            string texte = string.Format("Modèle : {0} GetPrix : {1}", this.nom, this.prix);
            for (int i = 0; i < optionsModèle.Count; i++)
            {
                texte = texte + string.Format("\n{0} {1}" , this.optionsModèle[i].GetLibelle(), this.optionsModèle[i].GetPrix());
            }
            return texte;
        }
    }
}
