using System;

public class Prova{
    public class Film
    {
        public string titolo;
        public string regista;
        public int anno;
        public string genere;


        public Film()
        {
            this.titolo = "";
            this.regista = "";;
            this.anno = 0;
            this.genere = "";;
        }

        public override string ToString()
        {
            return ($"{titolo} {regista} {anno} {genere}");
        }
    }
/*
    public static void Main(string[] args)
    {
    List<Film> videoteca = new List<Film>();
    int n = 0;


    while (true)
        {
            Film inserimento = new Film();
            Console.WriteLine("Inserisci il titolo del film");
            inserimento.titolo = Console.ReadLine();
            Console.WriteLine("Inserisci il regista del film");
            inserimento.regista = Console.ReadLine();
            Console.WriteLine("Inserisci l'anno del film");
            inserimento.anno = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il genere del film");
            inserimento.genere = Console.ReadLine();
            videoteca.Add(inserimento);

            Console.WriteLine("Vuoi interrompere l'interruzione? se si premi 1");
            string risposta = Console.ReadLine();

            if (risposta == "1" && n >= 2)
                break;
            n++;
        }

    foreach (Film x in videoteca)
    { 
        Console.WriteLine(x.ToString());            
    }
    
    Console.WriteLine("Inserisci il genere di film che vuoi ricercare");
    string risposta1 = Console.ReadLine();

    Console.WriteLine("Esito ricerca");
        foreach (Film x in videoteca)
        {
            if (risposta1 == x.genere)
                Console.WriteLine(x.ToString());
        }

    }
*/
}


