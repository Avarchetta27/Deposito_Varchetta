using System;

public class Libro
{
    string titolo;
    string autore;
    int anno_pubblicazione;

    public Libro(string titolo, string autore, int anno_pubblicazione)
    {
        this.anno_pubblicazione = anno_pubblicazione;
        this.titolo = titolo;
        this.autore = autore;
    }

    public override string ToString()
    {
        return $"{titolo} di {autore} {anno_pubblicazione}";
    }

    public override bool Equals(object x)
    {
        if (x is Libro y)
        {
            return (this.autore == y.autore && this.titolo == y.titolo);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(titolo, autore);
    }

    


    public static void Main()
    {
        Libro libro = new Libro("One Piece - capitolo 1049", "Eichiro Oda", 2025);
        Libro libro1 = new Libro("One Piece - capitolo 1048", "Eichiro Oda", 2024);
        Libro libro2 = libro1;
        Console.WriteLine(libro.ToString());
        Console.WriteLine(libro1.ToString());
        if (libro.Equals(libro1))
            Console.WriteLine("I volumi sono uguali");
        else
            Console.WriteLine("I volumi sono diversi");

        if (libro.GetHashCode() == libro1.GetHashCode() && libro.GetType() == typeof(int)
        && libro1.GetType() == typeof(int))
            Console.WriteLine($"Hash code uguali {libro.GetHashCode()} = {libro1.GetHashCode()}");
        else
            Console.WriteLine($"Hash code diversi {libro.GetHashCode()} = {libro1.GetHashCode()}");

        if (ReferenceEquals(libro2,libro1))
            Console.WriteLine("L'oggetto è lo stesso");
        else
            Console.WriteLine("L'oggetto è diverso");

        Libro libro4 = (Libro)libro.MemberwiseClone();
        Console.WriteLine(libro4.ToString());
        //finalize();
    }



}