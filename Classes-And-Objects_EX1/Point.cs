using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects_EX1
{
    public class Point
    {
        private int xPos, yPos;

        public void SetPoint(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

        public void ShowPoint()
        {
            Console.WriteLine($"xPos: {xPos}, yPos: {yPos}");
        }
    }
}
