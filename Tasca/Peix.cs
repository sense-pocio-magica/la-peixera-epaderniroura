namespace Tasca;

public class Peix : Reproductor
{
    public Peix(int posiciox,int posicioy,string nom,Sexes? sexe) : base(posiciox,posicioy,nom,sexe)
    {
        
    }
    
    
    public override Aquatic? ReaccionarAlXoc(Aquatic altre)
    {
        switch (altre)
        {
            case Peix p when p.Sexe == Sexe:
                Matar();
                altre.Matar();
                Console.WriteLine($"Els PEIXOS {Nom} i {altre.Nom} es maten per ser del mateix sexe");
                break;
            
            case Peix peix:
                var nomfill = Nom + altre.Nom;
                var crearPeix = new Peix (posicioxrandom, posicioyrandom, nomfill,null);
                peixera.AfegirAnimalsAlaPeixera(crearPeix);
                Console.WriteLine($"Els PEIXOS {Nom} i {altre.Nom} es troben i crien a {nomfill}");
                return crearPeix;
               
                break;  
            
            case Tauro:
                Matar();
                Console.WriteLine($"El PEIX {Nom} es troba amb el TAURÓ {altre.Nom} i s'el menja ");
                break;
            
            default:
                break;
        }
        
        //Treure animals pero revisar
            peixera.Animals = peixera.Animals.Where(m => !m.Matar()).ToList();

            return null;
    }
    
    
    
    
}