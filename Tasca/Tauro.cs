namespace Tasca;

public class Tauro : Reproductor
{
    public Tauro(int posiciox,int posicioy,string nom,Sexes? sexe) : base(posiciox,posicioy,nom,sexe)
    {
        
    }
    
    public virtual int Moviment()
    {
        PosicioX += DireccioX;
        PosicioY += DireccioY;

        return 0;
    }
    
    public override Aquatic? ReaccionarAlXoc(Aquatic altre)
    {
        switch (altre)
        {
            case Peix:
                altre.Matar();
                Console.WriteLine($"El Tauró {Nom} es troba amb el PEIX {altre.Nom} i el mata");
                break;
            
            case Tauro t when t.Sexe == Sexe:
                Matar();
                altre.Matar();
                Console.WriteLine($"Els TAURÓNS {Nom} i {altre.Nom} es maten per ser del mateix sexe");
                break;
            
            case Tauro tauro:
                var nomfill = Nom + altre.Nom;
                var crearTauro = new Tauro(posicioxrandom, posicioyrandom, nomfill,null);
                peixera.AfegirAnimalsAlaPeixera(crearTauro);
                Console.WriteLine($"Els TAURÓNS {Nom} i {altre.Nom} es troben i crien a {nomfill}");
                return crearTauro;
            break;
            
            case Pop:
                altre.Matar();
                Console.WriteLine($"El Tauró {Nom} es troba amb el POP {altre.Nom} i el mata");
                break;
            
            case Tortuga:
                CanviarDireccio();
                Console.WriteLine($"El Tauró {Nom} es troba amb la TORTUGA {altre.Nom} i canvia de direcció");
                break;
            
            default:
                break;
        }
            //Treure animals pero revisar
        peixera.Animals = peixera.Animals.Where(m => !m.Matar()).ToList();

        return null;
    }

    public int CanviarDireccio() //Comprovar si aixó està correcte
    {
        return rnd.Next(Moviment());
    }



}