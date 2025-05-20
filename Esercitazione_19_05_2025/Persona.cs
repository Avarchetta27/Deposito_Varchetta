using System;
public class Persona
{
    public string nome;
    public string cognome;
    public int anno_nascita;

    public Persona(string nome, string cognome, int anno_nascita)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.anno_nascita = anno_nascita;
    }

    public override string ToString()
    {
        return $"{nome} {cognome}  {anno_nascita}";
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
                    Console.WriteLine("Inserisci il nome");
                    string nome1 = Console.ReadLine();
                    Console.WriteLine("Inserisci il cognome");
                    string cognome1 = Console.ReadLine();
                    Console.WriteLine("Inserisci l'anno di nascita");
                    int anno1 = int.Parse(Console.ReadLine());
                    Persona persona1 = new Persona(nome1, cognome1, anno1);
                    Console.WriteLine($"{persona1.nome} {persona1.cognome} è nato il {persona1.anno_nascita} \n");
                    persona1.ToString();
                }

                if (n == 1)
                {
                    Console.WriteLine("Inserisci il nome");
                    string nome2 = Console.ReadLine();
                    Console.WriteLine("Inserisci il cognome");
                    string cognome2 = Console.ReadLine();
                    Console.WriteLine("Inserisci l'anno di nascita");
                    int anno2 = int.Parse(Console.ReadLine());
                    Persona persona2 = new Persona(nome2, cognome2, anno2);
                    Console.WriteLine($"{persona2.nome} {persona2.cognome} è nato il {persona2.anno_nascita} \n");
                    persona2.ToString();
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