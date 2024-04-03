using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask.İnterfaces
{
    internal interface IGenerics<T> where T: IProduct, new()
    {
        void Add(T data);
        void Delete(int id);
        IEnumerable<T> GetAll();
    }
}
