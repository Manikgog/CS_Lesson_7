using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_7
{
    internal class Window : IPart
    {
        public string Name { get; }
        public Window()
        {
            this.Name = "Деревянное окно.";
        }
        public Window(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Окно " + Name;
        }
    }
}
