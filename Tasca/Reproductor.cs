namespace Tasca;

public enum Sexes
{
    Mascle,
    Femella
};

public abstract class Reproductor : Aquatic
{
    //CONSTRUCTOR
    public Reproductor(int posiciox, int posicioy,Sexes? sexe) : base (posiciox,posicioy)
    {
        if (sexe == null)
        {
            Sexe = (Sexes)SexeAleatori.Next(0,1) == 0 ? Sexes.Femella : Sexes.Mascle;
        }
        else
        {
            Sexe = sexe!;
        }
        
    }
    
    
    private Random SexeAleatori = new Random();
    public Sexes? Sexe { get; set; }
    
    
}