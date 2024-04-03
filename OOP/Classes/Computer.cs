using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    internal class Computer:Electronic
    {
        public string Id { get;private set; } = Guid.NewGuid().ToString();

		private int price;

		public override int Price
		{
			get { return price; }
			set 
			{ 
				if(value<1000 && value > 12000)
				{
					throw new Exception("Error");
				}
				else
				{
					price = value;
				}
			}
		}

		private string operatingsystem;

		public override string OperatingSystem
		{
			get { return operatingsystem; }
			set 
			{ 
				if(value!="Windows" && value!="Linux" && value != "Macos")
				{
					throw new Exception("Error");
				}
				else
				{
					operatingsystem = value;
				}
			}
		}

		private string processortype;

		public string ProcessorType
		{
			get { return processortype; }
			set 
			{ 
				if(value!="Intel" && value != "Ryzen")
				{
					throw new Exception("Wrong");
				}
				else
				{
					processortype = value;
				}
			}
		}

		private int ram;

		public int Ram
		{
			get { return ram; }
			set 
			{
				if(value<4 && value > 128)
				{
					throw new Exception("Error");
				}
				else
				{
					ram = value;
				}
			}
		}

	}
}
