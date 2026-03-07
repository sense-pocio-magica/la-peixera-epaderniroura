namespace Tasca;

public class Pop : Aquatic
{
    public Pop(int posiciox, int posicioy) : base(posiciox, posicioy)
    {
        if (rnd.Next(2) == 0)
        {
            DireccioX = rnd.Next(2) == 0 ? -1 : 1;
            DireccioY = 0;
        }
        else
        {
            DireccioY = rnd.Next(2) == 0 ? -1 : 1;
            DireccioX = 0;
        }
    }
    

    public override Aquatic? ReaccionarAlXoc(Aquatic altre)
    {
        if (altre.Vida == true && Vida == true)
        {
            switch (altre)
            {
                case Tauro:
                    Matar();
                    Console.WriteLine($"El POP {_Id} es troba al TAURÓ {altre._Id} i {altre._Id} el mata");
                    break;

                case Pop:
                    altre.Moviment();
                    Moviment();
                    Console.WriteLine($"Els POPS {_Id} i {altre._Id} es troben a la mateixa casella i s'esquiven");
                    break;

                default:
                    break;
            }
        }
        return null;
    }

   

}