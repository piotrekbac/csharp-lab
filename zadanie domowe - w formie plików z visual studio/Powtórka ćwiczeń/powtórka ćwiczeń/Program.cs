//Console.WriteLine("Zmienne i typy danych");
//byte byteVariable = 50;
//int integralVariable = 300;
//long longVariable = 100000000;
//char charVariable1 = (char)87;
//char charVariable2 = 'a';
//double doubleVariable = 50.0005;
//float floatVariable = 50e10F;
//string stringVariable = "How you doing?";
//// tutaj wpisz rozwiązanie
//Console.WriteLine(byteVariable);
//Console.WriteLine(integralVariable);
//Console.WriteLine(longVariable);
//Console.WriteLine(charVariable1);
//Console.WriteLine(charVariable2);
//Console.WriteLine(doubleVariable);
//Console.WriteLine(floatVariable);
//Console.WriteLine(stringVariable);

//// konwersja niejawna
//int num = 100;
//long bigNum = num;
//System.Console.WriteLine(bigNum);

//// konwersja jawna
//double x = 1234.7;
//int a;
//a = (int)x;
//System.Console.WriteLine(a);

//int num = 2147483647;
//long bigNum = 88888888888;
//string stringNum = "1024";

//// zadeklaruj zmienną typu long i przypisz do niej zmienną num
//long naNum = num;
//// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
//int naBigNum = (int)bigNum;
//// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
//int naStringNum = int.Parse(stringNum);
//// zbadaj zachowanie programu
//Console.WriteLine(naNum);
//Console.WriteLine(naBigNum);
//Console.WriteLine(naStringNum);

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
//decimal pricekwadrat = (price * price);
//Console.WriteLine(pricekwadrat);
//// wypisz na ekran wynik zmiennej doubleVal pomnożonej przez samą siebie
//double doublekwadrat = (doubleVal * doubleVal);
//Console.WriteLine(doublekwadrat);
//// zastanów się skąd się bieże różnica
//// wypisz na ekran wynik pola koła o promieniu równym radius
//double wynikkola = radius * radius * 3.14;
//Console.WriteLine(wynikkola);
//// W zmiennej time znajduje się czas w minutach. Oblicz wartości zmiennych hours, minutes i seconds na postawie zmiennej time.
//Console.WriteLine($"Czas w godzinach: {time / 60}");
//Console.WriteLine($"Czas w minutach: {time}");
//Console.WriteLine($"Czas w sekundach: {time * 60}");


//int toIncrement = 3;
//int toDivide = 5;
//// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
//Console.WriteLine(++toIncrement);
//// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)
//Console.WriteLine(toDivide / toDivide);

using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Reflection;

///* zadanie 1 */
///* koniec zadania 1 */
///* zadanie 2 */
///* koniec zadania 2 */
///
///* zadanie 3 */
///* koniec zadania 3 */
///* zadanie 4 */
///* koniec zadania 4 */
Math.Sqrt(9);            // pierwiastek kwadratowy
Math.Pow(3, 2);           // potęgowanie
Math.Abs(-10);           // moduł
Math.Sin(1.57);          // sinus kąta w radianach
Math.Round(1.5);         // zaokrąglenie do najbliższej wartości całkowitej
Math.Round(2.5);         // wynik taki jak dla funkcji wyżej   
Math.Truncate(1.95);     // część całkowita liczby zmiennoprzecinkowej
Math.Ceiling(1.95);      // najmniejsza liczba całkowita większa lub równa argumentowi
Math.Floor(1.95);        // największa liczba całkowita mniejsza lub równa argumentowi 
Math.Clamp(4, 0, 10);   // ograniczenie pierwszego argumentu do zakresu
Math.Max(2, 6);          // zwraca większy argument
Math.Min(2, 6);          // zwraca mniejszy argument
Math.Sign(-2);           // zwraca liczbę określającą znak argumentu: - 1, 0 lub 1

///* zadanie 5 */
//double degree = 45;
//double sinValue = Math.Sin(degree);
//// do zmiennej sinValue przypisz wartość funkcji sinus dla zmiennej degree wyrażonej w stopniach
//Console.WriteLine(sinValue);
///* koniec zadania 5 */

///* zadanie 6 */
//int year = 2024;
//int month = 5;
//int day = 3;
//int hour = 23;
//int minute = 30;
//// stwórz zmienną typu DateTime jako wartość złożoną z powyższych składowych
//DateTime dt = new DateTime(year, month, day, hour, minute, 0);
//// następnie dodaj do niej 3 miesiące, odejmij 1 godzinę
//dt.AddMonths(3);
//dt.AddHours(-1);
//// wypisz na ekran nazwę dnia tygodnia jaki przypada tego dnia
//Console.WriteLine(dt.DayOfWeek);
///* koniec zadania 6 */

//string msgImplicityNull;
//string msgExplicityNull = null;
//string msgEmpty = string.Empty;
//string msgInitiated = "Hello";
//string pathWithEscapes = "c:\\programs\\app\\file.txt";
//string pathWithoutEscapes = @"c:\programs\app\file.txt";
//int counter = 6;
//string msgEvaluation = $"Counter = {counter}";
//char[] chars = { 'H', 'e', 'l', 'l', 'o' };
//string msgFromCharArray = new string(chars);
//String msgInitiatedByConstructor = new String(chars);
//Console.WriteLine(msgExplicityNull);
//Console.WriteLine(msgEmpty);
//Console.WriteLine(msgInitiated);
//Console.WriteLine(pathWithEscapes);
//Console.WriteLine(pathWithoutEscapes);
//Console.WriteLine(msgEvaluation);
//Console.WriteLine(chars);
//Console.WriteLine(msgFromCharArray);
//Console.WriteLine(msgInitiatedByConstructor);

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
//string zmienna = (firstPart + " " + secondPart + " " + thirdPart);
//Console.WriteLine(zmienna);
//// wypisz na ekran tekst nowej zmiennej DRUKOWANYMI LITERAMI
//Console.WriteLine(zmienna.ToUpper());
//// oraz liczbę przedstawiającą długość tego ciągu znaków
//Console.WriteLine(zmienna.Length);

