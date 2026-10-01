using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_CSharp_Heritage_Polymorphisme
{
    class Camion:Vehicule // camion hérite de véhicule
    {
        private int nbRoues;
        /// <summary>
        /// constructeur paramètré
        /// </summary>
        /// <param name="immat">immatriculation</param>
        /// <param name="couleur">couleur</param>
        /// <param name="poids">poids</param>
        /// <param name="roues">nombre de roues</param>
        public Camion(string immat, string couleur, float poids, int roues)
            : base(immat, couleur, poids) // on fait appel au constructeur de la classe mère
        {
            vitesseMaxAutoroute=90;
            this.nbRoues = roues;
        }

        //redéfinition (ou surcharge) de toString
        public override string ToString()
        {
            //on affiche le résultat d'affichage de la classe parente + celle de la classeCamion
            return (base.ToString() +"\nNombre de roues : "+ this.nbRoues);
        }

        public override void afficheToi()
        {
            base.afficheToi();//fait appel à la méthode afficheToi de la classe mère donc Vehicule
            Console.WriteLine("\nJe suis un camion " + "nombre de roues : " + this.nbRoues);
            Console.WriteLine("\nVitesse Maxi : "+this.vitesseMaxAutoroute);
        }
    }
}
