using System;

public class Main_Soldato
{

    public static void Main()
    {

        List<Soldato> soldati = new List<Soldato>();
        while (true)
        {
            Console.WriteLine("Menu \n1 Aggiungere un nuovo Fante\n2 Aggiungere un nuovo Artigliere \n3 Visualizza tutto\n4 esci");
            string inserimento = Console.ReadLine();
            int i = 0;
            switch (inserimento)
            {
                case "1":
                    Fante fante = new Fante("Fantino", "Master", 5, "Mazza");
                    soldati.Add(fante);
                    break;

                case "2":
                    Artigliere artigliere = new Artigliere("Artigliere","Mega", 4,8);
                    soldati.Add(artigliere);
                    break;

                case "3":
                    foreach (Soldato x in soldati)
                    {
                        x.Descrizione();
                    }

                    break;

                case "4":
                    break;

                default:
                    Console.WriteLine("Operazione non valida");
                    break;
            }
            if (inserimento == "4")
                break;
        }
    }

}