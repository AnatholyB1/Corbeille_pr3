// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Corbeille_pr3
{
    class Program
    {
        static void Main()
        {


            int maxsize = 400; //taille max de l'univers
           
            
            ViewModel objView = new ViewModel(); // création d'un objet de vue


            Univers[] tableauUnivers  ; //tableau d'univers


            // creation d'element

            void ajouterElements(Univers univers )
            {
                Console.WriteLine("voulez vous ajouter le carbone ");
                int i = 0;
                if (Console.ReadLine()=="oui")
                {
                    Console.WriteLine("ajouter l'abscisse");
                    String abscisse = Console.ReadLine();
                    Console.WriteLine("ajouter l'ordonnée");
                    String ordonee = Console.ReadLine();
                    Elements element = objView.CreerElements("Carbone", "C", 12.01074F, i);
                    objView.AjouterElement(element, univers, abscisse, ordonee, i);
                    i++;
                    Console.WriteLine("Element ajouté");
                }
                Console.WriteLine("voulez vous ajouter l'hydrogene ");
        
                if (Console.ReadLine() == "oui")
                {
                    Console.WriteLine("ajouter l'abscisse");
                    String abscisse = Console.ReadLine();
                    Console.WriteLine("ajouter l'ordonnée");
                    String ordonee = Console.ReadLine();
                    Elements element = objView.CreerElements("Hydrogene", "H", 1.00794F, i);
                    objView.AjouterElement(element, univers, abscisse, ordonee, i);
                    i++;
                    Console.WriteLine("Element ajouté");
                }
                Console.WriteLine("voulez vous ajouter le Lithium ");
                
                if (Console.ReadLine() == "oui")
                {
                    Console.WriteLine("ajouter l'abscisse");
                    String abscisse = Console.ReadLine();
                    Console.WriteLine("ajouter l'ordonnée");
                    String ordonee = Console.ReadLine();
                    Elements element = objView.CreerElements("Lithium", "Li", 6.941F, i);
                    objView.AjouterElement(element, univers, abscisse, ordonee, i);
                    i++;
                    Console.WriteLine("Element ajouté");
                }

            }
            
        

            // partie création d'univers
            while(true)
            {
                Console.WriteLine("Combien d'univers voulez vous");
                String nomUnivers = Console.ReadLine();
                if (nomUnivers == "1")
                {
                    Univers objUnivers1 = objView.CreerUnivers(maxsize, maxsize, 0);
                    Console.WriteLine("un univers créé");
                    ajouterElements(objUnivers1);
                    for (int i = 0; i < objUnivers1.TabElement.Length; i++)
                    {
                        Console.WriteLine(objUnivers1.Coordonee[i]);
                    }
                }
                else
                {
                    tableauUnivers = new Univers[Int16.Parse(nomUnivers)];
                    for (int i = 0; i < tableauUnivers.Length; i++)
                    {
                        Univers ObjUnivers = objView.CreerUnivers(maxsize, maxsize, i);
                        Console.WriteLine("un univers créé");
                        tableauUnivers[i] = ObjUnivers;
                    }
                    //partie création d'elements
                    Console.WriteLine("Dans quel monde voulez vous créer les éléments ?");
                    String reponse = Console.ReadLine();
                    ajouterElements(tableauUnivers[Int16.Parse(reponse) - 1]);
                    for (int i = 0; i< tableauUnivers[Int16.Parse(reponse) - 1].Coordonee.Length;i++)
                    {
                            Console.WriteLine(tableauUnivers[Int16.Parse(reponse) - 1].Coordonee[i]);
                            
                    }
                
     

                }
                
                
            }

        }
    }
}