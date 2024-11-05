//Przykład tłumaczący

//double Add(double a = 0.0, double b = 0.0)
//{
//    return a + b;
//}

//Zad1 

//static double QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
//{
//    return x * x * a + b * x + c;
//}

//Console.WriteLine("Wartość równania kwadratowego (2.0,3.0,1.0): " + QuadraticEquation(2.0, 3.0, 1.0));

//Koniec Zad1

//Przykład tłumaczący 

//int Add(int a, int b)
//{
//    return a + b;
//}

//double Add(double a, double b, double c)
//{
//    return a + b + c;
//}

//Zad2 

//using System; 

//class Program
//{ 
//    static void Main()
//    {
//        void Swap(ref double a, ref double b)
//        {
//            double temp = a;
//            a = b;
//            b = temp;
//        }
//        double x = 10;
//        double y = 20;
//        Swap(ref x,ref y);
//        Console.WriteLine($"x = {x}, y = {y}");
//    }

//}

//Koniec Zad2 

//Przykład tłumaczący 
//enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}

//enum ErrorCode : ushort
//{
//    None = 0,
//    Unknown = 1,
//    ConnectionLost = 100,
//    OutlierReading = 200
//}


//Zad3

//using System;

//class Program
//{

//    public static class Multiplier
//    {



//        static double Multiply(double a, double b)
//        {
//            return a * b;
//        }

//        static double Multiply(double a, double b, double c)
//        {
//            return a * b * c;
//        }

//        static double Multiply(params double[] a)
//        {
//            double result = 1.0;
//            foreach (double x in a)
//            {
//                result *= x;
//            }
//            return result;
//        }
//    }
//}

//Koniec Zad3
//Zad4 

//using System;
//using System.Linq.Expressions;

//class Program
//{
//    static void Main()
//    {
//        PrintDayOfTheWeek(DayOfTheWeek.Monday);
//        PrintDayOfTheWeek(DayOfTheWeek.Sunday);

//    }
//    enum DayOfTheWeek
//    {
//        Monday = 1,
//        Tuesday = 2,
//        Wednesday = 3,
//        Thursday = 4,
//        Friday = 5,
//        Saturday = 6,
//        Sunday = 7,
//    }

//    static void PrintDayOfTheWeek(DayOfTheWeek day)
//    {

//        Console.WriteLine(day);
//        Console.WriteLine((int)day);
//        if ((int)day == 6 || (int)day == 7)
//        {
//            Console.WriteLine("It's the weekend");
//        }
//        else
//        {
//            Console.WriteLine("It's the workday");
//        }
//    }
//}


//Koniec Zad4 

//Przykład tłumaczący 

//string itemName = "eggplant";
//DateTime date = DateTime.Now;
//decimal price = 1.99m;
//Unit unit = Unit.item;
//Console.WriteLine($"On {date.Year}, the price of {itemName} was {price} per {unit}.");

//Zad 5 

//DateTime date = DateTime.Now;

//Console.WriteLine($"Nasze dane z daty: Dzień: {date.Day}, Miesiąc: {date.Month}, Rok: {date.Year}, Godzina: {date.Hour}, Minuta: {date.Minute}, Sekunda: {date.Second}, Dzień tygodnia: {date.DayOfWeek}");


//Koniec Zad5 

//Przykład tłumaczący 

//try
//{
//    // Code to try goes here.
//}
//catch (SomeSpecificException ex)
//{
//    // Code to handle the specific exception goes here.
//}
//catch (Exception ex)
//{
//    // Code to handle all other exceptions goes here.
//}
//finally
//{
//    // Code to execute after the try (and possibly catch) blocks
//    // goes here.
//}

//Zad 6 

//using System;

//class Program
//{
//    static void Main()
//    {
//        double dzielna = 10;
//        double dzielnik = 5;
//        double wynik = dzielna / dzielnik;
//        Console.WriteLine("Wynik:" + wynik);

//    }

//    static double Wynik(double dzielna, double dzielnik)
//    {
//        try
//        {
//            return dzielna / dzielnik; 
//        }

//        catch(Exception e)
//        {
//            Console.WriteLine("Błąd: " + e.Message);
//            return 0;
//        }
//        finally
//        {
//            Console.WriteLine("Wynik naszego dzielenia wynosi: ");
//        }
//    }
//}


//Koniec Zad6

//Przykład tłumaczący 

//bool CheckTheAge(int age)
//{
//    if (age < 0)
//        throw new ArgumentOutOfRangeException("Age can not be a negative number!");
//    if (age >= 18)
//        return true;
//    else
//        return false;
//}

//Zad7 



using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wpisz nowe hasło: ");
        string password = Console.ReadLine();

        try
        {
            ValidePassword(password);

            SetYourNewPassword(password);

        }

        catch (Exception ex)
        {
            Console.WriteLine("Błąd: " + ex.Message);
        }

        static void ValidePassword(string password)
        {
            {
                if (string.IsNullOrEmpty(password)) throw new ArgumentException("Hasło nie może być puste, musi zawierać jakieś znaki");
                if (password.Length < 10) throw new FormatException("Hasło musi mieć więcej niż 10 znaków");
                if (!password.Any(char.IsUpper)) throw new FormatException("Hasło musi zawierać w sobie jedną dużą literę");
                if (!password.Any(char.IsLower)) throw new FormatException("Hasło musi zawierać w sobie jedną małą literę");
                if (!password.Any(char.IsDigit)) throw new FormatException("Hasło musi zawierać w sobie liczbę");
                if (!password.Any(ch => "!@#$%^&*()".Contains(ch))) throw new FormatException("Hasło musi zawierać specjalny znak");
            }
        }

        static void SetYourNewPassword(string password)
        {
            Console.WriteLine("Hasło ustawione pomyślnie!");
        }
    }
}

//Koniec Zad7


//Przykład tłumaczący 

//[Serializable]
//public class InvalidDepartmentException : Exception
//{
//    public InvalidDepartmentException() : base() { }
//    public InvalidDepartmentException(string message) : base(message) { }
//    public InvalidDepartmentException(string message, Exception inner) : base(message, inner) { }
//}

//zad 13 (z pierwszych labów - równanie kwadratowe)

//double[] QuadricFun(int a, int b, int c)
//{
//    // AX + BX + C
//    //Obliczanie Delty

//    return new double[2];
//}