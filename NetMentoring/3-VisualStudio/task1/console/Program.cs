using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        
        Console.Write("Введите ваше имя: ");
        string userName = Console.ReadLine();
        
        Console.WriteLine($"Hello {userName{} !");
    }
}  