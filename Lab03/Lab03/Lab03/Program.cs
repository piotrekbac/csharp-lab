// Przykład tłumaczący 

//int n = 0;
//do
//{
//    Console.Write(n);
//    n++;
//} while (n < 5); 

//wyjście (czyli co otrzymamy): 01234

// Zadanie 1 

//int n = 10;
//do
//{
//    Console.Write(n);
//    n--;

//} while (n > -1);

// Koniec zadania 1 

// Zadanie 2 

//string haslo; 

//do
//{
//    Console.Write("Proszę podać hasło: ");
//    haslo = Console.ReadLine();
//} while (haslo != "koniec");

// Koniec zadania 2 

// Przykład tłumaczący 

//int n = 0; 
//while (n < 5)
//{
//    Console.Write(n);
//    n++;
//}

//Wyjście (czyli co otrzymamy): 01234

// Zadanie 3 

//int n = 1;
//while (n <= 101)
//{
//    if (n % 2 == 0)
//    {
//        Console.WriteLine($"Liczby od 1 do 100 parzyste: {n}");
//    }
//    n++;
//}

// Koniec zadania 3 

// Sposób prowadzącego na zadanie 3 

//int j = 1;
//Console.WriteLine("Liczby parzyste: ");
//while (j <= 100)
//{
//    if (j % 2 == 0)
//        Console.WriteLine(j);
//    j++;
//}

// Koniec sposobu prowadzącego na zadanie 3 

// Przykład tłumaczący 

//for (int i = 0; i < 3; i++)
//    {
//    Console.Write(i);
//    }

//Wyjśćie (czyli co otrzymamy): 012

// Zadanie 4 

//for (int i = 0; i <= 15; i++)
//{
//    int potega = i * i;  
//    Console.WriteLine($"Podniesienie do potęgi 2 liczby od 1 do 15: {potega}");
//}

// Koniec zadania 4 

// Wg wykładowcy - zadanie 4A 
//for (int i = 1; int <= 5; int++)
//{
//    Console.WriteLine($"Square of {i} equals { i* i}");
//}
//// oraz zadanie 4B 
//for (int i = 1; i <= 15;  i++)
//{
//    string txt = "Swuare of " + i + " equals " + i * i; 
//}

// Przykład tłumaczący 

//List<int> fibNumbers = new() { 0, 1, 1, 2, 3, 5, 8, 13 };
//foreach (int element in fibNumbers)
//{
//    Console.WriteLine($" {element} ");
//}
////Wyjście (czyli co otrzymamy): 0 1 1 2 3 5 8 13 

// Zadanie 5 

//List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 }; 

//foreach (int element in numbers)
//{
//    Console.WriteLine($" Czy dane elementy ze zbioru 4,25,35,42,55,78,99,101 są podzielne przez 7: {element % 7 == 0}");
//}

// Koniec zadania 5 

// Zadanie 6 

//List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };

//foreach (int element in numbers)
//{

//    if (element % 7 == 0)
//    {
//        Console.WriteLine(element);
//        break;
//    }

//}

// Koniec zadania 6 

// Zadanie 7 

//double[] tablicaDouble = new double[20];

//for (int i = 0; i < 20; i++)
//{
//    tablicaDouble[i] = Math.Sqrt(i);
//    Console.WriteLine(tablicaDouble[i]);
//}

// Koniec zadania 7 

// Zadanie 8 

//int [,] macierz = new int[3, 4];

//int liczba = 1;

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        macierz[i, j] = liczba++;

//    }

//}

//// Ukazanie macierzy po transpozycji 

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {

//        Console.WriteLine(macierz[i,j] + "\t");

//    }
//    Console.WriteLine(); 
//}

// Koniec zadania 8 - PATRZ ZDJ 

// Zadnaie 10

//using System;
//using System.Security;

//class Program
//{
//    static void Main()
//    {
//        string tekst = "Przykładowy tekst";
//        WypiszWielkimiLiterami(tekst);
//    }

//    static void WypiszWielkimiLiterami(string tekst)
//    {
//        Console.WriteLine(tekst.ToUpper());
//    }

//}

// Koniec zadania 10 - ZDJ 

// Zadanie 11 
//using System;

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

// Koniec zadania 11 

// Zadanie 11 - wg wykładowcy 

void CreateAndPrintMatrix(int x, int y)
{
    // Stwórz macierz
    char[,] matrix = new char[x,y];

    // Wypełnij macierz
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[x,y] = '#';
        }
    }

    // Wydrukuj macierz
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.WriteLine(matrix[x,y]);
        }
        Console.WriteLine();
    }

}
CreateAndPrintMatrix(10, 10);


// Koniec zadania 11 - wg Wykładowcy 


// Zadanie 12 - wg wykładowcy  

//string EvenOrOdd1(int toCheck)
//{
//    string retStr = " ";

//}

// Koniec zadania 12 - wg wykładowcy 


//string EvenOrOdd3 (int toCheck)
//{
//    return toCheck % 2 == 0 ? "Even" : "Odd";
//}

// Koniec zadania 12 

// zadanie 13 wg wykładowcy - PRZEPISZ NA SPOKOJNIE ZE ZDJ 

//void PrintConsoleSquare(int x, int y)
//{
//    // rysuj górną krawędź 
//    for (int i = 0; i < x; i++)
//        Console.Write("$");
//    // zejdź do nowej linii 
//    Console.WriteLine();

//    // rysuj środek (boki) - dla kazdego wiersza
//    for (int i = 0; i < y - 2; i++)
//    {
//        Console.Write("$");

//        //teraz drukuj proste 
//        for (int ij = 0; i < x - 2; i++)
//        {
//            Console.WriteLine("$");
//        }
//    }

//    // rysuj dolną krawędź
//    for (int i = 0; i < x; i++)
//    {
//        Console.Write("$");
//    }
//    PrintConsoleSquare(5, 5);
//}

// koniec 13 wg wykładowcy 
