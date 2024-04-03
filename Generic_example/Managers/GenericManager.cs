using Generic_example.Classes;
using Generic_example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_example.Managers
{
    internal class GenericManager<T> : IGeneric<T> where T : ITable, new()
    {
        protected readonly List<T> _list;

        public GenericManager(List<T> values)
        {
            _list = values;
        }
        public void Add(T data)
        {
            _list.Add(data);
        }

        public void Delete(int id)
        {
            _list.RemoveAt(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _list;
        }

        public T GetById(int id)
        {
            T data = _list[id];
            foreach (var searchedWriter in _list)
            {
                if (id == searchedWriter.Id)
                {
                    return searchedWriter;
                }
            }
            return data;
        }

       
    }
}
