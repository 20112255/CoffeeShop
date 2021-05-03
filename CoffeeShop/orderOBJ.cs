using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class orderOBJ
    {

        string name;

        int coffee;

        int donuts;

        public orderOBJ(string name, int coffee, int donuts)
        {
            this.Name = name;
            this.Coffee = coffee;
            this.Donuts = donuts;
        }

        public string Name { get => name; set => name = value; }
        public int Coffee { get => coffee; set => coffee = value; }
        public int Donuts { get => donuts; set => donuts = value; }

        public override string ToString()
        {
            return this.name + " : " + this.donuts + " " + this.coffee;
        }
    }
}
