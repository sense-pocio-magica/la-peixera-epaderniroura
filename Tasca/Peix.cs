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
                break;
            
            case Peix peix:
                var nomfill = Nom + altre.Nom;
                var crearPeix = new Peix (posicioxrandom, posicioyrandom, nomfill,null);
                peixera.AfegirAnimalsAlaPeixera(crearPeix);
                return crearPeix;
               
                break;  
            
            case Tauro:
                Matar();
                break;
            
            default:
                break;
        }
        
        //Treure animals pero revisar
            peixera.Animals = peixera.Animals.Where(m => !m.Matar()).ToList();

            return null;
    }
    
    
    
    
}