using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_CSharp_Heritage_Polymorphisme
{
    internal class Autobus:Vehicule // autobus hérite de véhicule
    {
        private char type;
        /// <summary>
        /// constructeur paramètré
        /// </summary>
        /// <param name="immat">immatriculation</param>
        /// <param name="couleur">couleur</param>
        /// <param name="poids">poids</param>
        /// <param name="type">type de l'autobus (places assises uniquement ou non)</param>
        public Autobus(string immat, string couleur, float poids, char type)
            : base(immat, couleur, poids) // on fait appel au constructeur de la classe mère
        {
            vitesseMaxAutoroute = 80;
            this.type = type;
        }

        //redéfinition (ou surcharge) de toString
        public override string ToString()
        {
            //on affiche le résultat d'affichage de la classe parente + celle de la classeCamion
            return (base.ToString() + "\nType d'Autobus : " + this.type);
        }

        public override void afficheToi()
        {
            base.afficheToi();//fait appel à la méthode afficheToi de la classe mère donc Vehicule
            Console.WriteLine("\nVitesse Maxi : " + this.vitesseMaxAutoroute);
            Console.WriteLine("\nType d'Autobus : " + this.type);
        }
    }
}

