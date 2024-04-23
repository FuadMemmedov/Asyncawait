using Core.DataAccessLayer;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Core.Services.Concrets
{
    public class BookService 
    {
        public async Task AddBook(Book book)
        {
            await Task.Run(() =>AppDb.books.Add(book));
        }

       public async Task GetAllBooks()
        {
            await Task.Run(() => AppDb.books.ForEach(book =>  Console.WriteLine(book)));
        }

        public async Task RemoveBook(int id)
        {
            Book book = await Task.Run(() => AppDb.books.Find(item => item.Id == id));

            AppDb.books.Remove(book);
        }
    }
}
