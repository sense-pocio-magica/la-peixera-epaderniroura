namespace Tasca;

public class Tauro : Reproductor
{
    public Tauro(string nom) : base(nom)
    {
    }
    
    public virtual void Moviment()
    {
        PosicioX += DireccioX;
        PosicioY += DireccioY;
    }
    
    public override void Criar(Tauro tauro)
    {
        var nomfill = Nom + tauro.Nom;
        if (Sexe == Sexes.Femella && tauro.Sexe == Sexes.Mascle)
        {
            new Tauro(nomfill);
        }
        
        else if (Sexe == Sexes.Mascle && tauro.Sexe == Sexes.Femella)
        {
            new Tauro(nomfill);

        }
    }

    public override void MatarMateixSexe(Tauro tauro)
    {
        if (Sexe == Sexes.Femella && tauro.Sexe == Sexes.Femella)
        {
            Vida = false;
            tauro.Vida = false;
            Console.WriteLine($"{Nom} i {tauro.Nom} es troben i es moren els 2");
        }
        else if (Sexe == Sexes.Mascle && tauro.Sexe == Sexes.Mascle)
        {
            Vida = false;
            tauro.Vida = false;
            Console.WriteLine($"{Nom} i {tauro.Nom} es troben i els 2 moren");
        }
    }

}