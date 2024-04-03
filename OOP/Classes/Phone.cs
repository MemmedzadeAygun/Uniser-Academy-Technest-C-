using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    internal class Phone:Electronic
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();

		private int price;

		public override int Price
		{
			get { return price; }
			set 
			{ 
				if(value<100 && value > 6000)
				{
					throw new Exception("Error");
				}
				else
				{
					price = value;
				}
			}
		}

		private  string operatingsystem;

		public override string OperatingSystem
		{
			get { return operatingsystem; }
			set
			{ 
				if(value!="Android" || value != "IOS")
				{
					throw new Exception("Wrong");
				}
				else
				{
					operatingsystem = value;
				}
			}
		}

		private int cameramegapixel;

		public int CameraMegaPixel
		{
			get { return cameramegapixel; }
			set 
			{
				if(value<4 && value > 128)
				{
					throw new Exception("Wrong");
				}
				else
				{
					cameramegapixel = value;
				}
			}
		}

	}
}
