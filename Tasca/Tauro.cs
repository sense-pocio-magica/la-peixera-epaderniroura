namespace Tasca;

public class Tauro : Reproductor
{
    public Tauro(int posiciox,int posicioy,Sexes? sexe) : base(posiciox,posicioy,sexe)
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
                Console.WriteLine($"El Tauró {_Id} es troba amb el PEIX {altre._Id} i el mata");
                break;
            
            case Tauro t when t.Sexe == Sexe:
                Matar();
                altre.Matar();
                Console.WriteLine($"Els TAURÓNS {_Id} i {altre._Id} es maten per ser del mateix sexe");
                break;
            
            case Tauro tauro:
                var nomfill = _Id + altre._Id;
                var crearTauro = new Tauro(posicioxrandom, posicioyrandom, null);
                Console.WriteLine($"Els TAURÓNS {_Id} i {altre._Id} es troben i crien a {nomfill}");
                return crearTauro;
            break;
            
            case Pop:
                altre.Matar();
                Console.WriteLine($"El Tauró {_Id} es troba amb el POP {altre._Id} i el mata");
                break;
            
            case Tortuga:
                CanviarDireccio();
                Console.WriteLine($"El Tauró {_Id} es troba amb la TORTUGA {altre._Id} i canvia de direcció");
                break;
            
            default:
                break;
        }
     
        return null;
    }

    public int CanviarDireccio() //Comprovar si aixó està correcte
    {
        return rnd.Next(Moviment());
    }



}