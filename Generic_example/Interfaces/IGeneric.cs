using Generic_example.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_example.Interfaces
{
    internal interface IGeneric<T> where T : ITable, new()
    {
        void Add(T data);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
