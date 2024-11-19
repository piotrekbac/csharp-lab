using System.ComponentModel.Design;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6();
            Console.WriteLine("Kończę sprawdzian.");
        }

        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;

            for (int i = b; i >= a; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"Liczby ze zbioru a oraz b podzielne przez 3 (od największej do najmniejszej): " + i);
                }
            }       

            // tutaj rozwiązanie zadania 1

            Console.WriteLine("Kończę zadanie 1");
        }
        static void Zadanie_2()
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            // zadanie numer 2
            // zaimplementuj poniższą procedurę
            void PrintTriangle(int rozmiar)
            {
                string trojkat = "";
                int i = rozmiar % 2 == 0 ? 1 : 2;

               for (i = 1; i <= rozmiar; i++)
                    {
                    Console.WriteLine('$');  
                    }
            }
            PrintTriangle(10);
            Console.WriteLine("Kończę zadanie 2");
        }
        static void Zadanie_3()
        {
           
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now;

            int day = today.Day;

            // tutaj rozwiązanie zadania 3
            string informacja = today.Hour >= 12 ? "Dzień dobry" : "Dobry wieczór!";
            string finalText = $"{informacja}, dzisiaj {today.DayOfWeek}, czyli {day} dzień tygodnia.";
            Console.WriteLine(finalText);

            Console.WriteLine("Kończę zadanie 3");
        }
        static void Zadanie_4()
        {
            Console.WriteLine("Rozpoczynam zadanie 4");
            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };

            // zadanie numer 4
            // zaimplementuj poniższą funkcję
            static double FindMaxAbsoluteValue(double[] nums)
            {

                double maksimum = nums[0];
                for (int i= 1; i < nums.Length; i++)
                {
                    if (Math.Abs(nums[i]) > maksimum) maksimum = nums[1];
                    FindMaxAbsoluteValue(nums);
                }
                return maksimum;
            }

            Console.WriteLine("The MIN value = " + FindMaxAbsoluteValue(numbers));
            Console.WriteLine("Kończę zadanie 4");
        }
        static void Zadanie_5_6()
        {
            // tutaj rozwiązanie zadań 5 oraz 6
            // można modyfikować, zmieniać kolejność itp.
            Console.WriteLine("Rozpoczynam pętlę.");

            Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić.");

            string wartosc = Console.ReadLine();
           
                try
                {
                //int tekst = WczytajZKlawiatury(Console.ReadLine());
                int wynik = int.Parse(wartosc);
                }
                catch (Exception ex)

                {
                    Console.WriteLine("Błąd: " + ex.Message);
                    Console.WriteLine("Dokonaj ponownie konwersji! ");
                }



            do
            {
                if (wartosc wynik = 1)
                {
                    Zadanie_1();
                }
                else if (wartosc = 2)
                {
                    Zadanie_2();
                }
                else if (wartosc = 3)
                {
                    Zadanie_3();
                }
                else if (wartosc = 4)
                {
                    Zadanie_4();
                }
                else 
                {
                    Console.WriteLine("Nie ma takiego zadania, wybierz ponownie.");
                }
            } while (int wartosc != 0);
     

            Zadanie_1();
            Zadanie_2();
            Zadanie_3();
            Zadanie_4();

            Console.WriteLine("Kończę pętlę.");
        }

        private static int WczytajZKlawiatury(string? v)
        {
            throw new NotImplementedException();
        }
    }
}