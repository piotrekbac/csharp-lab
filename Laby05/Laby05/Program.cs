//using System;
//using System.Collections.Generic;
//using Laby05;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Utworzenie przykładowych punktów
//        Coords point1 = new Coords(1.0, 1.0);
//        Console.WriteLine(point1);

//        Coords point2 = new Coords(1.0, 1.0);

//        if (point1.Equals(point2))
//            Console.WriteLine("Equal structs");
//        else
//            Console.WriteLine("Different structs");

//        // Z dwóch instancji struktury Coords (2 punktów na płaszczyźnie) możemy utworzyć odcinek:
//        point1 = new Coords(1.0, 1.0);
//        point2 = new Coords(2.0, 2.0);
//        Console.WriteLine($"Line start=({point1.X},{point1.Y})  Line end=({point2.X},{point2.Y})");

//        // Zadanie 1: Obliczanie długości łamanej

//        // Wczytywanie punktów
//        List<Coords> punkty = new List<Coords>();

//        Console.Write("Podaj liczbę punktów: ");
//        int n = int.Parse(Console.ReadLine());

//        Console.WriteLine("Podaj współrzędne punktów (x y):");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Punkt {i + 1} (x y): ");
//            string[] wspolrzedne = Console.ReadLine().Split();
//            double x = double.Parse(wspolrzedne[0]);
//            double y = double.Parse(wspolrzedne[1]);

//            punkty.Add(new Coords(x, y));
//        }

//        // Obliczanie długości łamanej
//        double dlugosc = DlugoscLamanej(punkty);
//        Console.WriteLine($"Długość łamanej: {dlugosc:F2}");

//    }

//    // Metoda obliczająca długość łamanej
//    public static double DlugoscLamanej(List<Coords> punkty)
//    {
//        double sumaOdleglosci = 0.0;

//        for (int i = 1; i < punkty.Count; i++)
//        {
//            sumaOdleglosci += Odleglosc(punkty[i - 1], punkty[i]);
//        }

//        return sumaOdleglosci;
//    }

//    // Funkcja obliczająca odległość między dwoma punktami
//    private static double Odleglosc(Coords p1, Coords p2)
//    {
//        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
//    }
//}

//Zadanie 1 - wg Prof 

//using System;
//using System.Collections.Generic;
//using System.Net.Http.Headers;
//using Laby05;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Utworzenie przykładowych punktów
//        Coords point1 = new Coords(1.0, 1.0);
//        Console.WriteLine(point1);

//        Coords point2 = new Coords(1.0, 1.0);

//        if (point1.Equals(point2))
//            Console.WriteLine("Equal structs");
//        else
//            Console.WriteLine("Different structs");

//        // Z dwóch instancji struktury Coords (2 punktów na płaszczyźnie) możemy utworzyć odcinek:
//        point1 = new Coords(1.0, 1.0);
//        point2 = new Coords(2.0, 2.0);
//        Coords point3 = new Coords(-1.0, 7.0);
//        Coords point4 = new Coords(9.0, 0.0);

//        Console.WriteLine($"Line start=({point1.X},{point1.Y})  Line end=({point2.X},{point2.Y})");


//        Coords[] points = { point1, point2, point3, point4 };
//        Console.WriteLine(GetDistance(points));

//        static double GetDistance(Coords[] coords)
//        {
//            double distnace = 0;

//            for (int i = 0; i < coords.Length-1; i++)
//            {
//                Coords a = coords[i]; //bierzemy np A
//                Coords b = coords[i + 1]; //przechodzimy do kolejnego elementu czyli B
//                distnace += Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
//            }
//            return distnace;
//        }
//    }
//}

//Koniec zadania 1 - wg Prof 

//Przykład tłumaczący 

//(double Sqrt, double Log)[] results = new (double Sqrt, double Log)[20];
//for (int i = 0; i < 20; i++)
//{
//    results[i] = (Math.Sqrt(i), Math.Log(i));
//}
//for (int i = 0; i < 20; i++)
//    Console.WriteLine($"int={i + 1} sqrt()={results[i].Sqrt} log()={results[i].Log}");

//Koniec przykładu tłumaczącego 

