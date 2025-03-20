using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle
    {
		private double height = 1.0;
		private double width = 1.0;

		public double Height
		{
			get { return height; }
			set { 
				if(value > 0)
				{
					height = value;
				}
				else
				{
                    Console.WriteLine($"Het is verboden een hoogte van {value} in te stellen!");
                }
            }
		}

		public double Width
		{
			get { return width; }
			set { 
				if(value > 0)
				{
					width = value;
				}
				else
				{
                    Console.WriteLine($"Het is verboden een breedte van {value} in te stellen!");
				}
			}
		}

        public double Area()
        {
            return Math.Round(width * height, 2);
        }

		public void ShowInfo()
		{
			Console.WriteLine($"Een rechthoek met een breedte van {width}m en een hoogte van {height}m heeft een oppervlakte van {Area()}m².");
		}
    }
}
