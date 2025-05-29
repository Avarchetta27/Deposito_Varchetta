using System;

public interface ITorta
{
    string Descrizione();
}

public class TortaCioccolato : ITorta
{
    public string Descrizione()
    {
        return "Torta al Cioccolato";
    }
}

public class TortaVaniglia : ITorta
{
    public string Descrizione()
    {
        return "Torta alla vaniglia";
    }
}

public class TortaFrutta : ITorta
{
    public string Descrizione()
    {
        return "Torta alla frutta";
    }
}

public abstract class DecoretoreTorta : ITorta
{
    protected ITorta torta_base;

    public DecoretoreTorta(ITorta torta_base)
    {
        this.torta_base = torta_base;
    }

    public abstract string Descrizione();
}

public class ConPanna : DecoretoreTorta
{
    public ConPanna(ITorta x) : base(x) { }

    public override string Descrizione() => torta_base.Descrizione() + ", con panna";
    

}

public class ConFragole : DecoretoreTorta
{
    public ConFragole(ITorta x) : base(x) { }

    public override string Descrizione() => torta_base.Descrizione() + ", con fragole";
    

}

public class ConGlassa : DecoretoreTorta
{
    public ConGlassa(ITorta x) : base(x) { }

    public override string Descrizione() => torta_base.Descrizione() + ", con glassa";
}


public static class TortaFactory
{
    public static ITorta CreaTortaBase(string tipo)
    {
        switch (tipo)
        {
            case "cioccolato":
                return new TortaCioccolato();
                break;

            case "vaniglia":
                return new TortaVaniglia();
                break;

            case "frutta":
                return new TortaFrutta();
                break;

            default:
                return null;
        }
    }
}

public class Program_15
{
        public static void Main()
    {
        Console.WriteLine("Scegli torta base tra cioccolato,vaniglia,frutta");
        string inserimento = Console.ReadLine();
        ITorta torta;

        if (inserimento == "cioccolato" || inserimento == "vaniglia" || inserimento == "frutta")
            torta = TortaFactory.CreaTortaBase(inserimento);
        
        torta = new ConFragole(torta);

        Console.WriteLine("Torta: " + torta.Descrizione());
        
    }
    
}