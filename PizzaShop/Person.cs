﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    internal class Person
    {
        private int balance { get; set; }

        public int Balance
        {
            get { return balance; }
            set
            {
                if (value < 30)
                {
                    throw new Exception("Wrong");
                }
                else
                {
                    balance = value;
                }
            }
        }
        public string? CardNumber { get; set; }
        public string ?ExpDate { get; set; }
        public string? CVV { get; set; }
    }
}
