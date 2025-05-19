public class Cane
{

    public string nome;
    public int eta;

    public Cane(string nome, int eta)
    {
        this.eta = eta;
        this.nome = nome;
    }

    public void Abbaia()
    {
        Console.WriteLine(nome + " dice: Bau!");
    }

    public void Eta()
    {
        Console.WriteLine(nome + $" Ha {eta} anni");
    }

}

/*
public class Programma
{
    public static void Main()
    {
        Cane mioCane = new Cane("Zoe", 15);
        mioCane.Abbaia();
        mioCane.Eta();
    }

}*/