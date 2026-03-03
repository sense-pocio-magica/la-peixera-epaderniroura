namespace Tasca;

public enum Sexes
{
    Mascle,
    Femella
};

public abstract class Reproductor : Aquatic
{
    //CONSTRUCTOR
    public Reproductor(string nom) : base (nom)
    {
        Sexe = (Sexes)SexeAleatori.Next(0,1);
    }
    
    //VALORS
    private Random SexeAleatori = new Random();
    public Sexes Sexe { get; set; }
    
   //MÈTODES
    
    public virtual void Moviment()
    {
        PosicioX += DireccioX;
        PosicioY += DireccioY;
    }

    public abstract void Criar();

    public abstract void MatarMateixSexe();

}