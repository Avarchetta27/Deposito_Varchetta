using System;

public interface IBevanda
{
    public string Descrizione();
    public double Costo();

}

public class Caffe : IBevanda
{
    public string Descrizione()
    {
        return "Caffe";
    }

    public double Costo()
    {
        return 1.2;
    }
}

public class Te : IBevanda
{
    public string Descrizione()
    {
        return "Te";
    }

    public double Costo()
    {
        return 2.5;
    }
}

public abstract class DecoratoreBevanda : IBevanda
{
    protected IBevanda bevanda_base;

    protected DecoratoreBevanda(IBevanda bevanda_base)
    {
        this.bevanda_base = bevanda_base;
    }

}

public class ConLatte : DecoratoreBevanda
{
    public ConLatte(DecoratoreBevanda x) : base(bevanda_base)
    {

    }
    
    public override string Descrizione() => bevanda_base.Descrizione() + ", con latte";
    public override double Costo() => bevanda_base.Costo() + 0.30;

}

public class ConCioccolato : DecoratoreBevanda
{
    public ConCioccolato(DecoratoreBevanda x) : base(bevanda_base)
    {

    }
    
    public override string Descrizione() => bevanda_base.Descrizione() + ", con cioccolato";
    public override double Costo() => bevanda_base.Costo() + 0.60;
}

public class ConPanna : DecoratoreBevanda
{
    public ConPanna(DecoratoreBevanda x) : base(bevanda_base)
    {

    }

    public override string Descrizione() => bevanda_base.Descrizione() + ", con panna";
    public override double Costo() => bevanda_base.Costo() + 0.80;
}

/*
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Vuoi ordinare un te o caffe");
        string inserimento = Console.ReadLine();
        IBevanda ordine;

        if (inserimento == "caffe")
            IBevanda ordine = new Caffe();
        else if (inserimento == "te")
            IBevanda ordine = new Te();
        else return;

        
        ordine = new ConLatte(ordine);

        Console.WriteLine("Ordine: " + ordine.Descrizione());
        Console.WriteLine("Costo totale: €" + ordine.Costo());
    }
}