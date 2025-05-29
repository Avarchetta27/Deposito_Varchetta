using System;


public interface IShape
{
    void Draw();
}



public class ConcreteCircle : IShape
{
    public  void Draw()
    {
        Console.WriteLine("Disegno un cerchio");
    }

}

public class ConcreteSquare : IShape
{
    public void Draw()
    {
        Console.WriteLine("Disegno un quadrato");
    }

}

public abstract class ShapeCreator
{
    public abstract IShape CreateShape();
}

public class ConcreteShapeCreatorCircle : ShapeCreator
{
    public override IShape CreateShape()
    { 
    return new ConcreteCircle();
    }
}

public class ConcreteShapeCreatorSquare : ShapeCreator
{
    public override IShape CreateShape()
    {
        return new ConcreteSquare();
    }
}

public class Program_7
{
    public static void Main()
    {
        Console.WriteLine("Quale figura vuoi disegnare : Cerchio o Quadrato? ");
        string inserimento = Console.ReadLine();
        ShapeCreator x;
        switch (inserimento.ToLower())
        {
            case "cerchio":
                x = new ConcreteShapeCreatorCircle();
                break;

            case "quadrato":
                x = new ConcreteShapeCreatorSquare();
                break;


            default:
                Console.WriteLine("Inserimento errato");
                return;


        }
        
        IShape shape = x.CreateShape();
        shape.Draw();
        }
    }

