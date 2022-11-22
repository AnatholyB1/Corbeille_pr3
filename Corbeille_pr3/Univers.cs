using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Corbeille_pr3
{
    public class Univers
    {
        // donnée privée encapsulée
        private int identifiantUniv;
        private Elements[] tabElement;         // tableau d'éléments
        private int x, y;           // taille max de l'univers
        private String[] coordonee;


        //accesseur 
        public int X
           {
            get { return x; }
            set { x = value; }
           }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Elements[] TabElement
        {
            get { return tabElement; }
            set {  tabElement = value; }
        }
        public int IdentifiantUniv
        {
            get { return identifiantUniv; }
            set { identifiantUniv = value; }
        }

        public String[] Coordonee
        {
            get { return coordonee; }
            set { coordonee = value; }
        }
        public Univers() 
        {
   
            X = 0;
            Y = 0;
        }
        public Univers(int valueX, int valueY, int ident)
        {
            
            X = valueX;
            Y = valueY;
            IdentifiantUniv = ident;
        }
    }
}