//Zadanie 2 - wg Prof 

//using System.IO.Pipes;

//(int min, int max) GetMinMax(int[] numbers)
//{
//    int min = 0;
//    int max = 0;

//    //opcja 1 
//    min = numbers.Min();
//    max = numbers.Max();

//    //opcja 2 
//    foreach (int num in numbers)
//    {
//        if (num < min) min = num;
//        if (num > max) max = num;
//    }
//    return (min, max);
//}

//Console.WriteLine(GetMinMax(new int[] { -1, 3, 5, 18, -6, 24}));

//Koniec zadania 2 - wg Prof 

//Zadanie 2 

//using System;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Przykładowa tablica liczb całkowitych
//        int[] liczby = { 12, 7, 25, 4, -3, 9, 15 };

//        // Wywołanie funkcji zwracającej parę (min, max)
//        var wynik = ZnajdzMinMax(liczby);

//        // Wyświetlenie wyników
//        Console.WriteLine($"Najmniejsza liczba: {wynik.Item1}");
//        Console.WriteLine($"Największa liczba: {wynik.Item2}");
//    }

//    // Funkcja przyjmująca tablicę liczb całkowitych i zwracająca parę (min, max)
//    public static (int, int) ZnajdzMinMax(int[] liczby)
//    {
//        // Sprawdzanie, czy tablica nie jest pusta
//        if (liczby == null || liczby.Length == 0)
//        {
//            throw new ArgumentException("Tablica nie może być pusta.");
//        }

//        // Użycie metod Min() i Max() z LINQ do znalezienia najmniejszej i największej liczby
//        int min = liczby.Min();
//        int max = liczby.Max();

//        // Zwrócenie pary (min, max)
//        return (min, max);
//    }
//}

//Koniec zadania 2 


//Zadanie 3 - wg Prof 

using Laby05;
using System;

namespace Laby05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzymy kilka instancji klasy Person
            var person1 = new Person("Jan", "Kowalski", new DateTime(2000, 5, 15));
            person1.EmailAddress = "jan.kowalski@example.com";

            var person2 = new Person("Anna", "Nowak", new DateTime(2010, 7, 22));
            person2.EmailAddress = "anna.nowak@example.com";

            // Testujemy właściwości i metody
            Console.WriteLine($"Imię i nazwisko: {person1.GetFullName()}");
            Console.WriteLine($"Email: {person1.EmailAddress}");
            Console.WriteLine($"Wiek: {person1.GetAge()}");
            Console.WriteLine($"Pełnoletni: {person1.IsAdult()}");

            Console.WriteLine();

            Console.WriteLine($"Imię i nazwisko: {person2.GetFullName()}");
            Console.WriteLine($"Email: {person2.EmailAddress}");
            Console.WriteLine($"Wiek: {person2.GetAge()}");
            Console.WriteLine($"Pełnoletni: {person2.IsAdult()}");
        }
    }
}


//Koniec zadania 3 - wg Prof 

//Zadanie 3 

//using Laby05;
//using System;

//namespace Laby05
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Tworzymy kilka instancji klasy Person
//            var person1 = new Person("Jan", "Kowalski", new DateTime(2000, 5, 15));
//            person1.EmailAddress = "jan.kowalski@example.com";

//            var person2 = new Person("Anna", "Nowak", new DateTime(2010, 7, 22));
//            person2.EmailAddress = "anna.nowak@example.com";

//            // Testujemy właściwości i metody
//            Console.WriteLine($"Imię i nazwisko: {person1.GetFullName()}");
//            Console.WriteLine($"Email: {person1.EmailAddress}");
//            Console.WriteLine($"Wiek: {person1.GetAge()}");
//            Console.WriteLine($"Pełnoletni: {person1.IsAdult()}");

//            Console.WriteLine();

//            Console.WriteLine($"Imię i nazwisko: {person2.GetFullName()}");
//            Console.WriteLine($"Email: {person2.EmailAddress}");
//            Console.WriteLine($"Wiek: {person2.GetAge()}");
//            Console.WriteLine($"Pełnoletni: {person2.IsAdult()}");
//        }
//    }
//}

//Koniec zadania 3 