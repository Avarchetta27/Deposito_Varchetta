using System;

public sealed class Logger
{
    private static Logger _istance;

    public static List<string> Messaggi { get; set; }

    private Logger()
    {
        Messaggi = new List<string>();
    }


    public static Logger GetIstanza()
    {
        if (_istance is null)
        {
            _istance = new Logger();
        }
        return _istance;
    }



    public void ScriviMessaggio(string messaggio)
    {
        Console.WriteLine(messaggio + " " + DateTime.Now);
    }

    public void Log(string messaggio)
    {
        Messaggi.Add(messaggio);
    }

    public void Stampa()
    {
        foreach (string x in Messaggi)
        {
            Console.WriteLine(x);
        }
    }



}


public class Program_3
{
    public static void Main()
    {
        /* Esercizio 1 
        Logger log1 = Logger.GetIstanza();
        Logger log2 = Logger.GetIstanza();
        
        log1.ScriviMessaggio("Prova ");
        log2.ScriviMessaggio("prova 2");

        Console.WriteLine("Le due istanze sono uguali? " + (log1 == log2));
        Console.WriteLine("Programma terminato.");*/

        // Esercizio 2
        Logger log1 = Logger.GetIstanza();
        Logger log2 = Logger.GetIstanza();

        log1.Log("Ciao Mondo");
        log2.Log("Charizard selvatico appare");

        if (log1 == log2)
        {
            log1.Stampa();
            log2.Stampa();
        }


    }
}