using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
    internal class Person
    {
        public Guid id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        private int balance { get; set; }

        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if(value>1200 || value < 100)
                {
                    throw new Exception("Error");
                }
                else
                {
                    balance = value;
                }
            }
        }

    }
}
