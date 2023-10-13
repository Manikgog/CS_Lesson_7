using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_7
{
    internal class Roof : IPart
    {
        public string Name { get; }
        public Roof()
        {
            this.Name = "Деревянная крыша.";
        }
        public Roof(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Крыша " + Name;
        }

    }
}
