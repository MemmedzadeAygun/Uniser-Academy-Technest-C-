using GenericTask.Classes;
using GenericTask.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask.Managers
{
    internal class DrinksManager : GenericManager<Drinks>, IDrinks
    {
        public DrinksManager() : base(
             new List<Drinks>
             {
                 new Drinks{Id=1, Name="Cola", Price=1},
                 new Drinks{Id=2, Name="Cappy", Price=2},
                 new Drinks{Id=3, Name="Fanta", Price=1}
             })

        {
        }
    }
}
