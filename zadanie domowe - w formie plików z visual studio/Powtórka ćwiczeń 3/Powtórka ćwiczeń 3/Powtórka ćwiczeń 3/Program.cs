//Przykład tłumaczący
//double Add(double a = 0.0, double b = 0.0)
//{
//    return a + b;
//}

//zadnaie 1 

//using System;
//class Program
//{
//    static double QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
//    {
//        return a * x * x + b * x + c;
//    }

//    static void Main()
//    {
//        Console.WriteLine("Wynik równania kwadratowego: " + QuadraticEquation(2.0, 1.0, 3.0, 4.0));
//    }
//}

//Koniec zadania 1 

//Przykład tłumaczący 
//int Add(int a, int b)
//{
//    return a + b;
//}
//double Add(double a, double b, double c)
//{
//    return a + b + c;
//}

//Zadanie 2

//using System;

//class Program
//{
//    static void Swap(ref double a, ref double b)
//    {
//        double temp = a;
//        a = b;
//        b = temp;
//    }

//    static void Main()
//    {
//        double x = 10;
//        double y = 20;
//        Swap(ref x, ref y);
//        Console.WriteLine($"x = {x}, y = {y}");
//    }
//}

//Koniec zadania 2 

//zadanie 3 

//using System;

//class Program
//{
//    static double Multiply(double a, double b)
//    {
//        return a * b;
//    }

//    static double Multiply(double a, double b, double c)
//    {
//        return a * b * c;
//    }

//    static double Multiply(params double[] numbers)
//    {
//       double result = 1;

//        foreach (double number in numbers)
//        {
//            result *= number;
//        }
//        return result;
//    }

//    static void Main()
//    {
//        Console.WriteLine("Multiply (2.0,3.0): " + Multiply(2.0,3.0));
//        Console.WriteLine("Multiply (2.0,3.0,4.0): " + Multiply(2.0,3.0,4.0));
//        Console.WriteLine("Multiply (2.0,3.0,4.0,5.0): " + Multiply(2.0,3.0,4.0,5.0));
//    }
//}

//Koniec zadania 3 

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

//Zadanie 4 

//using System;

//class Program
//{
//    // Definicja typu wyliczeniowego DayOfTheWeek
//    enum DayOfTheWeek
//    {
//        Monday = 1,
//        Tuesday,
//        Wednesday,
//        Thursday,
//        Friday,
//        Saturday,
//        Sunday
//    }

//    // Procedura wyświetlająca informacje o dniu tygodnia
//    static void DisplayDayInfo(DayOfTheWeek day)
//    {
//        // Wypisz nazwę dnia
//        Console.WriteLine("Day: " + day);

//        // Wypisz numer dnia
//        int dayNumber = (int)day;
//        Console.WriteLine("Day number: " + dayNumber);

//        // Sprawdź, czy to weekend, czy dzień roboczy
//        if (day == DayOfTheWeek.Saturday || day == DayOfTheWeek.Sunday)
//        {
//            Console.WriteLine("It's the weekend.");
//        }
//        else
//        {
//            Console.WriteLine("It's a workday.");
//        }
//    }

//    static void Main()
//    {
//        // Przykładowe wywołania procedury
//        DisplayDayInfo(DayOfTheWeek.Monday);
//        Console.WriteLine();
//        DisplayDayInfo(DayOfTheWeek.Saturday);
//    }
//}

//Koniec zadania 4 

//Przykład tłumaczący 
//string itemName = "eggplant";
//DateTime date = DateTime.Now;
//decimal price = 1.99m;
//Unit unit = Unit.item;
//Console.WriteLine($"On {date.Year}, the price of {itemName} was {price} per {unit}.");

//zadanie 5 

//using System.Data;

//DateTime data = DateTime.Now;
//Console.WriteLine($"Dziś mamy dzień: {data.Day}, miesiąc: {data.Month}, rok: {data.Year}, godzina: {data.Hour}, minuta: {data.Minute}, sekunda: {data.Second}, dzień tygodnia: {data.DayOfWeek} ");

//Koniec zadania 5 

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

//Zadanie 6 

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        double dzielna = 10;
//        double dzielnik = 0;
//        double wynik = Podziel(dzielna, dzielnik);
//        Console.WriteLine("Wynik: " + wynik);

//        static double Podziel(double dzielna, double dzielnik)
//        {
//            try
//            {
//                return dzielna / dzielnik;
//            }
//            catch (DivideByZeroException)
//            {
//                return 0;
//            }
//        }
//    }
//}

//Koniec zadania 6 

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

//Zadanie 7 

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Podaj nowe hasło:");
//        string password = Console.ReadLine();

//        try
//        {
//            SetYourNewPassword(password);
//            Console.WriteLine("Hasło ustawione poprawnie.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Błąd: " + ex.Message);
//        }
//    }

//    static void SetYourNewPassword(string password)
//    {
//        if (string.IsNullOrEmpty(password)) throw new ArgumentException("Hasło nie może być puste.");
//        if (password.Length < 10) throw new FormatException("Hasło musi mieć co najmniej 10 znaków.");
//        if (!password.Any(char.IsUpper)) throw new FormatException("Hasło musi zawierać wielką literę.");
//        if (!password.Any(char.IsLower)) throw new FormatException("Hasło musi zawierać małą literę.");
//        if (!password.Any(char.IsDigit)) throw new FormatException("Hasło musi zawierać cyfrę.");
//        if (!password.Any(ch => "!@#$%^&*()".Contains(ch))) throw new FormatException("Hasło musi zawierać znak specjalny.");
//    }
//}

//Koniec zadania 7

//Przykład tłumaczący

//[Serializable]
//public class InvalidDepartmentException : Exception
//{
//    public InvalidDepartmentException() : base() { }
//    public InvalidDepartmentException(string message) : base(message) { }
//    public InvalidDepartmentException(string message, Exception inner) : base(message, inner) { }
//}
