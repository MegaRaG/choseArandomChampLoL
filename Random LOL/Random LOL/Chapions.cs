using System;
using System.Collections.Generic;
using System.Text;

namespace Random_LOL
{
    public enum CategorieChampion
    {
        Support,
        Assassin,
        Tireur,
        Mage,
        Tank,
        Combattant

    }
    public enum Laner
    {
        Top,
        Mid,
        Jungle,
        Adc,
        Support
    }
    public class Chapions
    {
        private String nom;
        private int numeroChampion;
        private Laner lane;
        private CategorieChampion categorie;

        public Chapions()
        {

        }
        public Chapions(string nom,int numeroChampion, Laner lane, CategorieChampion categorie)
        {
            this.Nom = nom;
            this.NumeroChampion = numeroChampion;
            this.Lane = lane;
            this.Categorie = categorie;
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }

            set
            {
                this.nom = value;
            }
        }

        public Laner Lane
        {
            get
            {
                return this.lane;
            }

            set
            {
                this.lane = value;
            }
        }

        public CategorieChampion Categorie
        {
            get
            {
                return this.categorie;
            }

            set
            {
                this.categorie = value;
            }
        }

        public int NumeroChampion
        {
            get
            {
                return this.numeroChampion;
            }

            set
            {
                this.numeroChampion = value;
            }
        }

        public override string ToString()
        {
            return "Numéro Champion : " + this.NumeroChampion 
                +"\n Nom : " + this.Nom +
                "\n  Laner : " + this.Lane +
                "\n   Categorie : " + this.Categorie;

        }

        public override bool Equals(object obj)
        {
            return obj is Chapions chapions &&
                   this.nom == chapions.nom &&
                   this.numeroChampion == chapions.numeroChampion &&
                   this.lane == chapions.lane &&
                   this.categorie == chapions.categorie;
        }
        public static double RandomTous()
        {
            Random Generateur = new Random();
            double numeroChampionRandom = Generateur.Next(166);
            return numeroChampionRandom;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.nom, this.numeroChampion, this.lane, this.categorie);
        }
    }
}
