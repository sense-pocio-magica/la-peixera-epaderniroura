namespace Tasca;

public class Peix : Reproductor
{
    public Peix(string nom) : base(nom)
    {
    }
    
    public virtual void Moviment()
    {
        PosicioX += DireccioX;
        PosicioY += DireccioY;
    }
    
    public override void Criar(Peix peix)
    {
        var nomfill = Nom + peix.Nom;
        if (Sexe == Sexes.Femella && peix.Sexe == Sexes.Mascle)
        {
            new Peix(nomfill);
        }
        
        else if (Sexe == Sexes.Mascle && peix.Sexe == Sexes.Femella)
        {
            new Peix(nomfill);

        }
    }

    public override void MatarMateixSexe(Peix peix)
    {
        if (Sexe == Sexes.Femella && peix.Sexe == Sexes.Femella)
        {
            Vida = false;
            peix.Vida = false;
            Console.WriteLine($"{Nom} i {peix.Nom} es troben i es moren els 2");
        }
        else if (Sexe == Sexes.Mascle && peix.Sexe == Sexes.Mascle)
        {
            Vida = false;
            peix.Vida = false;
            Console.WriteLine($"{Nom} i {peix.Nom} es troben i es moren els 2");
        }
    }

}