using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Birds
    {
        public string kind;
        public int speed;
        public double weight;
        public virtual string gotvoice()
        {
            return "You will write a voice here";
        }
    }
}
