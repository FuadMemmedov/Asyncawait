using Core.DataAccessLayer;
using Core.Enums;
using Core.Models;
using Core.Services.Concrets;
using System.Xml.Serialization;

namespace ConsoleApp7
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            LibraryService libraryService = new LibraryService();
             BookService bookService = new BookService();

            bool check = false;
            bool subcheck = false;
            int choice;
            
            
         

            do
            {
                Console.WriteLine("1.Kitabxana yarat");
                Console.WriteLine("2.Butun Kitabxanalari gor");
                Console.WriteLine("3.Kitabxana sil");
                Console.WriteLine("4.Kitabxana sec");
                Console.WriteLine("0.Exit");

                do
                {
                    Console.Write("Secim edin: ");
                }
                while (!int.TryParse(Console.ReadLine(), out choice));

                switch (choice)
                {
                    case (byte)Menu.LibraryYarat:
                        Console.Write("Kitabxana adi daxil edin: ");
                       string libraryName = Console.ReadLine();
                        int bookCount;
                        do
                        {
                            Console.Write("Kitabxanadaki kitablarin sayin daxil edin: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out bookCount));

                        Library library = new Library(libraryName,bookCount);
                        await libraryService.AddLibrary(library);
                        break;
                    case (byte)Menu.ButunLibraryerigor:
                        await libraryService.GetAllLibraryes();
                       
                        break;
                    case (byte)Menu.LibrarySil:
                        await libraryService.GetAllLibraryes();
                        int libraryId;
                        do
                        {
                            Console.Write("Silmek istediyiniz kitabxananin id daxil edin: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out libraryId));
                        await libraryService.RemoveLibrary(libraryId);

                        break;
                    case (byte)Menu.LibrarySec:
                        
                        
                            Console.Write("Secmek istediyiniz kitabxananin adin daxil edin: ");
                             libraryName = Console.ReadLine();
                        
                    
                        AppDb.libraries.Find(library => library.Name== libraryName);

                            do
                            {
                                do
                                {
                                    Console.WriteLine("1.Kitab yarat");
                                    Console.WriteLine("2.Kitablari gor");
                                    Console.WriteLine("3.Kitablari sil");
                                    Console.WriteLine("0.Evvelki menu qayit");
                                    Console.Write("Secim edin: ");
                                }
                                while (!int.TryParse(Console.ReadLine(), out choice));

                                switch (choice)
                                {
                                    case (byte)BookMenu.BookYarat:
                                        Console.Write("Kitabin adin daxil edin: ");
                                      string bookName = Console.ReadLine();
                                    Console.Write("Kitabin yazarinin adin daxil edin: ");
                                    string authorName = Console.ReadLine();
                                    double bookPrice;
                                    do
                                        {
                                            Console.Write("Kitabin qiymetin daxil edin: ");
                                        }
                                        while (!double.TryParse(Console.ReadLine(), out bookPrice));

                                        Book book = new Book(bookName, authorName, bookPrice);
                                        await bookService.AddBook(book);
                                        break;
                                    case (byte)BookMenu.Booklarigor:
                                    await bookService.GetAllBooks();
                                    
                                        break;
                                case (byte)BookMenu.BookSil:
                                    await bookService.GetAllBooks();
                                    int bookId;
                                    do
                                    {
                                        Console.Write("Silmek istediyiniz kitabin id daxil edin: ");
                                    }
                                    while (!int.TryParse(Console.ReadLine(), out bookId));
                                    await bookService.RemoveBook(bookId);
                                    break;
                               
                                    case (byte)BookMenu.Exit:
                                        subcheck = true;
                                        break;
                                }
                            }
                            while (!subcheck);
                        
                        

                        break;
                    case (byte)Menu.Exit:
                        check = true;
                        break;

                }

            }
            while (!check);
        }
    }
}