﻿/* zadanie 1 */
//using System.Numerics;

//Console.WriteLine("Zmienne i typy danych");
//byte byteVariable = 50;
//int integralVariable = 300;
//long longVariable = 100000000;
//char charVariable1 = (char)85;
//char charVariable2 = 'a';
//double doubleVariable = 50.0005;
//float floatVariable = 55e11F;
//string stringVariable = "Jak się masz piękny kawalerze?";


//Wypisywanie w konsoli poszczególnych zmiennych
//Console.WriteLine(byteVariable);
//Console.WriteLine(integralVariable);
//Console.WriteLine(longVariable);
//Console.WriteLine(charVariable1);
//Console.WriteLine(charVariable2);
//Console.WriteLine(doubleVariable);
//Console.WriteLine(floatVariable);
//Console.WriteLine(stringVariable);

// tutaj wpisz rozwiązanie
/* koniec zadania 1 */

//// konwersja niejawna
//int num = 100;
//long bigNum = num;
//System.Console.WriteLine(bigNum);

//// konwersja jawna
//double x = 1234.7;
//int a;
//a = (int)x;
//System.Console.WriteLine(a);

/* zadanie 2 */
//int num1 = 2147483647;
//long bigNum1 = 88888888888;
//string stringNum = "1024";

//long naNum = num1;
//System.Console.WriteLine(num1);

//int naBigNum = (int)bigNum1;
//System.Console.WriteLine(naBigNum);

//int NaStringNum = int.Parse(stringNum);
//System.Console.WriteLine(NaStringNum);
//przykład pokazuje nam, że w incie nie zmieści się dana wartość: 88888888888.


// zadeklaruj zmienną typu long i przypisz do niej zmienną num
// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
// zbadaj zachowanie programu

/* koniec zadania 2 */



/////* zadanie 3 */
//int a = 18;
//int b = 6;
//decimal price = 10.56m;
//double doubleVal = 10.56;
//double radius = 5.0;
//double time = 1234.45;
//// zadeklaruj zmienną c, do której przypisz wynik dodawania a i b 
//int c = a + b;
//// zadeklaruj zmienną d, do której przypisz wynik odejmowania a i b 
//int d = a - b;
//// zadeklaruj zmienną e, do której przypisz wynik mnożenia a i b 
//int e = a * b;
//// zadeklaruj zmienną f, do której przypisz wynik dzielenia a i b 
//int f = a / b;
//// zadeklaruj zmienną g, do której przypisz wynik reszty z dzielenia a i b 
//int g = a % b;
//// wypisz na ekran c,d,e,f,g
//Console.WriteLine(c);
//Console.WriteLine(d);
//Console.WriteLine(e);
//Console.WriteLine(f);
//Console.WriteLine(g);
//// wypisz na ekran wynik zmiennej price pomnożonej przez samą siebie
//Console.WriteLine(price * price);
//// wypisz na ekran wynik zmiennej doubleVal pomnożonej przez samą siebie
//Console.WriteLine(doubleVal * doubleVal);
//// zastanów się skąd się bieże różnica

////Rożnica wynika z aktów mnożenia w decimal i double 

//// wypisz na ekran wynik pola koła o promieniu równym radius
//Console.WriteLine(Math.PI * (radius * radius));
//// W zmiennej time znajduje się czas w minutach. Oblicz wartości zmiennych hours, minutes i seconds na postawie zmiennej time.
//Console.WriteLine("Czas w minutach: " + time);
//Console.WriteLine("Czas w hours: " + time * 60);
//Console.WriteLine("Czas w secounds: " + time * 3600);

/* zadanie 4 */
//int toIncrement = 3;
//int toDivide = 5;
//// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
//Console.WriteLine(++toIncrement); //używamy inkrementacji prefiksu! 
//// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)
//Console.WriteLine(toDivide/toDivide);

/* koniec zadania 4 */

//using System.Reflection.Metadata.Ecma335;

