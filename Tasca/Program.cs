namespace Tasca;

public class Program
{
    static void Main(string[] args)
    {
        List<Aquatic> AnimalsCreats = new List<Aquatic>();
        
        int quantitatDePeixos = 50;
        
        int quantitatDeTaurons = 10;
        
        int quantitatDePops = 15;
        
        int quantitatDeTortuges = 6;
       
       
            
        Random rnd = new Random();
        var posicioxrandom = rnd.Next(0, 19);
        var posicioyrandom = rnd.Next(0, 19);
        
        //Creació de peixos
        for (var i = 0; i <= quantitatDePeixos; i++)
        {
           AnimalsCreats.Add(new Peix(rnd.Next(Peixera.CasellesPeixera), rnd.Next(Peixera.CasellesPeixera),Sexes.Mascle));
           AnimalsCreats.Add(new Peix(Peixera.CasellesPeixera, Peixera.CasellesPeixera,Sexes.Femella));
        }
        
        //Creació de Tauró
        for (var i = 0; i <= quantitatDeTaurons; i++)
        {
            AnimalsCreats.Add(new Tauro(rnd.Next(Peixera.CasellesPeixera), rnd.Next(Peixera.CasellesPeixera), Sexes.Mascle));
            AnimalsCreats.Add(new Tauro(rnd.Next(Peixera.CasellesPeixera), rnd.Next(Peixera.CasellesPeixera), Sexes.Femella));

        }
        
        //Creació de Pops
        for (var i = 0; i <= quantitatDePops; i++)
        {
            AnimalsCreats.Add(new Pop(rnd.Next(Peixera.CasellesPeixera), rnd.Next(Peixera.CasellesPeixera)));
        }
        
        //Creació de Tortuges
        
        for (var i = 0; i <= quantitatDeTortuges; i++)
        {
            AnimalsCreats.Add(new Tortuga(rnd.Next(Peixera.CasellesPeixera), rnd.Next(Peixera.CasellesPeixera),Sexes.Mascle));
            AnimalsCreats.Add(new Tortuga(rnd.Next(Peixera.CasellesPeixera), rnd.Next(Peixera.CasellesPeixera), Sexes.Femella));

        }
        
        var peixera = new Peixera(AnimalsCreats);
        
        peixera.Jugar();


    }
}

