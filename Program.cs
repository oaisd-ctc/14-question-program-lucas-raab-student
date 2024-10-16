
using System;


public class Program
{
    public static string Name;
    public static int age;
    public static string eye;
    public static string Hair;
    public static int Shoe;
    public static string Color;
    public static string Show;
    public static string Teacher;
    public static string Class;
    public static string Holiday;
    public static string season;
    public static string Job;
    public static string Siblings;
    static int ageIn5Years;


    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(age);
        AskNumberOfSiblings();
        DisplaySummaryMessage();


    }
    public static void AskName()
    {
        Console.WriteLine(" What is your name");
        Name = Console.ReadLine();
    }
    public static void AskAge()
    {
        Console.WriteLine(" What is your age? ");
         age = int.Parse(Console.ReadLine());
    }
    public static void AskEyeColor()
    {
        Console.WriteLine("What is your eye color");
         eye = Console.ReadLine();
    }
    public static void AskHairColor()
    {
        Console.WriteLine(" What is your hair color");
        Hair = Console.ReadLine();
    }
    public static void AskFavoriteTvShow()
    {
        Console.WriteLine("What is your favorite show");
         Show = Console.ReadLine();
    }
    public static void AskShoeSize()
    {
        Console.WriteLine(" What is your shoe size");
         Shoe = int.Parse(Console.ReadLine());
    }
    public static void AskFavoriteColor()
    {
        Console.WriteLine(" What is your favorite color");
         Color = Console.ReadLine();
    }

    public static void AskFavoriteTeacher()
    {
        Console.WriteLine("who is your favorite teacher");
        Teacher = Console.ReadLine();
    }
    public static void AskFavoriteClass()
    {
        Console.WriteLine("what is your favorite class");
         Class = Console.ReadLine();
    }
    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("Favorite holiday");
         Holiday = Console.ReadLine();
    }

    public static void AskFavoriteSeason()
    {

        Console.WriteLine("What is your favorite season");
         season = Console.ReadLine();
    }
    public static void AskDreamJob()
    {
        Console.WriteLine(" what is your Dream job");
        Job = Console.ReadLine();
    }

    public static void CalculateAgeIn5Years(int age)
    {
        ageIn5Years = (age) + 5;
    }
    public static void AskNumberOfSiblings()
    {
        Console.WriteLine(" how many siblings do you have");
        Siblings = Console.ReadLine();
    }
    public static void DisplaySummaryMessage()
    {
        Console.WriteLine("My freinds name is " + Name + ". " + Name + " is " + age + " years old. "
            + Name + " eye color is " + eye + " , his hair color is " + Hair + " they also has a shoe size of " + Shoe +
            " anthor instesting fact about them is there favorite color is " + Color + " Anthor intresting fact is " + Show + " there favorite show" +
         " one cool thing about them is that " + Teacher + " is there favorite Teacher " + " also there favorite class is " + Class +
         " something i would have never gussed " + Holiday + " is there favorite holiday. " + " also there favorite season is " + season +
         " one thing that is really cool is that " + Job + " is there dream job " + " there age will be " + ageIn5Years + " in 5 years "
         + " and they have " + Siblings + " siblings ");

    }



}


