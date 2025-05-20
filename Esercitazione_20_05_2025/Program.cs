using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        //Esercizio_1();
        //Esercizio_2();
        //Esercizio_3();
        Esercizio_4();
    }
    public class Utente
    {
        public string password;
        public string nickname;
        public int eta;

        public Utente(string password, string nickname, int eta)
        {
            this.password = password;
            this.nickname = nickname;
            this.eta = eta;
        }

        public override string ToString()
        {
            return $"{nickname}";
        }

        public override bool Equals(object x)
        {
            if (x is Utente y)
            {
                return (this.nickname == y.nickname && this.password == y.password);
            }
            return false;
        }
    }

    public class Macchina
    {
        public string motore;
        public float velocita;
        public int sospensioni_max;
        public int nrmodifiche;

        public Macchina(string motore, float velocita, int sospensioni_max, int nrmodifiche)
        {
            this.motore = motore;
            this.velocita = velocita;
            this.sospensioni_max = sospensioni_max;
            this.nrmodifiche = nrmodifiche;
        }

        public override string ToString()
        {
            return $"matricola:{motore}\nVelocità:{velocita} \nNumero sospensioni: {sospensioni_max} \nNumero modifiche:{nrmodifiche}";
        }

        public override bool Equals(object x)
        {
            if (x is Macchina y)
            {
                return (this.motore == y.motore);
            }
            return false;
        }


    }



    public class UtenteM
    {
        public string nome;
        public int credito;

        public UtenteM(string nome)
        {
            nome = nome;
            credito = 5;
        }

    }


    public class Calcolatrice
    {

        public static double Somma(double a, double b)
        {
            return a + b;
        }

        public static double Moltiplica(double a, double b)
        {
            return a * b;
        }

        public static double Dividi(double a, double b)
        {
            return a / b;
        }

    }





    public static void Esercizio_1()
    {
        while (true)
        {
            Utente db_user = new Utente("123456", "Antonio", 18);
            string username, password;
            int eta;

            Console.WriteLine("Inserisci username");
            username = Console.ReadLine();
            Console.WriteLine("Inserisci la pass");
            password = Console.ReadLine();
            Console.WriteLine("Inserisci l'età");
            eta = int.Parse(Console.ReadLine());
            Utente loggato = new Utente(password, username, eta);

            if (db_user.Equals(loggato))
            {
                Console.WriteLine("Log in effettuato con successo");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Inserisci il primo numero");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci il secondo numero");
                    double y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci l'operazione digitando : somma  moltiplicazione  divisione");
                    string inserimento = Console.ReadLine();

                    switch (inserimento)
                    {
                        case "somma":
                            Console.WriteLine($"Risultato = {Calcolatrice.Somma(x, y)} " + loggato.ToString());
                            break;

                        case "moltiplicazione":
                            Console.WriteLine($"Risultato = {Calcolatrice.Moltiplica(x, y)} " + loggato.ToString());
                            break;

                        case "divisione":

                            Console.WriteLine($"Risultato = {Calcolatrice.Dividi(x, y)} " + loggato.ToString());
                            break;

                        default:
                            Console.WriteLine("Hai inserito un valore errato");
                            break;
                    }
                }
            }
            else
                Console.WriteLine("Log in errato");

            continue;
        }
    }


    public static void Esercizio_2()
    {
        Console.WriteLine("Inserisci il tuo nome");
        string nome = Console.ReadLine();
        UtenteM utente = new UtenteM(nome);
        string motore = "";
        int sospensioni_max = 0;
        float velocita = 0;
        int nrmodifiche = 0;

        while (utente.credito > 0)
        {
            Console.WriteLine("Inserisci la modifica che vuoi effettuare digitando tra \n1 Modifica motore\n2 aumenta sospensioni\n3 aumenta velocita di 10\n4 Termina");
            int inserimento = int.Parse(Console.ReadLine());
            switch (inserimento)
            {
                case 1:
                    Console.WriteLine("Inserisci il nome del motore");
                    motore = Console.ReadLine();
                    nrmodifiche++;
                    utente.credito--;
                    break;

                case 2:
                    nrmodifiche++;
                    sospensioni_max++;
                    utente.credito--;
                    break;

                case 3:
                    velocita += 10;
                    nrmodifiche++;
                    utente.credito--;
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Inserimento Errato");
                    break;


            }
            if (inserimento == 4)
                break;
        }

        Macchina macchina = new Macchina(motore, velocita, sospensioni_max, nrmodifiche);
        Console.WriteLine(macchina.ToString());


    }


    public static void Esercizio_3()
    {
        int[] inserimento = new int[5];
        Console.WriteLine("Inserisci 5 valori");

        for (int i = 0; i < 5; i++)
        {
            int ins = int.Parse(Console.ReadLine());
            inserimento[i] = ins;
        }

        int min = inserimento.Min();
        int max = inserimento.Max();
        double avg = inserimento.Average();
        Console.WriteLine($"{min} {max} {avg}");


    }

    public static void Esercizio_4()
    {
        List<string> inserimento = new List<string>();
        Console.WriteLine("Inserisci 5 articoli");

        for (int i = 0; i < 5; i++)
        {
            inserimento.Add(Console.ReadLine());
        }

        foreach (string s in inserimento)
        {
            Console.WriteLine(s);
        }
            
        
    }

}