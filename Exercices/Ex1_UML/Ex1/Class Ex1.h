#ifndef Class Ex1_h
#define Class Ex1_h

class FormesGeom�triques;

class Class Ex1 {

 public:

    void ExecuterLesCalculs(int CodeForme);

    int ChoisirForme();

    void SaisirParametres(int CodeForme);

    int main();

    void AfficherResultats(int CodeFrome);

 public:
    int CodeFormeChoisie;

 public:

    /**
     * @element-type FormesGeom�triques
     */
    FormesGeom�triques *myFormesGeom�triques;
};

#endif // Class Ex1_h