///* koniec zadania 7 */

//bool IsGreater = false;
//bool IsLower = true;

//bool IsLower = !IsGreater;
//bool IsInRange = IsLower && true;
//bool IsEqual = !IsGreater || !IsLower;

//int counter = 56;
//double temperature = 14;
//bool isGreaterThanLimit = counter > 100;
//bool isCold = temperature < 5;
//bool isEqualZero = counter == 0;
//bool isNotZero = counter != 0;
//bool isGreaterOrEqualZero = temperature >= 0.0;

///* zadanie 8 */
//double lengthA = 5;
//double lengthB = 1;
//double lengthC = 3;
//// zadeklaruj zmienną typu bool, przypisz do niej wartość mówiącą czy z powyższych 3 odcinków da się zbudować trójkąt
//bool trojkat = lengthA < lengthB + lengthC;
//// jeśli tak, to sprawdź czy jest to trójkąt prostokątny (kolejna zmienna bool)
//if (trojkat = true)
//{
//    bool trojkatprostokatny = (lengthA * lengthA == (lengthB * lengthB) + (lengthC * lengthC));
//    Console.WriteLine("Trójkąt jest prostokątny");
//}
//else
//{
//    Console.WriteLine("Trójkąt nie jest prostokątny");
//}

///* koniec zadania 8 */

///* zadanie 9 */
//string conditionalString = "To be or not to be?";
//// jeśli długość ciągu znaków jest większa niż 10 to wyświetl na ekran ten tekst
//if (conditionalString.Length > 10)
//{
//    Console.WriteLine(conditionalString);
//    Console.WriteLine("Zatem ciąg znaków jest większy od 10");
//}
//else
//{
//    Console.WriteLine("Ciąg znaków jest mniejszy od 10");
//}
///* koniec zadania 9 */

///* zadanie 10 */
//int temperature = 22;
//// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"
//if (temperature > 20)
//{
//    Console.WriteLine("Ciepło");
//}
//else
//{
//    Console.WriteLine("Zimno");
//}

///* koniec zadania 10 */

//int result = a > b ? a : b;

////*Zadanie 11 */
//int temperature = 22;
//string result;
//result = (temperature > 20) ? "ciepło" : "zimno";
//Console.WriteLine(result);
////*koniec zadania 11 */

///* zadanie 12 */
//int code = 4;
//int quantity = 11;
//decimal productPrice = 3.5m;
//decimal sellPrice;

//if (code < 10)
//{
//    Console.WriteLine($"Cena to: {productPrice}");
//}
//else if (code >= 10 && code <= 15)
//{
//    Console.WriteLine($"Cena to: {productPrice * 0,95}");
//}
//else
//{
//    if (quantity <= 10)
//    {
//        Console.WriteLine($"Cena to: {productPrice * 1,05}");
//    }
//    else if (quantity >= 11 && quantity <= 20) 
//    {
//        Console.WriteLine($"Cena to: {productPrice}");
//    }
//    else if (quantity > 20 && quantity < 100) 
//    {
//        int przecena = (quantity / 10);
//        sellPrice = productPrice * (1 - (przecena * 0.01m));
//    }
//    else
//    {
//        Console.WriteLine($"Cena to: {productPrice * 0,90}");
//    }
//}

//Console.WriteLine($"Cena to: {productPrice}");

////Console.WriteLine($"Price: {sellPrice}");
///* koniec zadania 12 */

///* zadanie 13 */
//char hexNum = 'a';

//switch (hexNum)
//{
//    case '0':
//        Console.WriteLine($"Decimal number: 0");
//        break;

//    case '1':
//        Console.WriteLine($"Decimal number: 1");
//        break;
//    case '2':
//        Console.WriteLine($"Decimal number: 2");
//        break;
//    case '3':
//        Console.WriteLine($"Decimal number: 3");
//        break;
//    case '4':
//        Console.WriteLine($"Decimal number: 4");
//        break;
//    case '5':
//        Console.WriteLine($"Decimal number: 5");
//        break;
//    case '6':
//        Console.WriteLine($"Decimal number: 6");
//        break;
//    case '7':
//        Console.WriteLine("$Decimal number: 7");
//        break;
//    case '8':
//        Console.WriteLine("$Decimal number: 8");
//        break;
//    case '9':
//        Console.WriteLine($"Decimal number: 9");
//        break;
//    case 'a':
//    case 'A':
//        Console.WriteLine($"Decimal number: 10");
//        break;
//    case 'b':
//    case 'B':
//        Console.WriteLine($"Decimal number: 11");
//        break;
//    case 'c':
//    case 'C':
//        Console.WriteLine($"Decimal number: 12");
//        break;
//    case 'd':
//    case 'D':
//        Console.WriteLine($"Decimal number: 13");
//        break;
//    case 'e':
//    case 'E':
//        Console.WriteLine($"Decimal number: 14");
//        break;
//    case 'f':
//    case 'F':
//        Console.WriteLine($"Decimal numer: 15");
//        break;
//    default:
//        Console.WriteLine($"Not a valid hexadecimal number!");
//        break;
//}

///* koniec zadania 13 */