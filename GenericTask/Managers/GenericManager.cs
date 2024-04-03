using GenericTask.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask.Managers
{
    internal class GenericManager<T> : IGenerics<T> where T : IProduct, new()
    {
        protected readonly List<T> _product;
        public GenericManager(List<T> values)
        {
            _product=values;
        }
        public void Add(T data)
        {
            _product.Add(data);
            Console.WriteLine("Product elave edildi");
        }

        public void Delete(int id)
        {
            _product.RemoveAt(id);
            Console.WriteLine($"{id} - Product silindi");
        }

        public IEnumerable<T> GetAll()
        {
            return _product;
        }
    }
}
