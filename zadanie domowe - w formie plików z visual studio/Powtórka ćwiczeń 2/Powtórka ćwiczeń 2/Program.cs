﻿//PRZYKŁAD TŁUMACZĄCY 
//int n = 0;
//do
//{
//    Console.WriteLine(n);
//    n++;
//}while (n < 5);
////otrzymujmy: 01234

//// zadanie 1 
//int n = 10;
//do
//{
//    Console.WriteLine(n);
//    n--;
//} while (n > -1);
//// koniec zadania 1 

// zadanie 2 
//using System.Threading.Channels;

//string haslo;
//do
//{
//    Console.WriteLine("Podaj hasło: ");
//    haslo = Console.ReadLine();

//} while (haslo != "koniec");
//Console.WriteLine("Zakończenie programu");

//// koniec zadania 2 

//PRZYKŁAD TŁUMACZĄCY 
//int n = 0;
//while (n < 5)
//{
//    Console.Write(n);
//    n++;
//}

//// zadanie 3 
//int n = 1; 

//while (n <= 100)
//{
//    if (n % 2 == 0)
//    {
//        Console.WriteLine(n);
//    }
//    n++;
//}
//// konie zadania 3 

////PRZYKŁAD TŁUMACZĄCY 
//for (int i =0; i < 3; i++)
//{
//    Console.WriteLine(i);
//}
////OTRZYMUJEMY: 012 

//// zadanie 4 
//for (int i = 1; i < 16; i++)
//{
//    Console.WriteLine(i * i);
//}
//// koniec zadania 4 

//PRZYKŁAD TŁUMACZĄCY 

//List<int> fibNumbers = new() { 0, 1, 1, 2, 3, 5, 8, 13 };
//foreach (int element in fibNumbers)
//{
//    Console.WriteLine($"{element} ");
//}
////OTRZYMUJEMY: 0 1 1 2 3 5 8 13 

//// zadanie 5 

//List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };
//foreach (int number in numbers)
//{
//    Console.WriteLine(number % 7 == 0);
//}

//// koniec zadania 5 

// zadanie 6 

//List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };
//foreach (int number in numbers)
//{
//    Console.WriteLine(number % 7 == 0);
//    break;
//}

// koniec zadania 6 

//PRZYKŁAD TŁUMACZĄCY 

//< typ > [] < identyfikator >;
//int[] intArray;
//bool[] boolArray;
//double[] doubleArray;
//int[] intArray = { 1, 2, 3, 4, 5 };
//bool[] boolArray = { true, false };
//double[] doubleArray {1.2, 2.4, 4.0, 5.7};
//int[] intArray = new int[5];
//intArray[0] = 4;                                    // przypisanie do komórki 0
//int sumOfTwoItems = intArray[0] + intArray[1];      // odczyt komórki 0 i 1

// zadanie 7 
//double[] tablicaDouble = new double[20];

//for (int i = 0; i < 20; i++)
//{
//    tablicaDouble[i] = Math.Sqrt(i + 1);
//    Console.WriteLine(tablicaDouble[i]);
//}
// koniec zadania 7 

//PRZYKŁAD TŁUMACZĄCY 
//char[,] matrix = new char[3, 3];
//int[,] cooficients = { { 1, 2 }, { 2, 3 }, { 4, 6 } };
//int columns = cooficients.GetLength(0);
//int rows = cooficients.GetLength(1);
//matrix[0, 0] = 'O';
//matrix[0, 1] = 'O';
//matrix[0, 2] = 'X';
//matrix[1, 0] = 'O';
//matrix[1, 1] = 'O';
//matrix[1, 2] = 'O';
//matrix[2, 2] = 'X';

//zadanie 8 

//int[,] macierz = new int[3, 4];

