// 1, Olvassunk kódot!
// 2, Ismerjük fel milyen tervezési mintát láthatunk a kódban?

using System;

public class Shape : ICloneable
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Shape(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public object Clone()
    {
        return new Shape(Width, Height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape originalShape = new Shape(10, 20);
        Shape clonedShape = (Shape)originalShape.Clone();

        clonedShape.Width = 15;
        clonedShape.Height = 25;

        Console.WriteLine("Original Shape: Width = {0}, Height = {1}", originalShape.Width, originalShape.Height);
        Console.WriteLine("Cloned Shape: Width = {0}, Height = {1}", clonedShape.Width, clonedShape.Height);
    }
}