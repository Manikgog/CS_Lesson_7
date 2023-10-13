using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_7
{
    internal class TeamLeader : IWorker
    {
        public String Name { get; }

        public TeamLeader()
        {
            this.Name = null;
        }

        public TeamLeader(String name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Бригадир " + Name;
        }

        public void Working(House house)
        {
            if(house.GetRoof() != null)
            {
                Console.WriteLine(house.ToString() + " построен");
            }
        }

    }
}
