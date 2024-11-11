#ifndef TriangleRectangle_h
#define TriangleRectangle_h

#include "FormesGeometriques.h"


class TriangleRectangle : public FormesGeometriques {

 public:

    double CalculerSurface(double Base, double Hauteur);

    double CalculePerimetre(double Base, double Hauteur);
};

#endif // TriangleRectangle_h
