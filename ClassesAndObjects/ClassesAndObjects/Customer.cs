using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Customer
    {
        private int ıd;
        public string name, surname, city;

        public int Id { get => ıd; set => ıd = value; }
        public string Name
        {
            get => name;
            set => name = value.ToUpper();
        }
        public string Surname
        {
            get => surname;
            set => surname = value.ToUpper();
        }
        public string City
        {
            get => city;
            set => city = value;
        }
    }
}
