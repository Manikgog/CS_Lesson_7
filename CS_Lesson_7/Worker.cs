using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_7
{
    internal class Worker : IWorker
    {
        public String Name { get; }

        public Worker()
        {
            this.Name = null;
        }

        public Worker(String name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Рабочий " + Name;
        }

        public void Working(House house)
        {
            
            if(house.GetBaseMent() == null)
            {
                Basement baseMent = new Basement("Бетонное основание.");
                house.SetBaseMent(baseMent);
                Console.WriteLine("Строю " + house.GetBaseMent().ToString());
                return;
            }

            for(int i = 0; i < house.GetWalls().Length; i++)
            {
                if (house.GetWalls()[i] == null)
                {
                    Wall wall = new Wall("Бетонная стена " + (i + 1));
                    Console.WriteLine("Строю " + wall.ToString());
                    house.SetWalls(wall);
                    return;
                }
            }

            if(house.GetDoor() == null)
            {
                Door door = new Door("Деревянная дверь");
                house.SetDoor(door);
                Console.WriteLine("Строю " + house.GetDoor().ToString());
                return;
            }

            for (int i = 0; i < house.GetWindows().Length; i++)
            {
                if (house.GetWindows()[i] == null)
                {
                    Window window = new Window("Деревянное окно " + (i + 1));
                    Console.WriteLine("Строю " + window.ToString());
                    house.SetWindows(window);
                    return;
                }
            }

            if(house.GetRoof() == null)
            {
                Roof roof = new Roof("Шиферная крыша.");
                house.SetRoof(roof);
                Console.WriteLine("Cтрою " + roof.ToString());
            }
            return;
        }


    }
}
