using System;

namespace DemoCSharp_Console
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //-- variable primitive --// 
            //-- type entier --//
            bool valBool;                       //-- xx octet - information true ou false 
            byte valBye;                        //-- xx octet - par défaut en mode non signé - sbyte -> pour du signé 
            short valShort;                     //-- xx octet - par défaut signé -> ushort -> pour du non signé 
            int valInt;                         //-- xx octet - par défaut signé -> ushort -> pour du non signé 
            long valLong;                       //-- xx octet - par défaut signé -> ushort -> pour du non signé
            
            //-- type caractère --// 
            char valCar;                        //-- xx octet

            //-- type flottant --// 
            float valFlottabt;                  //-- xx ootet -> nombre digit après après la virgule ~ 6
            double valDouble;                   //-- xx octet -> nombre digit après après la virgule ~ 15
            decimal valDecimal;                 //-- xx octet -> nombre digit après après la virgule ~ 28

            //-- chaine de caractère --// 
            string valChaine = "BONJOUR SLO2"; 


            Console.WriteLine("Hello SLO");

            Console.WriteLine("Taille en octet type char :" + sizeof(byte));
            Console.WriteLine("Taille en octet type char :" + sizeof(char));

            valChaine = Console.ReadLine(); 
        }
    }
}
