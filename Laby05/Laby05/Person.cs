//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Laby05
//{
//    // Deklaracja klasy
//    public class Person
//    {
//        // Konstruktor domyślny
//        public Person(string firstName, string lastName)
//        {
//            this.FirstName = firstName;
//            this.LastName = lastName;
//        }

//        // Konstruktor z BirthDate
//        public Person(string firstName, string lastName, DateTime birthDate)
//            : this(firstName, lastName)
//        {
//            this.BirthDate = birthDate;
//        }

//        // Właściwości
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public DateTime BirthDate { get; set; }
//        public string EmailAddress { get; set; }

//        // Metoda zwracająca pełne imię i nazwisko
//        public string GetFullName()
//        {
//            return $"{FirstName} {LastName}";
//        }

//        // Metoda zwracająca wiek na podstawie BirthDate
//        public int GetAge()
//        {
//            var age = DateTime.Now.Year - BirthDate.Year;
//            if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
//                age--; // jeśli jeszcze nie minęła rocznica urodzin w danym roku
//            return age;
//        }

//        // Metoda sprawdzająca, czy osoba jest pełnoletnia
//        public bool IsAdult()
//        {
//            return GetAge() >= 18;
//        }
//    }
//}

//Zadanie 3 - wg Prof 

namespace Laby05;

public class Person
{
    //Konstruktory - jeżeli nie ma konstruktora równa się to konstruktorowi pustem
    //public Person()
    //{
       
    //}

    public Person(string firstName, string lastName, DateTime birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDay = birthDate;
        //w przypadku konfliktu nazw robimy tak: 
        //this.firstName = firstName; 
        //Jeżeli konflikt nazw nie występuje, robimy tak jak wyżej. 
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDay { get; set; }
    public string EmailAddress { get; set; }

    //rezygnując z get lub set w nawiasie, i tak możemy korzystać ze składowych.
    //Jeżeli usuniemy set, wtedy wartość do której bdziemy sie odwoływać, będzie tylko do odczytu
    //Funkcja może posiadać metody 

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public int GetAge()
    {
        return (int)(DateTime.Now - this.BirthDay).TotalSeconds / 365; 
    }

    public bool IsAdult()
    {
        return this.GetAge() >= 18; 
    }

}

//Koniec zadania 3 - wg Prof 