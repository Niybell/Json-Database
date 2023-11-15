using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonDatabase.Database;
using JsonDatabase.Database.Entity;

namespace JsonDatabase
{
    public class DbGenerator
    {
        public DbGenerator(DatabaseController controller)
        {
            _controller = controller;
        }

        private DatabaseController _controller { get; set; }

        public Table<T> UseTable<T>(Table<T> entity, string name)
        {
            Table<T> table = new Table<T>(_controller, name);
            
            _controller.CreateNewTable<T>(table, name);

            return table;
        }
    }
}