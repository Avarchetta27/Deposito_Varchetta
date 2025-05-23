using System;

public class Program_1
{
    public class Veicolo
    {
        public string Targa { get; set; }

        public int rip_max { get; set; }

        public Veicolo()
        {
            Targa = "";
            rip_max = 0;
        }

        public virtual void Ripara()
        {
            Console.WriteLine("Il veicolo viene controllato.");
        }
    }

    public class Auto : Veicolo
    {

        public override void Ripara()
        {
            Console.WriteLine("Controllo olio, freni e motore dell'auto.");
        }
    }

    public class Moto : Veicolo
    {

        public override void Ripara()
        {
            Console.WriteLine("Controllo catena, freni e gomme della moto.");
        }
    }


    public class Camion : Veicolo
    {

        public override void Ripara()
        {
            Console.WriteLine("Controllo sospensioni, freni rinforzati e carico del camion.");
        }
    }
/*
    public static void Main()
{
        int credito = 5;
        const int riparazioni_massime = 3;

    List<Veicolo> veicoli = new List<Veicolo>();
        while (true)
        {
            Console.WriteLine("Menu \n1 Aggiungi un auto\n2 Aggiungi una moto \n3 Aggiungi un camion\n4 Ripara e visualizza\n5 Esci");
            string inserimento = Console.ReadLine();
            switch (inserimento)
            {
                case "1":
                    Auto auto = new Auto();
                    Console.WriteLine("Inserisci la targa dell'auto");
                    auto.Targa = Console.ReadLine();
                    veicoli.Add(auto);
                    break;

                case "2":
                    Moto moto = new Moto();
                    Console.WriteLine("Inserisci la targa della moto");
                    moto.Targa = Console.ReadLine();
                    veicoli.Add(moto);
                    break;

                case "3":
                    Camion camion = new Camion();
                    Console.WriteLine("Inserisci la targa del camion");
                    camion.Targa = Console.ReadLine();
                    veicoli.Add(camion);
                    break;

                case "4":
                    foreach (Veicolo x in veicoli)
                    {
                        if (credito > 0 && x.rip_max < riparazioni_massime)
                        {
                            Console.WriteLine($"Targa = {x.Targa} ");
                            x.Ripara();
                            credito--;
                            x.rip_max++;
                        }
                        else if (credito > 0)
                        {
                            Console.WriteLine($"Targa = {x.Targa} ");
                            Console.WriteLine("Riparazioni massime Esaurite");
                        }
                        else
                        {
                            Console.WriteLine($"Targa = {x.Targa} ");
                            Console.WriteLine("Credito insufficiente");
                        }
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
*/
}