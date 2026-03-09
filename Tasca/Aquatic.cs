namespace Tasca;

public abstract class Aquatic
{
    public static Peixera peixera;
    
    public static Random rnd = new Random();

    private static int Id = 0;
    public int _Id { get; set; }
    
    public int PosicioX { get; set; }
    public int PosicioY { get; set; }
    protected int DireccioX { get; set; }
    protected int DireccioY { get; set; }
    
    public bool Vida = true;

    public Aquatic(int posicioX, int posicioY)
    {
        Id++;
        _Id = Id;
        Vida = true;
        PosicioX = posicioX;
        PosicioY = posicioY;
    }
    
    public virtual void Moviment()
    {
        PosicioX = (PosicioX + DireccioX) % Peixera.CasellesPeixera;
        PosicioY = (PosicioY + DireccioY) % Peixera.CasellesPeixera;
    }
   
        
    public abstract Aquatic? ReaccionarAlXoc(Aquatic altre);
    public virtual bool EsInvulnerable() => false;

    public bool Matar()
    {
        return Vida = false;
    }

}