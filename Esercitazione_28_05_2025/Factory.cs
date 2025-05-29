using System;


public interface IVeicolo
{
    void Avvia();
    void MostraTipo();

}


public class ConcreteAuto : IVeicolo
{
    public  void Avvia()
    {
        Console.WriteLine("Avvio dell'auto");
    }

    public  void MostraTipo()
    {
        Console.WriteLine("Tipo = Auto");
    }

}

public class ConcreteMoto : IVeicolo
{
    public  void Avvia()
    {
        Console.WriteLine("Avvio della moto");
    }

    public  void MostraTipo()
    {
        Console.WriteLine("Tipo: Moto");
    }
}


public class ConcreteCamion : IVeicolo
{
    public  void Avvia()
    {
        Console.WriteLine("Avvio del camion");
    }

    public  void MostraTipo()
    {
        Console.WriteLine("Tipo: Camion");
    }

}

public class VeicoloFactory
{
    public static IVeicolo CreaVeicolo(string tipo)
    {
        switch (tipo)
        {
            case "auto":
                return new ConcreteAuto();
                break;

            case "moto":
                return new ConcreteMoto();
                break;

            case "camion":
                return new ConcreteCamion();
                break;

            default:
                return null;
                break;
        }
    }
}

/*
public class Program_5
{
    public static void Main()
    {
        Console.WriteLine("Quale veicolo vuoi creare? inserire 1 per uscire ");

        while (true)
        {
            string inserimento = Console.ReadLine();
            switch (inserimento.ToLower())
            {
                case "auto":
                    IVeicolo a = VeicoloFactory.CreaVeicolo("auto");
                    if (a != null)
                    {
                        a.Avvia();
                        a.MostraTipo();
                    }
                    break;

                case "moto":
                    IVeicolo b = VeicoloFactory.CreaVeicolo("moto");
                    if (b != null)
                    {
                        b.Avvia();
                        b.MostraTipo();
                    }
                    break;

                case "camion":
                    IVeicolo c = VeicoloFactory.CreaVeicolo("camion");
                    if (c != null)
                    {
                        c.Avvia();
                        c.MostraTipo();
                    }
                    break;

                case "1":
                    return;

                default:
                    Console.WriteLine("Inserimento errato");
                    break;


            }
        }
    } 
}

*/