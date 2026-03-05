namespace Tasca;

public abstract class Aquatic
{
    public static Peixera peixera;
    
    private List<Peix> Peix;
    private List<Tauro> Tauro;
    private List<Pop> Pop;
    private List<Tortuga> Tortuga;
    
    public static Random rnd = new Random();
    public int posicioxrandom = rnd.Next(peixera.CasellesPeixera); 
    public int posicioyrandom = rnd.Next(peixera.CasellesPeixera);
    
    public int PosicioX { get; set; }
    public int PosicioY { get; set; }
    protected int DireccioX { get; set; }
    protected int DireccioY { get; set; }

    public string Nom { get; set; }

    public bool Vida = true;

    public Aquatic(int posicioX, int posicioY,string nom)
    {
        Vida = true;
        Nom = nom;
        PosicioX = posicioX;
        PosicioY = posicioY;
    }
    
    public virtual void Moviment()
    {
        PosicioX += DireccioX;
        PosicioY += DireccioY;
    }
    
    public abstract Aquatic? ReaccionarAlXoc(Aquatic altre);
    public virtual bool EsInvulnerable() => false;

    public bool Matar()
    {
        return Vida = false;
    }

}