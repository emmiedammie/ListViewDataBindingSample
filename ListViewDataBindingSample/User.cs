using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewDataBindingSample
{
    class User
    {
        public  string Name { get; set; }

        public  int Age { get; set; }

        public Bike Hire { get; set; }

        public override string ToString()
        {
            return Name + ", " + Age + " years old" + Hire;
        }
    }
}
