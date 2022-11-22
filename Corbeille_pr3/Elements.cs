using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corbeille_pr3
{
    public class Elements
    {
        // donnée encapsulée
        private int identifiantElem; 
        private string symbole, nom;
        private float masseAtomique;

        //accesseur
        public int IdentifiantElem
        {
            get { return identifiantElem; }
            set { identifiantElem = value; }
        }
        public string Symbole
        {
            get { return symbole; }
            set { symbole = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public float MasseAtomique
        {
            get { return masseAtomique; }
            set { masseAtomique = value; }
        }
        
        public Elements() 
        {
            MasseAtomique = 0.0F;
        }
        public Elements(string symboleE, string nomE, float masseAtomique, int ident)
        {
            Symbole = symboleE;
            Nom = nomE;
            MasseAtomique = masseAtomique;
            IdentifiantElem = ident;
        }
    }
}
