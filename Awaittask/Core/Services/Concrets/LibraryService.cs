using Core.DataAccessLayer;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Concrets
{
    public class LibraryService
    {
        public async Task AddLibrary(Library library)
        {
            await Task.Run(() => AppDb.libraries.Add(library));
        }

        public async Task GetAllLibraryes()
        {
            await Task.Run(() => AppDb.libraries.ForEach(library => Console.WriteLine(library)));
        }

        public async Task RemoveLibrary(int id)
        {
            Library library = await Task.Run(() => AppDb.libraries.Find(item => item.Id == id));

            AppDb.libraries.Remove(library);
        }
    }
}
