/*using System;

public interface IObserver
{
    public void Aggiorna(string messaggio);
}

public interface ISoggetto
{
    public void Registra(IObserver osservatore);
    public void Rimuovi(IObserver osservatore);
    public void Notifica(string messaggio);
}

public class CentroMeteo : ISoggetto
{
    private List<IObserver> Observers = new List<IObserver>();

    public void AggiornaMeteo(string dati)
    {

        Console.WriteLine("Aggiorna meteo");
        Notifica(dati);
    }



    public void Registra(IObserver osservatore)
    {
        Observers.Add(osservatore);
    }

    public void Rimuovi(IObserver osservatore)
    {
        Observers.Remove(osservatore);
    }

    public void Notifica(string messaggio)
    {
        foreach (var obs in Observers)
        {
            obs.Aggiorna(messaggio);
        }
    }
}


    public class DisplayConsole : IObserver
    {
        public void Aggiorna(string messaggio)
        {
            Console.WriteLine($"[Console] Meteo aggiornato: {messaggio}");
        }
    }


    public class DisplayMobile : IObserver
    {
        public void Aggiorna(string messaggio)
        {
            Console.WriteLine($"[Mobile] Meteo ricevuto: {messaggio}");
        }
    }
/*
public class Program
{
    public static void Main()
    {
        CentroMeteo centro = new CentroMeteo();
        IObserver console = new DisplayConsole();
        IObserver mobile = new DisplayMobile();

        centro.Registra(console);
        centro.Registra(mobile);

        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\n1. Inserisci aggiornamento meteo\n0. Esci");
            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Inserisci nuove condizioni meteo: ");
                    string dati = Console.ReadLine();
                    centro.AggiornaMeteo(dati);
                    break;
                case "0":
                    continua = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }

        Console.WriteLine("Programma terminato.");
    }


}
*/