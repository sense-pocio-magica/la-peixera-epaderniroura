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
                break;
            
            case Tauro t when t.Sexe == Sexe:
                Matar();
                altre.Matar();
                break;
            
            case Tauro tauro:
                var nomfill = Nom + altre.Nom;
                var crearTauro = new Tauro(posicioxrandom, posicioyrandom, nomfill,null);
                peixera.AfegirAnimalsAlaPeixera(crearTauro);
                return crearTauro;
            break;
            
            case Pop:
                altre.Matar();
                break;
            
            case Tortuga:
                CanviarDireccio();
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