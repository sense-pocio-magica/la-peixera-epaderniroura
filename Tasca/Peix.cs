namespace Tasca;

public class Peix : Reproductor
{
    public Peix(int posiciox,int posicioy,Sexes? sexe) : base(posiciox,posicioy,sexe)
    {
        
    }
    
    
    public override Aquatic? ReaccionarAlXoc(Aquatic altre)
    {
        switch (altre)
        {
            case Peix p when p.Sexe == Sexe:
                Matar();
                altre.Matar();
                Console.WriteLine($"Els PEIXOS {_Id} i {altre._Id} es maten per ser del mateix sexe");
                break;

            case Peix peix:
                var nomfill = _Id + altre._Id;
                var crearPeix = new Peix(posicioxrandom, posicioyrandom, null);
                Console.WriteLine($"Els PEIXOS {_Id} i {altre._Id} es troben i crien a {nomfill}");
                return crearPeix;

                break;

            case Tauro:
                Matar();
                Console.WriteLine($"El PEIX {_Id} es troba amb el TAURÓ {altre._Id} i s'el menja ");
                break;

            default:
                break;
        }
        return null;
    }
    
    
    
    
}