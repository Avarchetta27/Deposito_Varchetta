using System;

public class Program
{
    public class Operatore
    {
        private string nome;
        private string turno;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Turno
        {
            get { return turno; }
            set
            {
                if (value.ToLower() == "notte" || value.ToLower() == "giorno")
                    turno = value;
            }
        }

        public virtual void EseguiCompito()
        {
            Console.WriteLine("Operatore generico in servizio.");
        }
    }

    public class OperatoreEmergenza : Operatore
    {
        private int livelloUrgenza;

        public int LivelloUrgenza
        {
            get { return livelloUrgenza; }
            set {
                if (value > 0 && value <= 5)
                 livelloUrgenza = value; }
        }

        public override void EseguiCompito()
        {
            Console.WriteLine($"Gestione emergenza di livello {LivelloUrgenza}");
        }

        public override string ToString()
        {
            return $"{Nome} {Turno} Operatore Emergenze";
        }


    }


    public class OperatoreSicurezza : Operatore
    {
        private string areaSorvegliata;

        public string AreaSorvegliata
        {
            get { return areaSorvegliata; }
            set { areaSorvegliata = value; }
        }

        public override void EseguiCompito()
        {
            Console.WriteLine($"Sorveglianza dell'area {AreaSorvegliata}");
        }

        public override string ToString()
        {
            return $"{Nome} {Turno} Operatore Sicurezza";
        }


    }



    public class OperatoreLogistica : Operatore
    {
        private int numeroConsegne;

        public int NumeroConsegne
        {
            get { return numeroConsegne; }
            set {
                if (value >= 0)
                    numeroConsegne = value; }
        }

        public override void EseguiCompito()
        {
            Console.WriteLine($"Coordinamento di {NumeroConsegne} consegne");
        }


        public override string ToString()
        {
            return $"{Nome} {Turno} Operatore Logistica";
        }


    }
    


    public static void Main()
{
        int credito = 5;
        const int riparazioni_massime = 3;

    List<Operatore> operatori = new List<Operatore>();
        while (true)
        {
            Console.WriteLine("Menu \n1 Aggiungi un Operatore Sicurezza\n2 Aggiungi un Operatore Logistica \n3 Aggiungi un Operatore Emergenza\n4 Visualizza\n5 Esci");
            string inserimento = Console.ReadLine();
            switch (inserimento)
            {
                case "1":
                    OperatoreSicurezza operatoreS = new OperatoreSicurezza();
                    Console.WriteLine("Inserisci il nome dell'operatore");
                    operatoreS.Nome = Console.ReadLine();
                    Console.WriteLine("Inserisci il turno dell'operatore");
                    operatoreS.Turno = Console.ReadLine();
                    Console.WriteLine("Inserisci l'area sorvegliata");
                    operatoreS.AreaSorvegliata = Console.ReadLine();
                    operatori.Add(operatoreS);
                    break;

                case "2":
                    OperatoreLogistica operatoreL = new OperatoreLogistica();
                    Console.WriteLine("Inserisci il nome dell'operatore");
                    operatoreL.Nome = Console.ReadLine();
                    Console.WriteLine("Inserisci il turno dell'operatore");
                    operatoreL.Turno = Console.ReadLine();
                    Console.WriteLine("Inserisci il numero di consegne");
                    operatoreL.NumeroConsegne = int.Parse(Console.ReadLine());
                    operatori.Add(operatoreL);
                    break;

                case "3":
                    OperatoreEmergenza operatoreE = new OperatoreEmergenza();
                    Console.WriteLine("Inserisci il nome dell'operatore");
                    operatoreE.Nome = Console.ReadLine();
                    Console.WriteLine("Inserisci il turno dell'operatore");
                    operatoreE.Turno = Console.ReadLine();
                    Console.WriteLine("Inserisci il livello di emergenza");
                    operatoreE.LivelloUrgenza = int.Parse(Console.ReadLine());
                    operatori.Add(operatoreE);
                    break;

                case "4":
                    foreach (Operatore x in operatori)
                    {
                        Console.WriteLine(x.ToString());
                        x.EseguiCompito();
                    } 

                    

                    


                    break;

                case "5":
                    break;

                default:
                    Console.WriteLine("Operazione non valida");
                    break;
            }
            if (inserimento == "5")
                break;
        }
}
}