using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_7
{
    internal class Wall : IPart
    {
        public string Name { get; }
        public Wall()
        {
            this.Name = "Бетонные стены.";
        }
        public Wall(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Стена " + Name;
        }
    }
}
