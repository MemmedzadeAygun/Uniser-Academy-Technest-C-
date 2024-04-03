using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Class
{
    public class Rectangle
    {
		private int side1;

		public int Side1
		{
			get { return side1; }
			set 
			{
				if (value <= 0)
				{
					throw new ArgumentException("Wrong!");
				}
				else 
				{
					side1 = value;
				}
			}
		}

		private int side2;

		public int Side2
		{
			get { return side2; }
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Wrong!");
				}
				else
				{
					side2 = value;
				}
			}
		}
		
		public double CalcAreaOfRectangle()
		{
			return side1 * side2;
		}
	}
}
