using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corbeille_pr3
{
    internal class ViewModel
    {
        
        public Univers CreerUnivers(int x, int y, int ident)
        {
            
            Univers objUnivers = new Univers(x,y,ident);

            return objUnivers;
        

        }
        public Elements CreerElements(string nom, string symbole, float mass, int ident)
        {

            Elements objetElement = new Elements(symbole, nom, mass, ident);
            return objetElement;
        }

        public void AjouterElement(Elements elements, Univers univers, String abscisses, String ordonnée, int emplacemnt)
        {
            univers.TabElement = new Elements[10];
            univers.TabElement[emplacemnt] = elements;
            univers.Coordonee = new String[10];
            univers.Coordonee[emplacemnt] = abscisses + "," + ordonnée;
        }
        public void DeplacerEement(Elements elements, Univers univers, String abscisses, String ordonnée)
        {
            for (int i=0; i <= univers.TabElement.Length; i++)
            {
                if (univers.TabElement[i]==elements)
                {
                    univers.Coordonee[i] = abscisses +"," +ordonnée;
                }
            }
        }

        public ViewModel() { }
    }
    
}
