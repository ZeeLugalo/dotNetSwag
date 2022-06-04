using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dotNetSwag

{
    public partial class dotSwagitempage : ContentPage
    {
        public dotSwagitempage();

       
        public class TodoItemDatabase
        {
            static SQLiteConnection Database;
​
            public static TodoItemDatabase Instance
             {
                get
                {
                    var instance = new TodoItemDatabase();
                    CreateTableResult result = Database.CreateTable<TodoItem>();
                    return instance;
                }
            }​
​
              public object Constants { get; private set; }

              public TodoItemDatabase()
            {
                Database = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
            }
​
            public List<TodoItem> GetItems()
            {
                return Database.Table<TodoItem>().ToList();
            }
​
             public List<TodoItem> GetItemsNotDone()
            {
                return Database.Query<TodoItem>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
            }
​
        public TodoItem GetItem(int id)
            {
                return Database.Table<TodoItem>().Where(i => i.ID == id).FirstOrDefault();
            }
​
        public int SaveItem(TodoItem item)
            {
                if (item.ID != 0)
                {
                    return Database.Update(item);
                }
                else
                {
                    return Database.Insert(item);
                }
            }
​
        public int DeleteItem(TodoItem item)
            {
                return Database.Delete(item);

            }
    }
}

        public class SQLiteConnection
    {
        private object databasePath;
        private object dotNetSwag;

        public SQLiteConnection(object databasePath, object flags)
        {
            this.databasePath = databasePath;
            this.dotNetSwag = dotNetSwag;
        }

        internal object Table<T>()
        {
            throw new NotImplementedException();
        }

        internal object DatabasePath 
        {
            
            get { return databasePath; } }
        
        }