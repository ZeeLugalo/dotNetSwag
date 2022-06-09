using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace dotNetSwag
{
    public class SwagDatabase
    {
        private SQLiteConnection _connection;


        public static SwagDatabase Instance = new SwagDatabase();

        public SwagDatabase()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            string filename = Path.Combine(path, "swag.db");

            _connection = new SQLiteConnection(filename, SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache);


            _connection.CreateTable<SwagItem>();
        }

        public List<SwagItem> GetSwagItems()
        {

           return  _connection.Table<SwagItem>().ToList();
        }


        public void SaveSwagItem(SwagItem item)
        {
            _connection.Insert(item);
        }
    }
}
