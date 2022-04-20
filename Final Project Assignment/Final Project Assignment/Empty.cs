using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Assignment
{
    internal class Empty //ที่ว่างเปล่า 0.3%
    {
        private double sum = 0;

        public void addEmpty(string l, string ll)
        {
            if (l == "ประเภทที่อยู่อาศัย")
            {
                double live = 0.3;
                double assess = Convert.ToDouble(ll);
                this.sum = assess * live;
            }
        }
        public double getEmpty()
        {
            return this.sum;
        }
    }
}
