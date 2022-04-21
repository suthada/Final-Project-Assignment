using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Assignment
{
    internal class Trade //พาณิชยกรรม 
    {
        private double sum = 0;
        public void addTrade(string b, string bb)
        {
            if (b == "ประเภทพาณิชยกรรม")
            {
                double live = 0.005;
                double assess = Convert.ToDouble(bb);
                this.sum = assess * live;
            }
        }
        public double getTrade()
        {
            return this.sum;
        }
    }
}
