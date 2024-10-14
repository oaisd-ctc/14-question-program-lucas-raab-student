
using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" What is your name");
        string Name = Console.ReadLine();
        Console.WriteLine(" What is your age? ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine(" What is your hair color");
        string Hair = Console.ReadLine();
        Console.WriteLine("What is your eye color");
        string eye = Console.ReadLine();
        Console.WriteLine(" What is your shoe size");
        int Shoe = int.Parse( Console.ReadLine());
        Console.WriteLine(" What is your favorite color");
        string Color = Console.ReadLine();
        Console.WriteLine("What is your favorite show");
        string Show = Console.ReadLine();
        Console.WriteLine("who is your favorite teacher");
        string Teacher = Console.ReadLine();
        Console.WriteLine("what is your favorite class");
        string Class = Console.ReadLine();
        Console.WriteLine("Favorite holiday");
        string Holiday = Console.ReadLine();
        Console.WriteLine("What is your favorite season");
        string season = Console.ReadLine();
        Console.WriteLine(" what is your Dream job");
        string Job = Console.ReadLine();
        int future = age + 5;
        Console.WriteLine(" how many siblings do you have");
        string Siblings = Console.ReadLine();
        Console.WriteLine("My freinds name is " + Name + ". " + Name + " is " + age + " years old. "
        + Name + " eye color is " + eye + " , his hair color is " + Hair + " they also has a shoe size of " + Shoe + 
        " anthor instesting fact about them is there favorite color is " + Color + " Anthor intresting fact is " + Show + " there favorite show" +
     " one cool thing about them is that " + Teacher + " is there favorite Teacher " + " also there favorite class is " + Class +
     " something i would have never gussed " + Holiday + " is there favorite holiday. " + " also there favorite season is " + season + 
     " one thing that is really cool is that " + Job + " is there dream job " + " there age will be " + future + " in 5 years "
     + " and they have " + Siblings + " siblings ");





    }
}

