using System;

public interface IObserver
{
    public void NotificaCreazione(string nomeUtente);
}

public interface ISoggetto
{
    public void Registra(IObserver x);
    public void Rimuovi(IObserver x);
    public void Notifica(string nomeUtente);
}

public class GestoreCreazioneUtente : ISoggetto
{
    private readonly List<IObserver> osservatori = new List<IObserver>();

    public void Registra(IObserver x)
    {
        osservatori.Add(x);
    }

    public void Rimuovi(IObserver x)
    {
        osservatori.Remove(x);
    }

    public void Notifica(string nomeUtente)
    {
        foreach (var obs in osservatori)
        {
            obs.NotificaCreazione(nomeUtente);
        }
    }
    public void CreaUtente(string nome)
    {
        Utente x = UserFactory.Crea(nome);
        Notifica(x.Nome);
    }
}

public class UserFactory
{
    public static Utente Crea(string nome)
    {
        return new Utente(nome);
    }
}

public class Utente
{
    public string Nome{ get; set; }

    public Utente(string nome)
    {
        this.Nome = nome;
    }
    public override string ToString()
    {
        return "Utente = " + Nome;
    }
}

public class ModuloLog :  IObserver
{
    public void NotificaCreazione(string nomeUtente)
    {
        Console.WriteLine("Creazione Modulo Log " + nomeUtente);
    }
}

public class ModuloMarketing : IObserver
{
    public void NotificaCreazione(string nomeUtente)
    {
        Console.WriteLine("Creazione Modulo Marketing " + nomeUtente);
    }
}
/*
public class Program_8
{
    public static void Main()
    {
        GestoreCreazioneUtente x = new GestoreCreazioneUtente();
        x.Registra(new ModuloLog());
        x.Registra(new ModuloMarketing());

        while (true)
        {
            Console.WriteLine("Inserisci un utente con 1 , esci con 2");
            string inserimento = Console.ReadLine();
            switch (inserimento)
            {
                case "1":
                    Console.WriteLine("Inserisci nome utente ");
                    string inserimento2 = Console.ReadLine();
                    x.CreaUtente(inserimento2);
                    break;

                case "2":
                    return;

                default:
                    Console.WriteLine("Inserimento errato ");
                    break;

            }
        }
    }
} */