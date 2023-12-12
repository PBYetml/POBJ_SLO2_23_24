using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoSLO1
{
    class Program
    {

        //-- attributs 


        //-- méthode 

        //-- "fonction"  
        static void Main(string[] args)
        {
            // type primitif 
            //-- entier --
            bool valB;          // ATTTENTION -> uniquement notion true ou false !!!
                                // taille -> normalement un octet 
            byte valB1;         // valeur non signé 
                                // taille -> 1 octet 
            sbyte valB2;        // valeur signée
            char valC;          // ATTENTION -> uniquement pour de caractère 
                                // taille -> 2 octets 
            short valS;         // ATTENTION -> uniquement pour de nombre entier 2^16 
                                // taille -> 2 octets
            ushort vakS2;       // type non signé 
            int valD;           // taille -> 4 octets
            uint valD1;         // type non signé 
            long valL;          // taille -> 8 octets 
            ulong valL2;        // type non signé 

            // réel 
            float valF;         // taille -> 4 octets         
            double valDo;       // taille -> 8 octets 
            decimal valDe;      // taille -> 16 octets 

            // objet 
            String valSs;

            valC = 'A';
            // valC = 100; -> exemple qui ne fonctionne pas 
            // valS = valC; -> exemple qui ne fonctionne pas 

            valB = true;    // false; 

            //-- afficher un message user --// 
            Console.WriteLine("Hello SLO2");

            //-- récuperation chaine de caratère 
            valSs = Console.ReadLine(); 

            valD = Console.Read();


        }
    }
}
