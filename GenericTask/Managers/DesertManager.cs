using GenericTask.Classes;
using GenericTask.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask.Managers
{
    internal class DesertManager : GenericManager<Desert>, IDesert
    {
        public DesertManager() : base(
                new List<Desert> 
                {
                    new Desert{Id=1, Name="Chocolate", Indrigients="cacao, milk, butter etc.", Price=1},
                    new Desert{Id=2, Name="Cheesecake",Indrigients="flour, sugar , egg etc.", Price=5}
                })
            
        {
        }
    }
}
