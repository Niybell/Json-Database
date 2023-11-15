using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonDatabase.Database;
using JsonDatabase.Database.Entity;
using JsonDatabase.TxtDb;

namespace JsonDatabase
{
    public abstract class DbContext
    {
        protected DatabaseController Controller = new DatabaseController();

        protected DbContext()
        {
            OnConnect();
        }

        private void OnConnect()
        {
            DbBuilder builder = OnConfig();
            Controller.CreateNewDatabase(new TxtDbOptions(builder.DatabaseName, builder.DatabasePath));
            OnGenerate(new DbGenerator(Controller));
            System.Console.WriteLine("JsonDatabase: Connected to db.");
        }
        protected abstract DbBuilder OnConfig();
        protected abstract void OnGenerate(DbGenerator generator);
    }
}