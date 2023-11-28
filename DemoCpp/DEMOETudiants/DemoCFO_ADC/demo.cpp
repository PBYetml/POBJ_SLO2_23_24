#include "demo.h"
#include <iostream>		//"<>" car librairie standard (pas créé par l'utilisateur)
#include <cstdint>		//lib types normalisés c++ (types entiers) exemples: bool,char,short,int,long
						//Types primitifs flottants: double,float, 
#include <string>		//Pour utiliser les string

void main()
{
	uint8_t clavier;
	std::string chaineCaractere = "Bonjour Cyril";		//Dans mémoire figée
	std::string *chaineCaractere2 = new std::string("Coucou Cyril");	//Dans mémoire dynamique
	
	std::cout << "Salut Cyril\n" << std::endl;	//Flux de sortie
	std::cin >> clavier;	//Flux d'entrée
	std::cout << "Taille variable = " << sizeof (clavier) << "Valeur clavier = " << clavier << std::endl;	//Flux de sortie
	std::cout << "Taille bool = " << sizeof (bool) << std::endl;	//Flux de sortie
}