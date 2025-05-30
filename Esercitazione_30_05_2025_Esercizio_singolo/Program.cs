using System;
// mi sono fermato al singleton poichè ho dovuto fare altre attività in parallelo per il work.
public interface Ipizza
{
    void Descrizione();
}

public class Margherita : Ipizza
{
    public void Descrizione()
    {
        Console.WriteLine("Pizza Margherita ");
    }
}


public class Diavola : Ipizza
{ 
    public void Descrizione()
    {
        Console.WriteLine("Pizza Diavola ");
    }
}
public class Vegetariana : IPizza
{
    public void Descrizione()
    {
        Console.WriteLine("Pizza Vegetarian ");
    }
}

    public static IPizza CreaPizza(string tipo)
    {
        switch (tipo)
        {
            case "margherita":
                return new Margherita();
                break;

            case "diavola":
                return new Diavola();
                break;

            case "vegetariana":
                return new Vegetariana();
                break;

            default:
                return null;
                break;
        }
    }

public abstract class DecoratorePizza : IPizza
{
    protected Ipizza _pizza;

    protected DecoratoreBevanda(IBevanda _pizza)
    {
        this.bevanda_base = _pizza;
    }
    public abstract string Descrizione();

}


public class ConOlive : DecoratorePizza
{
    public ConOlive(DecoratorePizza _pizza) : base(_pizza)
    {

    }

    public override string Descrizione() => _pizza.Descrizione() + ", con olive";

}

public class ConMozzarellaExtra : DecoratorePizza
{
    public ConMozzarellaExtra(DecoratorePizza _pizza) : base(_pizza)
    {

    }

    public override string Descrizione() => _pizza.Descrizione() + ", con mozzarella extra";

}


public class ConFunghi : DecoratorePizza
{
    public ConFunghi(DecoratorePizza _pizza) : base(_pizza)
    {

    }

    public override string Descrizione() => _pizza.Descrizione() + ", con funghi";

}

public interface ImetodoCotture
{
    string cuoci(string pizza);
}

public class FornoElettrico : ImetodoCotture
{
    public string cuoci(string pizza)
    {
        return pizza + " cotta al forno elettrico";
    }
}

public class FornoLegna : ImetodoCotture
{
    public string cuoci(string pizza)
    {
        return pizza + " cotta al forno a legna";
    }
}


public class FornoVentilato : ImetodoCotture
{
    public string cuoci(string pizza)
    {
        return pizza + " cotta al forno ventilato";
    }
}

public sealed class GestoreOrdine
{
    private static GestoreOrdine _istanza;

    private GestoreOrdire{}
}


