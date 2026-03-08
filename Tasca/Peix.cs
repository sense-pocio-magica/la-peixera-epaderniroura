namespace Tasca;

public class Peix : Reproductor
{
    public Peix(int posiciox,int posicioy,Sexes? sexe) : base(posiciox,posicioy,sexe)
    {
        DireccioX = rnd.Next(3) - 1;
        DireccioY = rnd.Next(3) - 1;

        if (DireccioX == 0 && DireccioY == 0)
            DireccioX = 1;
    }
    
    public override Aquatic? ReaccionarAlXoc(Aquatic altre)
    {
        if (altre.Vida == true && Vida == true)
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
                        Console.WriteLine($"Els PEIXOS {_Id} i {altre._Id} es troben i crien a {nomfill}");
                        return new Peix(rnd.Next(Peixera.CasellesPeixera), rnd.Next(Peixera.CasellesPeixera), null);
                    
                    break;
                   

                case Tauro:
                    Matar();
                    Console.WriteLine($"El PEIX {_Id} es troba amb el TAURÓ {altre._Id} i s'el menja ");
                    break;

                default:
                    break;
            }
        }

        return null;
    }
    
    
    
    
}