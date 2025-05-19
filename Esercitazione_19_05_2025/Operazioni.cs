using System;

class Operazioni
{
    static void Main(string[] args)
    {
        int n1 = 0, n2 = 0;

        Console.WriteLine("Inserisci l'operazione che vuoi effettuare, somma ,moltiplicazione , divisione\n");
        string inserimento = Console.ReadLine();


        Console.WriteLine("Inserisci due numeri interi\n");
        try
        {
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Inserimento non valido\n");
        }



        int somma = Somma(n1, n2);
        int prodotto = Moltiplica(n1, n2);

        if (inserimento == "somma")
            StampaRisultato(inserimento, somma);
        else if (inserimento == "moltiplicazione")
            StampaRisultato(inserimento, prodotto);
        else if (inserimento == "divisione")
        {
            try
            {
                int quoziente = Dividi(n1, n2);
                StampaRisultato(inserimento, quoziente);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divisione per 0 non consentita");
            }

        }
        else
        Console.WriteLine("Non hai inserito un'operazione valida, arrivederci.");

    }





    public static int Somma(int a,int b)
    {
        return a+b;
    }

    public static int Moltiplica(int a,int b)
    {
        return a*b;
    }

    public static void StampaRisultato(string operazione,int risultato)
    {
       Console.WriteLine("Il risultato dell'operazione " + operazione + " è " + risultato);
    }

     public static int Dividi(int a,int b)
    {
        return a/b;
    }

}