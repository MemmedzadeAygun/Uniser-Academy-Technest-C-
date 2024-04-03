using GenericTask.Classes;
using GenericTask.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask.Managers
{
    internal class FastFoodManager : GenericManager<FastFood>, IFastFood
    {
        public FastFoodManager() : base(
                new List<FastFood>
                {
                    new FastFood{Id=1, Name="Burger", Price=6},
                    new FastFood{Id=2, Name="Free", Price=4}
                })    
        {
        }
    }
}
