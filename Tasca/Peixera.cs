namespace Tasca;

public abstract class Peixera
{
    public List<Aquatic> Animals { get; set; }
    public int CasellesPeixera = 20;
    public Peixera()
    {
        Animals = new List<Aquatic>();
    }

    public void AfegirAnimalsAlaPeixera(Aquatic a)
    {
        Animals.Add(a);
    }

    public int QuantsAnimalsHiHa(List<Aquatic> animals)
    {
        return animals.Count();
    }

    private void Moure()
    {
        foreach (var animal in Animals)
        {
            animal.Moviment();
        }
    }
    
    //Veure amb quin animal o quants animals he xocat
    private List<Aquatic> AmbQuiXoco(Aquatic altre)
    {
        List<Aquatic> AnimalsQueHeXocat = new List<Aquatic>();
        
        foreach (var animal in Animals)
        {
            if (animal.PosicioX == altre.PosicioX && animal.PosicioY == altre.PosicioY)
            {
                //Comprovar si està correcte
                AnimalsQueHeXocat.Add(animal);
            }
        }
        return AnimalsQueHeXocat;
    }
    
    
    public void AvançarRonda(Aquatic altre)
    {
        for(var i = 0; i < 100; i ++)
        {
            //Posar el mètode AmbQuiXoco, Xocar
        }
    }
    
    public void Xocar(Aquatic altre)
    {
        //Posar el mètode Xocar
        for (var j = 1; j < Animals.Count; j++)
        {
            if (AmbQuiXoco(altre) )
            {
                
            }
            
            altre.ReaccionarAlXoc();
            
        }
        
    }

}