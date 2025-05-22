using System;

public class Artigliere : Soldato
{
    private int calibro;

    public Artigliere(string nome, string grado, int anniServizio, int calibro)
    {
        this.Nome = nome;
        this.Grado = grado;
        this.AnniServizio = anniServizio;
        this.Calibro = calibro;
    }

    public int Calibro
    {
        get { return calibro; }
        set { calibro = value; }
    }

    public override void Descrizione()
    {
        Console.WriteLine("nome =  " + Nome + " grado =  " + Grado + " anni di servizio =  " + AnniServizio + " calibro =  " + calibro);
    }


}