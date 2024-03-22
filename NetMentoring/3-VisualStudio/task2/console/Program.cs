using System;
using System.Text;
using HelloLib;


public class Program
{
    public static void Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.Write("Введите ваше имя: ");
        string userName = Console.ReadLine();

        Hello somevar = new Hello();
        string greeting = somevar.GetGreeting(userName);
        Console.WriteLine(greeting);
    }
}