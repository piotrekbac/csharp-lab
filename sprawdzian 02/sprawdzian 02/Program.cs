using sprawdzian_02;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

//zadanie 1
static void Main(string[] args)
{


    Point3d punkt1 = new Point3d(1.5, 5.75, -7.0);
    {
        Console.WriteLine(punkt1.GetDistanceFromOrigin());
    }

    //zadanie 2 

    Adult john = new Adult { Name = "John"};
    Adult jane = new Adult { Name = "Jane" };

    Child kevin = new Child { Name = "Kevin" , Mother = jane, Father = john};
    Child mike = new Child { Name = "Mike" , Mother = jane, Father = john};
    Child wendy = new Child { Name = "Wendy", Mother = jane, Father= john};

    jane.Children.Add(kevin);
    jane.Children.Add(mike);
    jane.Children.Add(wendy);

    john.Children.Add(kevin);
    jane.Children.Add(mike);
    john.Children.Add(wendy);

    Console.WriteLine($"Dorośli {john.Name} i {jane.Name} mający 3 dzieci: {kevin.Name}, {mike.Name}, {wendy.Name}");

    //zadanie 3 

    Human humanAdult = new Adult();
    Console.WriteLine(humanAdult.EatSnack());

    Human childAdult = new Child();
    Console.WriteLine(childAdult.EatSnack());

    //zadanie 4 

    Human[] human = { new Adult(), new Child() };
    foreach (var h in human)
    {
        if (h is ISinger singer)
        {
            Console.WriteLine(singer.Sing());
        }
        else
        {
            Console.WriteLine($"{h.GetType().Name} does not sing.");
        }
           
    }

    //zadanie 5 

    Singers<Child> childrenSingers = new Singers<Child>();

    childrenSingers.Add(new Child("Ania"));
    childrenSingers.Add(new Child("Kasia"));
    childrenSingers.Add(new Child("Baia"));

    foreach (var child in childrenSingers)
    {
        child.Sing();
    }

    //zadanie 6 

    Book book1 = new Book { Title = "Ulysses", Autor = "James Joyce", YearPublished = 1922 };
    Book book2 = new Book { Title = "Lolita", Autor = "Vladimir Nabokov", YearPublished = 1955 };
    Book book3 = new Book { Title = "The Great Gatsby", Autor = "F. Scott Fitzgerald", YearPublished =
1925
    };
    Book book4 = new Book { Title = "In Search of Lost Time", Autor = "Marcel Proust", YearPublished = 1913 };

    List<Book> books = new List<Book> { book1, book2, book3,book4};
    Console.WriteLine("Autorzy w kolejności alfabetycznej: ");
    var autors = books.Select(b => b.Autor).OrderBy(a => a);
    foreach (var autor in autors)
    {
        Console.WriteLine(autor);
    }

    books.Add(new Book { Title = "My Favorite Book", Autor = "Myself", YearPublished = 2024 });

    Console.WriteLine("Książki starsze niż 100 lat: ");
    var oldBooks = books.Where(b => DateTime.Now.Year - b.YearPublished > 100);
    foreach (var oldBook in oldBooks)
    {
        Console.WriteLine(oldBook.Title);
    }

    var oldestBook = books.OrderBy(b=>b.YearPublished).First();
    books.Remove(oldestBook);

    Console.WriteLine("Aktualny zbiór książek: ");
    foreach (var book in books)
    {
        Console.WriteLine($"{book.Title} - {book.Autor} ({book.YearPublished})");
    }


}



