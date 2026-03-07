namespace Tasca;

public class Tauro : Reproductor
{
    private int Viu { get; set; } = 75;
    public Tauro(int posiciox,int posicioy,Sexes? sexe) : base(posiciox,posicioy,sexe)
    {
      
    }
    public override void Moviment()
    {
        DireccioX = rnd.Next(3) - 1 % Peixera.CasellesPeixera;
        DireccioY = rnd.Next(3) - 1 % Peixera.CasellesPeixera;

        if (DireccioX == 0 && DireccioY == 0) DireccioX = 1;
        Viu--;

        if (Viu <= 75)
        {
            Vida = false;
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

            Console.WriteLine($"El tauró {_Id} mort de vell");
            Console.WriteLine($"!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

        }

    }
   

    public void CanviarDireccio() //Comprovar si aixó està correcte
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
                    var crearTauro = new Tauro(Peixera.CasellesPeixera, Peixera.CasellesPeixera, null);
                    Console.WriteLine($"Els TAURÓNS {_Id} i {altre._Id} es troben i crien a {nomfill}");
                    return crearTauro;
                    break;

                case Pop:
                    altre.Matar();
                    Console.WriteLine($"El Tauró {_Id} es troba amb el POP {altre._Id} i el mata");
                    Console.WriteLine($".....  {PosicioX} {PosicioY} - {altre.PosicioX}  {altre.PosicioY}......");
                    Console.WriteLine();


                    break;

                case Tortuga:
                    CanviarDireccio();
                    Console.WriteLine($"El Tauró {_Id} es troba amb la TORTUGA {altre._Id} i canvia de direcció");
                    return null;

                default:
                    break;
            }
        }
        return null;
    }


}