/////* koniec zadania 3 */
//Math.Sqrt(9);            // pierwiastek kwadratowy
//Math.Pow(3, 2);           // potęgowanie
//Math.Abs(-10);           // moduł
//Math.Sin(1.57);          // sinus kąta w radianach
//Math.Round(1.5);         // zaokrąglenie do najbliższej wartości całkowitej
//Math.Round(2.5);         // wynik taki jak dla funkcji wyżej   
//Math.Truncate(1.95);     // część całkowita liczby zmiennoprzecinkowej
//Math.Ceiling(1.95);      // najmniejsza liczba całkowita większa lub równa argumentowi
//Math.Floor(1.95);        // największa liczba całkowita mniejsza lub równa argumentowi 
//Math.Clamp(4, 0, 10);   // ograniczenie pierwszego argumentu do zakresu
//Math.Max(2, 6);          // zwraca większy argument
//Math.Min(2, 6);          // zwraca mniejszy argument
//Math.Sign(-2);           // zwraca liczbę określającą znak argumentu: - 1, 0 lub 1

////Math.PI
////Math.E
////Math.Tau

///* zadanie 5 */
//double degree = 45;
//double sinValue = Math.Sin(degree);
//// do zmiennej sinValue przypisz wartość funkcji sinus dla zmiennej degree wyrażonej w stopniach
//Console.WriteLine(sinValue);
///* koniec zadania 5 *////


///* zadanie 6 */
//int year = 2024;
//int month = 5;
//int day = 3;
//int hour = 23;
//int minute = 30;
//// stwórz zmienną typu DateTime jako wartość złożoną z powyższych składowych
//DateTime dt = new DateTime(year, month, day, hour, minute, 0);
//Console.WriteLine(dt);
//// następnie dodaj do niej 3 miesiące, odejmij 1 godzinę
//dt = dt.AddMonths(3);
//dt = dt.AddHours(-1);
//// wypisz na ekran nazwę dnia tygodnia jaki przypada tego dnia
//Console.WriteLine(dt.DayOfWeek);
///* koniec zadania 6 */

//string msgimplicitynull;
//string msgexplicitynull = null;
//string msgempty = string.Empty;
//string msginitiated = "hello";
//string pathwithescapes = "c:\\programs\\app\\file.txt";
//string pathwithoutescapes = @"c:\programs\app\file.txt";
//int counter = 6;
//string msgevaluation = $"counter = {counter}";
//char[] chars = { 'h', 'e', 'l', 'l', 'o' };
//string msgfromchararray = new string(chars);
//string msginitiatedbyconstructor = new string(chars);

//string a = "abcd";
//string b = "efgh";
//a += b;
//Console.WriteLine(a.ToUpper());
//Console.WriteLine(a);

///* zadanie 7 */
//string firstPart = "This is";
//string secondPart = "a string";
//string thirdPart = "with capital letters.";
//// stwórz nową zmienną typu string jako złączenie powyższych.
//// pamiętaj o brakujących odstępach
//// wypisz na ekran tekst nowej zmiennej DRUKOWANYMI LITERAMI
//// oraz liczbę przedstawiającą długość tego ciągu znaków
//string fullText = firstPart + " " + secondPart + " " + thirdPart;
//Console.WriteLine(fullText.ToUpper());
//Console.WriteLine(fullText.Length);
///* koniec zadania 7 */

//bool IsGreater = false;
//bool IsLower = true;

//bool IsLower = !IsGreater; //Negacja NOT 

//bool IsInRange = IsLower && true; //Iloczyn logidzny AND, koniunkcja
//
//bool IsEqual = !IsGreater || !IsLower; //Alternatywa AND'a czyli OR 

//PONIŻEJ PRZEDSTAWIONE OPERATORY PORÓWNANIA 

//int counter = 56;
//double temperature = 14;
//bool isGreaterThanLimit = counter > 100;
//bool isCold = temperature < 5;
//bool isEqualZero = counter == 0;
//bool isNotZero = counter != 0;
//bool isGreaterOrEqualZero = temperature >= 0.0;

/* zadanie 8 */
//double lengthA = 5;
//double lengthB = 1;
//double lengthC = 3;
//// zadeklaruj zmienną typu bool, przypisz do niej wartość mówiącą czy z powyższych 3 odcinków da się zbudować trójkąt

