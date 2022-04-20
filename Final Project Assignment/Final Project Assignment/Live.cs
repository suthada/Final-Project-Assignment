using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Assignment
{
    internal class Live //ที่อยู่อาศัย 30%
    {
        private double sum = 0;

        public void addLive(string k,string kk)
        {
            if (k == "ประเภทที่อยู่อาศัย")
            {
                double live = 0.03;
                double assess = Convert.ToDouble(kk);
                this.sum = assess * live;
            }
        }
        public double getLive()
        {
            return this.sum;
        }
       

    }
}
