using System;

public class Program
{
    public class Veicolo
    {
        public string marca;
        public string modello;


        public virtual void StampaInfo()
        {
            Console.WriteLine(marca  + " " +  modello);
        }

    }


    public class Moto : Veicolo
    {
        public string TipoManubrio;

        public Moto(string marca, string modello, string TipoManubrio)
        {
            this.marca = marca;
            this.modello = modello;
            this.TipoManubrio = TipoManubrio;
        }

        public override void StampaInfo()
        {
            Console.WriteLine(marca + " "+ modello + " "+TipoManubrio);
        }
    }


    public class Auto : Veicolo
    {
        public int numero_porte;


        public Auto(string marca, string modello, int numero_porte)
        {
            this.marca = marca;
            this.modello = modello;
            this.numero_porte = numero_porte;
        }


        public override void StampaInfo()
        {
            Console.WriteLine(marca + " " + modello + " "  + numero_porte);
        }



    }

    public static void Main(string[] args)
    {
        List<Veicolo> garage = new List<Veicolo>();
        while (true)
        {
            Console.WriteLine("Menu\n1 Inserisci un auto\n2 Inserisci una moto\n3 visualizza tutti i veicolo del garage\n4 Esci");
            string inserimento = Console.ReadLine();

            switch (inserimento)
            {
                case "1":
                    Auto auto = new Auto("","",0);
                    Console.WriteLine("Inserisci la marca");
                    auto.marca = Console.ReadLine();
                    Console.WriteLine("Inserisci il modello");
                    auto.modello = Console.ReadLine();
                    Console.WriteLine("Inserisci il numero di porte");
                    auto.numero_porte = int.Parse(Console.ReadLine());
                    garage.Add(auto);
                    break;

                case "2":
                    Moto moto = new Moto("","","");
                    Console.WriteLine("Inserisci la marca");
                    moto.marca = Console.ReadLine();
                    Console.WriteLine("Inserisci il modello");
                    moto.modello = Console.ReadLine();
                    Console.WriteLine("Inserisci il tipo di manubrio");
                    moto.TipoManubrio =Console.ReadLine();
                    garage.Add(moto);
                    break;

                case "3":
                    foreach (Veicolo x in garage)
                    {
                        x.StampaInfo();
                    }
                    break;

                case "4":
                    break;

                default:
                    Console.WriteLine("Inserimento errato");
                    break;

            }
            if (inserimento == "4")
                break;

        }

    }


}