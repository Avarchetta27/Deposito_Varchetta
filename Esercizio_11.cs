using System;

public class Program_6
{
    public class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int AnnoImmatricolazione { get; set; }

        public virtual void StampaInfo()
        {
            Console.WriteLine($"{Marca} {Modello} - Anno: {AnnoImmatricolazione}");
        }
    }

    public class AutoAziendale : Veicolo
    {
        public string Targa { get; set; }
        public bool UsoPrivato { get; set; }

        public override void StampaInfo()
        {
            Console.WriteLine($"{Marca} {Modello} - Anno: {AnnoImmatricolazione} - Targa: {Targa} - Uso Privato: {(UsoPrivato ? "Sì" : "No")}");
        }
    }

    public class FurgoneAziendale : Veicolo
    {
        public int CapacitaCarico { get; set; }

        public override void StampaInfo()
        {
            Console.WriteLine($"{Marca} {Modello} - Anno: {AnnoImmatricolazione} - Capacità di carico: {CapacitaCarico} kg");
        }
    }

    public class Program_5
    {
        public static void Main()
        {
            List<Veicolo> veicoli = new List<Veicolo>();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Aggiungi un'Auto Aziendale");
                Console.WriteLine("2. Aggiungi un Furgone Aziendale");
                Console.WriteLine("3. Visualizza veicoli");
                Console.WriteLine("4. Esci");
                Console.Write("Scelta: ");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        AutoAziendale auto = new AutoAziendale();
                        Console.Write("Marca: ");
                        auto.Marca = Console.ReadLine();
                        Console.Write("Modello: ");
                        auto.Modello = Console.ReadLine();
                        Console.Write("Anno di immatricolazione: ");
                        auto.AnnoImmatricolazione = int.Parse(Console.ReadLine());
                        Console.Write("Targa: ");
                        auto.Targa = Console.ReadLine();
                        Console.Write("Uso privato (si/no): ");
                        string conferma = Console.ReadLine().ToLower();
                        auto.UsoPrivato = (conferma == "si");
                        veicoli.Add(auto);
                        break;

                    case "2":
                        FurgoneAziendale furgone = new FurgoneAziendale();
                        Console.Write("Marca: ");
                        furgone.Marca = Console.ReadLine();
                        Console.Write("Modello: ");
                        furgone.Modello = Console.ReadLine();
                        Console.Write("Anno di immatricolazione: ");
                        furgone.AnnoImmatricolazione = int.Parse(Console.ReadLine());
                        Console.Write("Capacità di carico (kg): ");
                        furgone.CapacitaCarico = int.Parse(Console.ReadLine());
                        veicoli.Add(furgone);
                        break;

                    case "3":
                        Console.WriteLine("\n--- Veicoli Registrati ---");
                        foreach (Veicolo v in veicoli)
                        {
                            v.StampaInfo();
                        }
                        break;

                    case "4":
                        Console.WriteLine("Chiusura programma.");
                        return;

                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            }
        }
    }

}