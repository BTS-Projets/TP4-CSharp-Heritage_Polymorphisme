using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_CSharp_Heritage_Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            // on créé un véhicule, un camion et une voiture et on les affiche
            Vehicule veh = new Vehicule("502 HG 80", "Orange", 1800);
            Voiture voit = new Voiture("5507 VG 22", "Noire", 1100, 5);
            Camion cam = new Camion("2541 BH 78", "Bleu", 3500, 6);
            Console.WriteLine("------------------");
            Console.WriteLine(veh);
            Console.WriteLine("------------------");
            Console.WriteLine(voit);
            Console.WriteLine("------------------");
            Console.WriteLine(cam);
            Console.ReadKey();
            //On crée une liste de Vehicule dans laquelle on ajoute les 3 objets précédemment créé
            List<Vehicule> lesVeh = new List<Vehicule>();//collection de véhicules
            lesVeh.Add(veh);
            lesVeh.Add(voit); 
            lesVeh.Add(cam);  
            Console.WriteLine("\n---------Affichage des véhicules--------\n\n"); 
            foreach (Vehicule v in lesVeh)
            {
                v.afficheToi();
                Console.WriteLine("--------------------------");
            }
            Console.Read();

        }
    }
}
