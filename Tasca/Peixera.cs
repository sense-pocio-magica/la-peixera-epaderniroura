namespace Tasca;

public class Peixera
{
    public List<Aquatic> Animals { get; set; }
    public static int CasellesPeixera = 20;
    private List<Aquatic> TotalTaurons { get; set; }
    private List<Aquatic> TotalTortugues { get; set; }
    private List<Aquatic> TotalPeixos { get; set; }
    private List<Aquatic> TotalPop { get; set; }
    
    private List<Aquatic> AnimalsQueJaHanXocat = new List<Aquatic>();
    public Peixera(List<Aquatic> animalsAquatics)
    {
        Animals = animalsAquatics;
       
        TotalPeixos = new List<Aquatic>();
        TotalTaurons = new List<Aquatic>();
        TotalPop = new List<Aquatic>();
        TotalTortugues = new List<Aquatic>();
        
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
        for(var i = 1; i < 100; i ++)
        {
            Console.WriteLine("\n====================================================================");
            Console.WriteLine($"----------------------------RONDA {i}------------------------------\n");
            Moure();
            Xocar(Animals);
            Animals = Animals.Where(m => m.Vida).ToList();
            continue;
        }
        ResultatFinal();
    }

    private void ResultatFinal()
    {
        for (var i = 0; i < Animals.Count; i++)
        {
            switch (Animals[i])
            {
                case Tauro:
                    TotalTaurons.Add(Animals[i]);
                    break;
                
                case Peix:
                    TotalPeixos.Add(Animals[i]);
                    break;
                
                case Pop:
                    TotalPop.Add(Animals[i]);
                    break;
                
                case Tortuga:
                    TotalTortugues.Add(Animals[i]);
                    break;
                
                default:
                    break;
            }
        }
        Console.WriteLine("\n===== RESULTAT FINAL =====");
        Console.WriteLine($"Peixos: {TotalPeixos.Count}");
        Console.WriteLine($"Taurons: {TotalTaurons.Count}");
        Console.WriteLine($"Pops: {TotalPop.Count}");
        Console.WriteLine($"Tortugues: {TotalTortugues.Count}");

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
        var NousAnimals = new List<Aquatic>();

        AnimalsQueJaHanXocat.Clear();
        for (var j = 0; j < Animals.Count; j++)
        {
            if (AnimalsQueJaHanXocat.Contains(animals[j])) continue;
            
            var animalQueXoca = AmbQuiXoco(animals[j]);
            
            if (animalQueXoca.Count > 0)
            {
                
                foreach (var animalXocat in animalQueXoca)
                {
                    var fill = animals[j].ReaccionarAlXoc(animalXocat);
                    
                    AnimalsQueJaHanXocat.Add(animalXocat);
                    AnimalsQueJaHanXocat.Add(animals[j]);
                    
                    if (fill != null)
                    {
                        NousAnimals.Add(fill);
                        //AfegirAnimalsAlaPeixera(fill);
                        break;
                    }

                    if (animals[j].Vida == false || animalXocat is Tortuga) break;
                }
            }
        }

        foreach (var animalsLlista in NousAnimals)
        {
            AfegirAnimalsAlaPeixera(animalsLlista);
        }
        
    }

}