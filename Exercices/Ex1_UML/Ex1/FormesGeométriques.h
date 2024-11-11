#ifndef FormesGeom�triques_h
#define FormesGeom�triques_h

#include "Cercle.h"
#include "Rectangle.h"
#include "TriangleRectangle.h"


class FormesGeom�triques : public TriangleRectangle, public Rectangle, public Cercle, public TriangleRectangle, public Rectangle, public Cercle {

 public:

    virtual double CalculerSurface(double x1, double x2);

    virtual double CalculerPerimetre(double x1, double x2);

    double GetSurface();

    double GetPerimetre();

 public:
    double Perimetre;

 private:
    double Surface;

};

#endif // FormesGeom�triques_h
