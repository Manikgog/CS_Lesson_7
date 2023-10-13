using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_7
{
    internal class House
    {
        private IPart BaseMent = null;
        private IPart[] Walls = new Wall[4];
        private IPart Door = null;
        private IPart[] Windows = new Window[4];
        private IPart Roof = null;
        private String Name;
        

        public House()
        {
            
        }
        public House(IPart basement, IPart[] walls, IPart door, IPart[] windows, IPart roof, String name)
        {
            this.BaseMent = basement;
            this.Walls = walls;
            this.Door = door;
            this.Windows = windows;
            this.Roof = roof;
            this.Name = name;
        }
       
        public IPart GetBaseMent()
        {
            return this.BaseMent;
        }

        public void SetBaseMent(IPart baseMent)
        {
            this.BaseMent = baseMent;
        }

        public IPart[] GetWalls()
        {
            return this.Walls;
        }

        public void SetWalls(Wall wall)
        {
            for(int i = 0; i < this.Walls.Length; i++)
            {
                if (this.Walls[i] == null)
                {
                    this.Walls[i] = wall; break;
                }
            }
        }

        public IPart GetDoor()
        {
            return this.Door;
        }

        public void SetDoor(Door door)
        {
            this.Door = door;
        }

        public IPart[] GetWindows()
        {
            return this.Windows;
        }

        public void SetWindows(Window window)
        {
            for (int i = 0; i < this.Windows.Length; i++)
            {
                if (this.Windows[i] == null)
                {
                    this.Windows[i] = window; break;
                }
            }
        }

        public IPart GetRoof()
        {
            return this.Roof;
        }

        public void SetRoof(Roof roof)
        {
            this.Roof = roof;
        }

        public String GetName()
        {
            return this.Name;
        }


    }
}
