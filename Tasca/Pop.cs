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
                Console.WriteLine($"El POP {Nom} es troba al TAURÓ {altre.Nom} i {altre.Nom} el mata");
            break;
            
            case Pop:
                altre.Moviment();
                Moviment();
                Console.WriteLine($"Els POPS {Nom} i {altre.Nom} es troben a la mateixa casella i s'esquiven");
                break;
            
            default:
                break;
        }
        
        //Treure animals pero revisar
        peixera.Animals = peixera.Animals.Where(m => !m.Matar()).ToList();

        return null;
    }

}