namespace Tasca;

public class Tortuga : Reproductor
{
    public Tortuga(int posiciox,int posicioy,Sexes? sexe) : base(posiciox,posicioy,sexe)
    {
    }

    public override Aquatic? ReaccionarAlXoc(Aquatic altre)
    {
        switch (altre)
        {
            case Tortuga tortu when tortu.Sexe == Sexe:
                altre.Matar();
                Matar();
                Console.WriteLine($"Les TORTUGUES {_Id} i {altre._Id} es troben a la mateixa casella i es maten");
                
            break;
            
            case Tortuga tortuga:
                var nomfill = _Id + altre._Id;
                var crearTortu = new Tortuga(posicioxrandom, posicioyrandom, null);
                Console.WriteLine($"Les TORTUGUES {_Id} i {altre._Id} es troben i crien a {nomfill}");
                return crearTortu;
            
           default:
                break;
        }
    
        return null;
    }

    public override bool EsInvulnerable() => true;



}