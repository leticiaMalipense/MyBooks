using System;
using SQLite;
using MyBooks.models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBooks.DataBase
{
    public class BaseData
    {
        readonly SQLiteAsyncConnection database;

        public BaseData(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Book>().Wait();
        }

        public Task<int> insert(Book book)
        {
            if (book.id == 0) {
                return database.InsertAsync(book);
            }
            return database.UpdateAsync(book);
        }

        public void delete(Book book)
        {
            database.DeleteAsync(book);
        }

        public Task<List<Book>> findAll()
        {
            return database.Table<Book>().ToListAsync();
        }

        public Task<Book> findById(uint id)
        {
            return database.Table<Book>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

    }
}
