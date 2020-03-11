using System;
using System.Collections.Generic;
using System.Text;

namespace LapinStatic
{
    class Lapin
    {       
            private static int pas;
            private static int comptage;
            private string nom;
            private int age;
            private int position;
            private static Random aléatoire;
            private int dossard;
            



            public static void ChangeStart(int start, int pasChoisis)
            {
                Lapin.comptage = start;
                Lapin.pas = pasChoisis;
            }

            public Lapin(string nom, int age)
            {
                this.nom = nom;
                this.age = age;
                this.position = 0;
                Lapin.aléatoire = new Random();
                this.dossard = Lapin.comptage + Lapin.pas;
            }
            public int Age
            {
                get
                {
                    return this.age;
                }
                set
                {
                    this.age = value;
                }
            }
            public int Pas
            {
                get
                {
                    return Lapin.pas;
                }
                set
                {
                    Lapin.pas = value;
                }
            }
            public int Comptage
            {
                get
                {
                    return Lapin.comptage;
                }
                set
                {
                    Lapin.comptage = value;
                }
            }
            public int Position
            {
                get
                {
                    return this.position;
                }
            }
            public string Nom
            {
                get
                {
                    return nom;
                }
                set
                {
                    this.nom = value;
                }
            }
            /// <summary>
            /// Permet de faire avancer le lapin
            /// </summary>
            public void Avancer()
            {
                int pas = Lapin.aléatoire.Next(0, 6);
                this.position = this.position + pas;
            }
        public void ToString()
        {
            Console.WriteLine("Un lapin du nom de {1} ayant {2} ans et avec un numéro de dossard qui est {3}", nom, age, dossard);
        }
        }
    }




