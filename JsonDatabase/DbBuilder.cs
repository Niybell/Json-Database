using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonDatabase.TxtDb;

namespace JsonDatabase
{
    public sealed class DbBuilder
    {
        internal string DatabaseName { get; set; }
        internal string DatabasePath { get; set; }
        public void UseTxtDb(TxtDbOptions options)
        {
            DatabaseName = options.DatabaseName;
            DatabasePath = options.DatabasePath;
        }
    }
}