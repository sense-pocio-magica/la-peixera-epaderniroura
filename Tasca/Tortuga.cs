namespace Tasca;

public class Tortuga : Reproductor
{
    public Tortuga(string nom) : base(nom)
    {
    }
    
    public virtual void Moviment()
    {
        PosicioX += DireccioX;
        PosicioY += DireccioY;
    }
    
    public override void Criar(Tortuga tortuga)
    {
        var nomfill = Nom + tortuga.Nom;
        if (Sexe == Sexes.Femella && tortuga.Sexe == Sexes.Mascle)
        {
            new Tortuga(nomfill);
        }
        
        else if (Sexe == Sexes.Mascle && tortuga.Sexe == Sexes.Femella)
        {
            new Tortuga(nomfill);

        }
    }

    public override void MatarMateixSexe(Tortuga tortuga)
    {
        if (Sexe == Sexes.Femella && tortuga.Sexe == Sexes.Femella)
        {
            Vida = false;
            tortuga.Vida = false;
            Console.WriteLine($"{Nom} i {tortuga.Nom} es troben i es moren els 2");
        }
        else if (Sexe == Sexes.Mascle && tortuga.Sexe == Sexes.Mascle)
        {
            Vida = false;
            tortuga.Vida = false;
            Console.WriteLine($"{Nom} i {tortuga.Nom} es troben i es moren els 2");
        }
    }

}