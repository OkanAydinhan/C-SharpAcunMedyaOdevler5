using Odev2;

public class Program
{
    public static void Main()
    {
        Matematik mat = new Matematik();

        Console.WriteLine("Toplama İşlemleri:");
        Console.WriteLine(mat.Topla(5, 10));
        Console.WriteLine(mat.Topla(5, 10, 15));
        Console.WriteLine(mat.Topla(5, 10, 15, 20));
        Console.WriteLine(mat.Topla(5.5, 10.3));
        Console.WriteLine(mat.Topla(5.5, 10.3, 2.2));
        Console.WriteLine(mat.Topla(5.5, 10.3, 2.2, 1.1));

        Console.WriteLine("Çarpma İşlemleri:");
        Console.WriteLine(mat.Carp(5, 10));
        Console.WriteLine(mat.Carp(5, 10, 2));
        Console.WriteLine(mat.Carp(5, 10, 2, 3));
        Console.WriteLine(mat.Carp(5.5, 10.3));
        Console.WriteLine(mat.Carp(5.5, 10.3, 2.2));
        Console.WriteLine(mat.Carp(5.5, 10.3, 2.2, 1.1));
    }
}