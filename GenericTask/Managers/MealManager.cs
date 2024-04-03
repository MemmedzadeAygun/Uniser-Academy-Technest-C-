using GenericTask.Classes;
using GenericTask.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask.Managers
{
    internal class MealManager : GenericManager<Meal>, IMeal
    {
        public MealManager() : base(
            new List<Meal>
            {
                new Meal{Id=1, Name="Soup", Indrigients="water, spice, butter etc.", Price=3},
                new Meal{Id=2, Name="Rice", Indrigients="rice, spice, butter etc.", Price=4},
            })

        {
        }
    }
}
