using System;


    public class PrenotazioneViaggi
    {
        private int postiprenotati;
        private string destinazione;
        const int max_posti = 20;

    public PrenotazioneViaggi(string destinazione)
    {
        postiprenotati = 0;
        this.destinazione = destinazione;
    }


        public string Destinazione
    {
        get { return destinazione; }
        set
        {
            destinazione = value;
        }
    }

        public int PostiDisponibili
        {
            get { return max_posti - postiprenotati; }
        }

        public void PrenotaPosti(int i)
        {
        if (PostiDisponibili > (postiprenotati + i))
        {
            postiprenotati += i;
        }
        }

        public void AnnullaPrenotazione(int numero)
        {
            if (numero <= postiprenotati)
                postiprenotati -= numero;
        }

        public int PostiPrenotati
        {
            get { return postiprenotati; }
        }

        public static void Main()
        {
            Console.WriteLine("Inserisci una destinazione");
            string s = Console.ReadLine();
            PrenotazioneViaggi prenota = new PrenotazioneViaggi(s);

            while (true)
        {
            Console.WriteLine("Menu \n1 Prenota\n2 Annulla \n3esci");
            string inserimento = Console.ReadLine();
            int i = 0;
            switch (inserimento)
            {
                case "1":
                    Console.WriteLine("Inserisci il numero di posti da prenotare");
                    i = int.Parse(Console.ReadLine());
                    prenota.PrenotaPosti(i);
                    Console.WriteLine("Posti disponibili =" + prenota.PostiDisponibili + "\nPosti prenotati" + prenota.PostiPrenotati);
                    break;

                case "2":
                    Console.WriteLine("Inserisci il numero di posti da annullare ");
                    i = int.Parse(Console.ReadLine());
                    prenota.AnnullaPrenotazione(i);
                    Console.WriteLine("Posti disponibili =" + prenota.PostiDisponibili + "\nPosti prenotati" + prenota.PostiPrenotati);
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
    

}