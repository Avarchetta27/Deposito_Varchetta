using System;


public class VoloAereo
{
    private int postiOccupati;
    public string codice_volo { get; set; }
    const int max_Posti = 150;

    public VoloAereo(string codice_volo)
    {
        postiOccupati = 0;
        this.codice_volo = codice_volo;
    }



    public int PostiOccupati
    {
        get { return postiOccupati; }
    }

    public int PostiLiberi
    {
        get { return max_Posti - postiOccupati; }
    }




        public void EffettuaPrenotazione(int numero_posti)
    {
        if (postiOccupati + numero_posti < (max_Posti))
            postiOccupati += numero_posti;

            else
                Console.WriteLine("Posti non disponibili, inserire un valore corretto");

        
    }

    public void AnnullaPrenotazione(int numero_posti)
    {
        if (numero_posti <= postiOccupati)
            postiOccupati -= numero_posti;
            else
            Console.WriteLine("Hai inserito un numero maggiore di posti da annullare rispetto al consentito");
    }

        public void VisualizzaStato()
        {
        Console.WriteLine("Codice volo = " + codice_volo + "\nPosti Occupati = " + postiOccupati + "\nPosti Liberi = " + PostiLiberi);
        }


/*
        public static void Main()
    {
        Console.WriteLine("Inserisci un volo");
        string s = Console.ReadLine();
        VoloAereo volo = new VoloAereo(s);

        while (true)
        {
            Console.WriteLine("Menu \n1 Prenota\n2 Annulla \n3 Esci");
            string inserimento = Console.ReadLine();
            int i = 0;
            switch (inserimento)
            {
                case "1":
                    Console.WriteLine("Inserisci il numero di posti da prenotare");
                    i = int.Parse(Console.ReadLine());
                    volo.EffettuaPrenotazione(i);
                    volo.VisualizzaStato();
                    break;

                case "2":
                    Console.WriteLine("Inserisci il numero di posti da annullare ");
                    i = int.Parse(Console.ReadLine());
                    volo.AnnullaPrenotazione(i);
                    volo.VisualizzaStato();
                    
                    break;

                case "3":
                    Console.WriteLine("Arrivederci");
                    break;

                default:
                    Console.WriteLine("Operazione non valida");
                    break;
            }
            if (inserimento == "3")
                break;
        }
    }
    */

}