using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoSLO1
{
    class personnage
    {
        //-- déclaration d'attribut 
        //-- private --// 
        private int mVie;

        //-- protect --// 

        //-- public --//  
        public arme choixArme; 

        //-- constructeur --// 
        public personnage(int vie) 
        {
            
        }
        public void choisirArme(e_typeArme typeArme) 
        {
            switch(typeArme)
            {
                case e_typeArme.aBlanche :
                
                    break;

                case e_typeArme.aContondante:

                    break;

                case e_typeArme.aFeu:

                    break;
                
                case e_typeArme.aJet:

                    break;
            }

        }

        public void Attaquer(personnage adversaire) 
        {
            
        }
    }
}
