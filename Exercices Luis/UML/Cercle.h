#ifndef Cercle_h
#define Cercle_h

#include "FormesGeometriques.h"


class Cercle : public FormesGeometriques {

 public:

    double CalculerSurface(double Diametre);

    virtual double CalculerPerimetre(double Diametre);
};

#endif // Cercle_h
