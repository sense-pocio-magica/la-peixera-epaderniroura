namespace Tasca;

public class Peixera
{
    public List<Aquatic> Animals { get; set; }
    public static int CasellesPeixera = 20;
    
    public Peixera(List<Aquatic> animalsAquatics)
    {
        Animals = animalsAquatics;
    }

    public void AfegirAnimalsAlaPeixera(Aquatic a)
    {
        Animals.Add(a);
    }

    public int QuantsAnimalsHiHa(List<Aquatic> animals)
    {
        return animals.Count();
    }
    
    //Mètode principal
    public void Jugar()
    {
        for(var i = 0; i < 100; i ++)
        {
            Console.WriteLine("=================================");
            Console.WriteLine();
            Moure();
            Xocar(Animals);
            Animals = Animals.Where(m => m.Vida).ToList();

            continue;
        }
    }
    
    //Mètodes secundaris
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
            if (animal._Id == altre._Id)
            {
                continue;
            }
            
            if (animal.PosicioX == altre.PosicioX && animal.PosicioY == altre.PosicioY)
            {
                //Comprovar si està correcte
                AnimalsQueHeXocat.Add(animal);
            }
        }

        return AnimalsQueHeXocat;
    }

    public void Xocar(List<Aquatic> animals)
    {
        //Posar el mètode Xocar
        for (var j = 1; j < Animals.Count; j++)
        {
            var animalQueXoca = AmbQuiXoco(animals[j]);
            
            if (animalQueXoca.Count > 0)
            {
                foreach (var animalXocat in animalQueXoca)
                {
                    var fill = animals[j].ReaccionarAlXoc(animalXocat);

                    if (fill != null)
                    {
                        AfegirAnimalsAlaPeixera(fill);
                    }
                    
                    if (animals[j].Vida == false  || animalXocat is Tortuga)
                    {
                        break;
                    }
                }
            }
            
        }
        
    }

}