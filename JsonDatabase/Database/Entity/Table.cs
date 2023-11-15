using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonDatabase.Database.Entity
{
    public class Table<T>
    {
        private DatabaseController _controller;
        private string _name;
        private List<T> _items = new List<T>();

        public Table(DatabaseController controller, string name)
        {
            _controller = controller;
            _name = name;
        }

        public async Task<List<T>> GetAllAsync() => await _controller.GetTableElements<T>(_name);
        public async Task SaveChanges() => await _controller.SyncChanges(_items, _name);
        public async Task AddAsync(T item) 
        {
            _items.Add(item);
            await _controller.SyncChanges<T>(_items, _name);
        }
        public async Task RemoveAsync(T item)
        {
            _items.Remove(item);
            await _controller.SyncChanges<T>(_items, _name);
        }
        public async Task UpdateAsync(T oldItem, T newItem)
        {
            _items.Remove(oldItem);
            _items.Add(newItem);
            await _controller.SyncChanges<T>(_items, _name);
        }
    }
}