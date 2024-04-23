using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Models
{
    public class Library
    {
        static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public int BookCount { get; set; }
      
       

        public Library(string name, int bookCount)
        {
            _id++;
            Id = _id;
            Name = name;
            BookCount = bookCount;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, BookCount: {BookCount}";
        }



    }
}
