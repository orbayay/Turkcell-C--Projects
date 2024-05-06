using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Falcon:Birds
    {
        public string name;
        public string color;

        public override string gotvoice()
        {
            return "Cik Cik";
        }
    }
}
