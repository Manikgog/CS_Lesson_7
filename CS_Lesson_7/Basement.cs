using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_7
{
    internal class Basement : IPart
    {
        public string Name { get; }
        public Basement() {
            this.Name = "Бетонный фундамент.";
        }
        public Basement(string name) 
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Фундамент " + Name;
        }
    }
}
