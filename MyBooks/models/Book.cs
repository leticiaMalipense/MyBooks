using System;
using SQLite;
namespace MyBooks.models
{
    public class Book
    {
        public Book()
        { 
        }
        [PrimaryKey, AutoIncrement]

        public int id { get; set; }
        public String title { get; set; }
        public String author { get; set; }
        public String yearOfPublication { get; set; }
        public String description { get; set; }
        public Boolean read { get; set; }

    }
}
