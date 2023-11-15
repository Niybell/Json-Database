using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using JsonDatabase.Database.Entity;
using JsonDatabase.TxtDb;
using Newtonsoft.Json;

namespace JsonDatabase.Database
{
    public class DatabaseController
    {
        private string _dbPath = "";
        public void CreateNewDatabase(TxtDbOptions options)
        {
            _dbPath = @$"{options.DatabasePath}\{options.DatabaseName}";
            Directory.CreateDirectory(_dbPath);
            
            System.Console.WriteLine("JsonDatabase: Created new database.");
        }
        public void CreateNewTable<T>(Table<T> table, string name)
        {
            Directory.CreateDirectory(@$"{_dbPath}\{name}");
            
            FileStream stream = File.Create(@$"{_dbPath}\{name}\Table.json");
            stream.Close();

            System.Console.WriteLine($"JsonDatabase: Create {name} table.");
        }
        public async Task<List<T>> GetTableElements<T>(string name)
        {
            string text = await File.ReadAllTextAsync(@$"{_dbPath}\{name}\Table.json");
            
            if (text == "") return new List<T>();

            return JsonConvert.DeserializeObject<T[]>(text).ToList();
        }
        public async Task SyncChanges<T>(List<T> elements, string name)
        {
            File.Delete(@$"{_dbPath}\{name}\Table.json");
            await File.WriteAllTextAsync(@$"{_dbPath}\{name}\Table.json", JsonConvert.SerializeObject(elements));
        }
    }
}