namespace Tasca;

public class Tortuga : Reproductor
{
    public Tortuga(int posiciox,int posicioy,Sexes? sexe) : base(posiciox,posicioy,sexe)
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
                case Tortuga tortu when tortu.Sexe == Sexe:
                    altre.Matar();
                    Matar();
                    Console.WriteLine($"Les TORTUGUES {_Id} i {altre._Id} es troben a la mateixa casella i es maten");

                    break;

                case Tortuga tortuga:
                    var nomfill = _Id + altre._Id;
                    Console.WriteLine($"Les TORTUGUES {_Id} i {altre._Id} es troben i crien a {nomfill}");
                    return new Tortuga(rnd.Next(Peixera.CasellesPeixera), rnd.Next(Peixera.CasellesPeixera), null);
                    break;
                
                default:
                    break;
            }
        }

        return null;
    }

    public override bool EsInvulnerable() => true;



}