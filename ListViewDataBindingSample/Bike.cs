using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewDataBindingSample
{
    class Bike
    {
        public int BikeID { get; set; }
        public int DailyRate { get; set; }

        public int Deposit { get; set; }


        public override string ToString()
        {
            return  ": Bike Hired:ID " + BikeID + ", DailyRate " + DailyRate + ", Deposit " + Deposit;
        }
    }
}
