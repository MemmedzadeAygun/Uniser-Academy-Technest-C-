using Generic_example.Classes;
using Generic_example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_example.Managers
{
    internal class WriterManager: GenericManager<Writer>, IWriter
    {
        
        public WriterManager():base(
            new List<Writer>
            {
                new Writer{Id=1, FirstName="George", LastName="Orwel"},
                new Writer{Id=2, FirstName="Fyodor", LastName="Dostoyevski"},
            })
            
        {
            
        }

        public void Update(int id, Writer writer)
        {

            foreach (var updatedWriter in _list)
            {
                if (updatedWriter.Id == id)
                {
                    updatedWriter.FirstName = writer.FirstName;
                    updatedWriter.LastName = writer.LastName;
                }
            }
        }
    }
}

