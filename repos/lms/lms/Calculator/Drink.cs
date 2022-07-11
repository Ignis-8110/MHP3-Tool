using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lms.Calculator
{
    public class Drink
    {
        public Drink(string name, int raw)
        {
            this.Name = name;
            this.AddedRaw = raw;    
        }
        public string Name { get; private set; }
        public int AddedRaw { get; private set; }


    }
}
