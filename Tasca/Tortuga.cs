namespace Tasca;

public class Tortuga : Reproductor
{
    public Tortuga(int posiciox,int posicioy,string nom,Sexes? sexe) : base(posiciox,posicioy,nom,sexe)
    {
    }

    public override Aquatic? ReaccionarAlXoc(Aquatic altre)
    {
        switch (altre)
        {
            case Tortuga tortu when tortu.Sexe == Sexe:
                altre.Matar();
                Matar();
                Console.WriteLine($"Les TORTUGUES {Nom} i {altre.Nom} es troben a la mateixa casella i es maten");
                
            break;
            
            case Tortuga tortuga:
                string nomfill = Nom + altre.Nom;
                var crearTortu = new Tortuga(posicioxrandom, posicioyrandom, nomfill,null);
                peixera.AfegirAnimalsAlaPeixera(crearTortu);
                Console.WriteLine($"Les TORTUGUES {Nom} i {altre.Nom} es troben i crien a {nomfill}");
                return crearTortu;
            
           default:
                break;
        }
        
        //Treure animals pero revisar
        peixera.Animals = peixera.Animals.Where(m => !m.Matar()).ToList();

        return null;
    }

    public override bool EsInvulnerable() => true;



}