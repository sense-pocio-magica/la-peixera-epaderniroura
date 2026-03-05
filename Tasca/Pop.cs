namespace Tasca;

public class Pop : Aquatic
{
    public Pop(int posiciox, int posicioy,string nom) : base(posiciox,posicioy,nom)
    {
        
    }
    
    public override Aquatic? ReaccionarAlXoc(Aquatic altre)
    {
        switch (altre)
        {
            case Tauro:
                Matar();
            break;
            
            case Pop:
                altre.Moviment();
                Moviment();
                break;
            
            default:
                break;
        }
        
        //Treure animals pero revisar
        peixera.Animals = peixera.Animals.Where(m => !m.Matar()).ToList();

        return null;
    }

}