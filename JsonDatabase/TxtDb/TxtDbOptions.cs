using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonDatabase.TxtDb
{
    public class TxtDbOptions
    {
        public TxtDbOptions(string databaseName, string databasePath)
        {
            DatabaseName = databaseName;
            DatabasePath = databasePath;
        }

        public string DatabaseName { get; set; }
        public string DatabasePath { get; set; }

    }
}