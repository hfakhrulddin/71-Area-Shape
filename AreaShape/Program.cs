﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
        {
            new Square(5, "Square #1"),
            new Circle(3, "Circle #1"),
            new Rectangle( 4, 5, "Rectangle #1")
        };

            System.Console.WriteLine("Shapes Collection");
            foreach (Shape s in shapes)
            {
                System.Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
