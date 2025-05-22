using System;

public class Fante : Soldato
{
    private string arma;

    public string Arma
    {
        get { return arma; }
        set { arma = value; }
    }

    public Fante(string nome, string grado, int anniServizio, string arma)
    {
        this.Nome = nome;
        this.Grado = grado;
        this.AnniServizio = anniServizio;
        this.Arma = arma;
    }

    public override void Descrizione()
    {
        Console.WriteLine("nome =  " + Nome + " grado =  " + Grado + " anni di servizio =  " + AnniServizio + " arma =  " + arma);
    }


}