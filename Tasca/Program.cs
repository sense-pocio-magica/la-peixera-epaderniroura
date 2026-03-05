namespace Tasca;

internal class Program
{
    static void Main(string[] args)
    {
        int QuantitatDePeixos = 50;
        int QuantitatDeTaurons = 10;
        int QuantitatDePops = 15;
        int QuantitatDeTortuges = 6;

        Random rnd = new Random();
        var posicioxrandom = rnd.Next(0, 19);
        var posicioyrandom = rnd.Next(0, 19);
        
        for (var i = 0; i <= QuantitatDePeixos; i++)
        {
           new Peix(posicioxrandom, posicioyrandom, "Peix",null);
        }
        
        for (var i = 0; i <= QuantitatDeTaurons; i++)
        {
            new Tauro(posicioxrandom, posicioyrandom, "Tauro",null);
        }
        
        for (var i = 0; i <= QuantitatDePops; i++)
        {
            new Pop(posicioxrandom, posicioyrandom, "Pop");
        }
        
        for (var i = 0; i <= QuantitatDeTortuges; i++)
        {
            new Tortuga(posicioxrandom, posicioyrandom, "Tortuga",null);
        }
        
       
    }
}

