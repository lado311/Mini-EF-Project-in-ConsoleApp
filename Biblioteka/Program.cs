using Biblioteka.Controller;

Console.WriteLine();

int manage = 0;
while (manage != 8)
{
    Console.WriteLine("1.See All Book");
    Console.WriteLine("2.Search Book");
    Console.WriteLine("3.Search book By Category");
    Console.WriteLine("4.Add Book");
    Console.WriteLine("5.Update Book");
    Console.WriteLine("6.Remove Book");
    Console.WriteLine("7.See All Category of Library");
    Console.WriteLine("8.Exit");

    manage = int.Parse(Console.ReadLine());

    if (manage == 1)
        BookController.GetAllBook();
    if(manage == 2)
    {
        Console.WriteLine("Search Book By Id: ");
        BookController.GetOneBook(int.Parse(Console.ReadLine()));
    }
    if(manage == 3)
    {
        Console.WriteLine("Search book by Category Id: ");
        LibraryController.GetBookByCategory(int.Parse(Console.ReadLine()));
    }
    if(manage == 4)
    {
        Console.WriteLine("Enter new : name, author, QNT, LibraryId");
        BookController.AddBook();
    }

    if(manage == 5)
    {
        Console.WriteLine("Find book by id: ");
        BookController.UpdateBook(int.Parse(Console.ReadLine()));
    }
    if(manage == 6)
    {
        Console.WriteLine("Find book by id: ");
        BookController.DeleteBook(int.Parse(Console.ReadLine()));
    }
    if (manage == 7)
        LibraryController.GetAllLibrarysCategory();



}