//// jeśli tak, to sprawdź czy jest to trójkąt prostokątny (kolejna zmienna bool)
//bool isTriangle = (lengthA < lengthB + lengthC);
//bool isRightTriangle = (lengthA * lengthA == lengthB * lengthB + lengthC * lengthC);

/* koniec zadania 8 */

/* zadanie 9 */

//// jeśli długość ciągu znaków jest większa niż 10 to wyświetl na ekran ten tekst
//string conditionalString = "To be or not to be?";
//if (conditionalString.Length > 10)
//{
//    Console.WriteLine(conditionalString);
//}
///* koniec zadania 9 */

///* zadanie 10 */
//int temperature = 22;
//// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"
//if (temperature > 20)
//{
//    Console.WriteLine("ciepło");
//}
//else
//{
//    Console.WriteLine("zimno");
//}
///* koniec zadania 10 */

//int result = a > b ? a : b;

//ZADANIE 11 
//int temperature = 22;

//string result;
//result = (temperature > 20) ? "ciepło" : "zimno";
//Console.WriteLine(result);

/* zadanie 12 */
//int code = 16; 
//int quantity = 80; 
//decimal productPrice = 3.5m; 
//decimal sellPrice; 

//// Obliczanie ceny sprzedaży w zależności od kodu
//if (code < 10)
//{
//    sellPrice = productPrice; // Cena taka sama jak productPrice
//}
//else if (code >= 10 && code <= 15)
//{
//    sellPrice = productPrice * 0.95m; // Cena o 5% mniejsza niż w productPrice
//}
//else
//{
//    // Cena zależna od quantity
//    if (quantity <= 10)
//    {
//        sellPrice = productPrice * 1.05m; // Cena o 5% wyższa
//    }
//    else if (quantity <= 20)
//    {
//        sellPrice = productPrice; // Cena równa productPrice
//    }
//    else if (quantity < 100)
//    {
//        // Zmniejszenie ceny o 1% za każdą pełną wielokrotność 10
//        int discountPercentage = (quantity / 10) - 2; // -2, ponieważ dla 20 już zrobiliśmy 0% zniżki
//        sellPrice = productPrice * (1 - (discountPercentage * 0.01m));
//    }
//    else
//    {
//        sellPrice = productPrice * 0.90m; // Cena o 10% niższa
//    }
//}

//Console.WriteLine($"Price: {sellPrice}");
/* koniec zadania 12 */



/* zadanie 13 */
char hexNum = 'a';

switch (hexNum)
{
    case '0':
        Console.WriteLine($"Decimal number: 0");
        break;

    case '1':
        Console.WriteLine($"Decimal number: 1");
        break;

    case '2':
        Console.WriteLine($"Decimal number: 2");
        break;

    case '3':
        Console.WriteLine($"Decimal number: 3");
        break;

    case '4':
        Console.WriteLine($"Decimal number: 4");
        break;

    case '5':
        Console.WriteLine($"Decimal number: 5");
        break;

    case '6':
        Console.WriteLine($"Decimal number: 6");
        break;

    case '7':
        Console.WriteLine($"Decimal number: 7");
        break;

    case '8':
        Console.WriteLine($"Decimal number: 8");
        break;

    case '9':
        Console.WriteLine($"Decimal number: 9");
        break;

    case 'A':
    case 'a':
        Console.WriteLine($"Decimal number: 10");
        break;

    case 'B':
    case 'b':
        Console.WriteLine($"Decimal number: 11");
        break;

    case 'C':
    case 'c':
        Console.WriteLine($"Decimal number: 12");
        break;

    case 'D':
    case 'd':
        Console.WriteLine($"Decimal number: 13");
        break;

    case 'E':
    case 'e':
        Console.WriteLine($"Decimal number: 14");
        break;

    case 'F':
    case 'f':
        Console.WriteLine($"Decimal number: 15");
        break;

    default:
        Console.WriteLine($"Not a valid hexadecimal number!");
        break;
}

/* koniec zadania 13 */