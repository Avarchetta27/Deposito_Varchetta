using System;

public sealed class ConfigurazioneSistema
{
    private static ConfigurazioneSistema _istance;

    public static Dictionary<string, string> Dizionario { get; set; }

    private ConfigurazioneSistema()
    {
        Dizionario = new Dictionary<string, string>();
    }


    public static ConfigurazioneSistema Instance
    {
        get
        {
            if (_istance == null)
                _istance = new ConfigurazioneSistema();
            return _istance;
        }
    }



    public void Imposta(string chiave, string valore)
    {
        if (!Dizionario.ContainsKey(chiave))
            Dizionario[chiave] = valore;

    }

    public string Leggi(string chiave)
    {
        if (Dizionario.ContainsKey(chiave))
            return Dizionario[chiave];
        else
            return null;
    }

    public static void Stampa()
    {
        foreach (KeyValuePair<string, string> coppia in Dizionario)
        {
            Console.WriteLine($"Chiave = {coppia.Key} Valore = {coppia.Value}");
        }
    }



}

public class ModuloA
{
    public void setta()
    {
        ConfigurazioneSistema var = ConfigurazioneSistema.Instance;
        var.Imposta("AT","Attivo");
        var.Imposta("SP","Spento");
    }
    
}

public class ModuloB
{
    public void setta()
    {
        ConfigurazioneSistema var = ConfigurazioneSistema.Instance;
        var.Imposta("1","Bulbasaur");
        var.Imposta("2","Ivysaur");
    }
    
}


public class Program_3
{/*
    public static void Main()
    {

        
        // Esercizio 2
         ModuloA a = new ModuloA();
ModuloB b = new ModuloB();

a.setta();
b.setta();

        
        

        if (Object.ReferenceEquals(ConfigurazioneSistema.Instance, ConfigurazioneSistema.Instance))
        {
            ConfigurazioneSistema.Stampa();
        }


    }*/
}