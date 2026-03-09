namespace Tasca;

public class Tauro : Reproductor
{
    public int RondesQueViu { get; set; } = 0;
    public Tauro(int posiciox,int posicioy,Sexes? sexe) : base(posiciox,posicioy,sexe)
    {
      
    }
    public override void Moviment()
    {
        DireccioX = rnd.Next(3) - 1;
        DireccioY = rnd.Next(3) - 1;

        if (DireccioX == 0 && DireccioY == 0) DireccioX = 1;
       
        PosicioX = (PosicioX + DireccioX + Peixera.CasellesPeixera) % Peixera.CasellesPeixera;
        PosicioY = (PosicioY + DireccioY + Peixera.CasellesPeixera) % Peixera.CasellesPeixera;

        RondesQueViu++;
        
        if (RondesQueViu >= 75)
        {
            Matar();
            Console.WriteLine($"El TAURÓ {_Id} ha mort de vell");
        }

    }
    

    public void CanviarDireccio()
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
                    Console.WriteLine($"Els TAURÓNS {_Id} i {altre._Id} es troben i crien a {nomfill}");
                    return new Tauro(rnd.Next(Peixera.CasellesPeixera), rnd.Next(Peixera.CasellesPeixera), null);
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
        }
        return null;
    }


}