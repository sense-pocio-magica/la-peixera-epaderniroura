namespace Tasca;

public abstract class Aquatic
{
    public int PosicioX { get; set; }
    public int PosicioY { get; set; }
    protected int DireccioX { get; set; }
    protected int DireccioY { get; set; }

    protected string Nom { get; set; }
    
    protected bool Vida = true;

    public Aquatic(string nom)
    {
        Vida = true;
        Nom = nom;
    }
    
    public virtual void Moviment()
    {
        PosicioX += DireccioX;
        PosicioY += DireccioY;
    }
    
    public abstract List<Aquatic> ReaccionarAlXoc(Aquatic altre);

    public abstract bool EsReproductor();

    public abstract bool EsInvulnerable();

    public abstract bool EsMateixSexe();
    
}