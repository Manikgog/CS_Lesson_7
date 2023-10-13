using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_7
{
    internal class Door : IPart
    {
        public string Name { get; }
        public Door()
        {
            this.Name = "Деревянная дверь.";
        }
        public Door(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Дверь " + Name;
        }
    }
}
