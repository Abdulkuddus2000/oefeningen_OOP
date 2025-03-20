﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Triangle
    {
		private double @base = 1.0;
		private double height = 1.0;

		public double Height
		{
			get { return height; }
			set {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine($"Het is verboden een hoogte van {value} in te stellen!");
                }
            }
		}

		public double Base
		{
			get { return @base; }
			set { 
                if (value > 0)
                {
					@base = value;
                }
                else
                {
                    Console.WriteLine($"Het is verboden een basis van {value} in te stellen!");
                }
            }
		}

		public double Area()
		{
            return Math.Round((@base * height) / 2, 2);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Een driehoek met een basis van {@base}m en een hoogte van {height}m heeft een oppervlakte van {Area()}m².");
        }

	}
}
