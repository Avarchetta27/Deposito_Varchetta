/*using System

public interface ISubject
{
    public void Registra(IObserver osservatore);
    public void Rimuovi(IObserver osservatore);
    public void Notifica(string messaggio);
}

public class NewsAgency : ISubject
{
    bool is_observed;
    private string news;

    public News
    {
        get{ return news;}
set
    {
        news = value;
    }
    

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


public sealed abstract class AObserver
{
    public void Aggiorna(string notifica);
}

public class MobileApp : IObserver
{
    private MobileApp _istance;
    
    public static MobileApp GetIstanza()
    {
        if (_istance is null)
        {
            _istance = new MobileApp();
        }
        return _istance;
    }

    public
    public void Aggiorna(string notifica)
    {
        Console.WriteLine($"Notification on mobile: {notifica}");
    }
}


public sealed abstract class EmailClient : IObserver
{
    public void Aggiorna(string notifica)
    {
        Console.WriteLine($"Email sent: {notifica}");
    }
}
*/