using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_CSharp_Heritage_Polymorphisme
{
    class Voiture:Vehicule // hérite de Véhicule
    {
        private int vo_nbpassagers;
        /// <summary>
        /// constructeur paramètré
        /// </summary>
        /// <param name="immat">immatriculation</param>
        /// <param name="couleur">couleur</param>
        /// <param name="poids">poids</param>
        /// <param name="gens">nombre de personnes transportables</param>
        public Voiture(string immat, string couleur, float poids, int gens)
            : base(immat, couleur, poids) // on passe les infos au construteur de la classe mère
        {
            vo_nbpassagers = gens;
            vitesseMaxAutoroute=130;// on y a acces car 
        }

        //redéfinition de toString
        public override string ToString()
        {
            return (base.ToString() + "\nnNombre de passagers : "+ this.vo_nbpassagers);
        }

        public override void afficheToi()
        {
            base.afficheToi();//fait appel à la méthode afficheToi de la classe mère donc Vehicule
            Console.WriteLine("\nJe suis une voiture " + "nombre de passagers: " + this.vo_nbpassagers);
            Console.WriteLine("Vitesse Maxi : " + this.vitesseMaxAutoroute);
        }
    }
}
