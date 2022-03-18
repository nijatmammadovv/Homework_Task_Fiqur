using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Task_Fiqur.Models
{
    internal class Square:Figure
    {
        internal int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }
        public override int CalcArea()
        {
            return Side * Side;
        }
    }
}
