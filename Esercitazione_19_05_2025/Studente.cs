using System;
public class Studente
{
    public string nome;
    public int matricola;
    public double mediavoti;

    public Studente(string nome, int matricola, double mediavoti)
    {
        this.nome = nome;
        this.matricola = matricola;
        this.mediavoti = mediavoti;
    }

/*
    public static void Main()
    {
        try
        {
            int n = 0;
            while (n < 2)
            {
                if (n == 0)
                {
                    Console.WriteLine("Inserisci il nome dello studente");
                    string nome1 = Console.ReadLine();
                    Console.WriteLine("Inserisci la matricola");
                    int matricola1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci la media dei voti");
                    double mediav1 = double.Parse(Console.ReadLine());
                    Studente studente1 = new Studente(nome1, matricola1, mediav1);
                    Console.WriteLine($"Lo studente {studente1.nome} con matricola {studente1.matricola} ha la media di {studente1.mediavoti} \n");
                }

                if (n == 1)
                {
                    Console.WriteLine("Inserisci il nome dello studente");
                    string nome2 = Console.ReadLine();
                    Console.WriteLine("Inserisci la matricola");
                    int matricola2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci la media dei voti");
                    double mediav2 = double.Parse(Console.ReadLine());
                    Studente studente2 = new Studente(nome2, matricola2, mediav2);
                    Console.WriteLine($"Lo studente {studente2.nome} con matricola {studente2.matricola} ha la media di {studente2.mediavoti} \n");
                }

                n++;
            }
  
        }
        catch (FormatException)
        {
            Console.WriteLine("Hai inserito un valore errato");
        }
        finally
        {
            Console.WriteLine("Programma terminato");
        }
    } */
}
