using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Book
    {
        static int _id;
        public int Id { get;  }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
       
        

        public Book(string name,string authorName,double price)
        {
            _id++;
            Id= _id;
            Name= name;
            AuthorName= authorName;
            Price= price;
           
           
        }
        public override string ToString()
        {
            return $" Id: {Id} Name: {Name} AuthorName: {AuthorName} Price: {Price}  ";
        }






    }
}