//int liczba = 1;
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        macierz[i, j] = liczba++;
//    }
//}
//Console.WriteLine("Macierz po transpozycji: ");

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        Console.WriteLine(macierz[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//koniec zadania 8 

//PRZYKŁAD TŁUMACZĄCY 
//int[][] jaggedArray = new int[3][];

//jaggedArray[0] = [1, 3, 5, 7, 9];
//jaggedArray[1] = [0, 2, 4, 6];
//jaggedArray[2] = [11, 22];

//public static < typ - zwracany > < nazwa - funkcji > (< lista - parametrów >)
//{
//    < lista - deklaracji - zmiennych >
//    < lista - instrukcji >
//}

//public static void PrintMessage()
//{
//    Console.WriteLine("Hello");
//}
//PrintMessage();
//public static void PrintMessage(int n)
//{
//    for (int i = 0; i < n; i++)
//    {
//        Console.WriteLine("Hello");
//    }
//}
//int count = 6;
//PrintMessage(5);
//PrintMessage(count);

// zadanie 9 

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Przykładowe użycie procedury
//        string tekst = "to jest przykładowy tekst";
//        WypiszWielkimiLiterami(tekst);
//    }

//    // Definicja procedury
//    static void WypiszWielkimiLiterami(string tekst)
//    {
//        // Wypisanie tekstu wielkimi literami
//        Console.WriteLine(tekst.ToUpper());
//    }
//}

// koniec zadania 9

// zadanie 10

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Przykładowe wywołanie procedury
//        int x = 3; // liczba wierszy
//        int y = 4; // liczba kolumn
//        ZbudujIMacierz(x, y);
//    }

//    // Definicja procedury
//    static void ZbudujIMacierz(int x, int y)
//    {
//        // Deklaracja macierzy o wymiarach X na Y
//        char[,] macierz = new char[x, y];

//        // Wypełnianie macierzy znakami '$'
//        for (int i = 0; i < x; i++)
//        {
//            for (int j = 0; j < y; j++)
//            {
//                macierz[i, j] = '$';
//            }
//        }

//        // Wyświetlanie macierzy
//        for (int i = 0; i < x; i++)
//        {
//            for (int j = 0; j < y; j++)
//            {
//                Console.Write(macierz[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

// koniec zadania 10 

//PRZYKŁAD TŁUMACZĄCY
//public static double Add(double a, double b)
//{
//    return a + b;
//}
//public static int FindFirstZeros(double[] x)
//{
//    for (int i = 0; i < x.Length; i++)
//    {
//        if (x[i] == 0)
//        {
//            return i;
//        }
//    }
//    return -1;
//}
//public static double Add(double a, double b)
//{
//    return a + b;
//}

//public static int FindFirstZeros(double[] x)
//{
//    for (int i = 0; i < x.Length; i++)
//    {
//        if (x[i] == 0)
//        {
//            return i;
//        }
//    }
//    return -1;
//}
//double factor = 1.5;
//if (Add(factor, 4) > 5)
//{
//    Console.WriteLine("Suma większa od 5");
//}
//Copy
//double a = 5.8;
//double b = 1.4;
//double result = Add(a, b) * a - b;
//Copy
//double[] arr = { Add(2, Add(3, 6)), 5, 7, 0, Add(1, 4) - 5 };
//int index = FindFirstZeros(arr);
//if (index > -1)
//{
//    Console.WriteLine($"First zero at {index}.");
//}
//else
//{
//    Console.WriteLine("No zeros!");
//}
//Add(a, b);

// zadanie 11

//using System;

//class Program
//{
//    static void Main()
//    {
//        int liczba = 5;
//        string wynik = Sprawdzparzystosc(liczba);
//        Console.WriteLine($"Liczba {liczba} jest: {wynik}");
//    }

//    static string Sprawdzparzystosc(int liczba)
//    {
//        return (liczba % 2 == 0) ? "Even" : "Odd";
//    }
//}

// koniec zadania 11

// zadanie 12

//using System;
//using System.ComponentModel;

//class Program
//{
//    static void Main()
//    {
//        int n = WczytajZKlawiatury("Podaj liczbę wierszy (n): ");
//        int m = WczytajZKlawiatury("Podaj liczbę kolumn (m): ");

//        char[,] tablica = WypelnijTablice(n, m);

//        WyswietlTabliceNaEkranie(tablica);
//    }

//    static int WczytajZKlawiatury(string IloscLiczbDoWczytania)
//    {
//        Console.Write(IloscLiczbDoWczytania);
//        return int.Parse(Console.ReadLine());
//    }

//    static char[,] WypelnijTablice(int n, int m)
//    {
//        char[,] tablica = new char[n, m];

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
//                {
//                    tablica[i, j] = '#';
//                }
//                else
//                {
//                    tablica[i, j] = ' ';
//                }
//            }
//        }

//        return tablica;

//    }

//    static void WyswietlTabliceNaEkranie(char[,] tablica)
//    {
//        int n = tablica.GetLength(0);
//        int m = tablica.GetLength(1);

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write(tablica[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

// koniec zadania 12 

//zadanie 13 


using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 1;
        double b = -3;
        double c = 2;

        double[] rozwiązania = RozwiazaniaRownania(a, b, c);

        if (rozwiązania.Length == 0)
        {
            Console.WriteLine("Brak rozwiązań");
        }
        else
        {
            Console.WriteLine("Rozwiązania: ");
            foreach (double rozwiązanie in rozwiązania)
            {
                Console.WriteLine(rozwiązanie);
            }
        }
    }

    static double[] RozwiazaniaRownania(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            return new double[0];
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            return new double[] { x };

        }
        else
        {
            double SqrtDelta = Math.Sqrt(delta);
            double x1 = (-b - SqrtDelta) / (2 * a);
            double x2 = (-b + SqrtDelta) / (2 * a);
            return new double[] { x1, x2 };

        }
    }
}

// Koniec zadania 13 