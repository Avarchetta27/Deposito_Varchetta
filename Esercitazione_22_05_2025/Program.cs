public class ContoBancario
{

    private double saldo;
    public double Saldo {

        get
        {
            return saldo;
        }

        set {
            if (value >= 0)
                saldo = value;
        }
    }


    public class Programma
    {


    /*public static void Main()
        {
            ContoBancario conto = new ContoBancario();
            conto.Saldo = 1000.50;
            Console.WriteLine(conto.Saldo);
            conto.Saldo = -500;
            Console.WriteLine(conto.Saldo);
        }*/
    }
}
