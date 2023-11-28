#ifndef FormesGeometriques_h
#define FormesGeometriques_h


class FormesGeometriques {

 public:

    double GetSurface();

    double GetPerimetre();

    virtual double CalculerSurface(double x1, double x2);

    virtual double CalculerPerimetre(double x1, double x2);

 public:
    double Surface;
    double Perimetre;

};

#endif // FormesGeometriques_h
