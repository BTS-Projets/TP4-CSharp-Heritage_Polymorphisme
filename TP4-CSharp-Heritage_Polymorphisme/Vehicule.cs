using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_CSharp_Heritage_Polymorphisme
{
    class Vehicule
    {
        private string v_immat;
        private string v_couleur;
        protected float v_poids;
        protected int vitesseMaxAutoroute;

        public Vehicule(string immat, string couleur, float poids)
        {
            v_immat = immat;
            v_couleur = couleur;
            v_poids = poids;
        }
        public virtual void afficheToi()
        {
            Console.WriteLine("je suis un véhicule d'immat: " + v_immat);
        }

        public override string ToString()
        {
            return "Immatriculation : " + this.v_immat + "\nCouleur : " + this.v_couleur + "\nPoids : " + this.v_poids;
        }
    }
}
