using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_7
{
    internal class Team
    {
        private IWorker[] Workers;
        private TeamLeader leader;
        public Team() { }
        public Team(int numberOfWorkers, String nameOfLeader) 
        {
            Workers = new IWorker[numberOfWorkers];
            for(int i = 0; i < numberOfWorkers; i++)
            {
                Workers[i] = new Worker("Рабочий " + (i + 1));
            }
            leader= new TeamLeader(nameOfLeader);
        }

        public IWorker[] GetWorkers()
        {
            return Workers;
        }

        public TeamLeader GetLeader()
        {
            return leader;
        }

        public override string ToString()
        {
            StringBuilder team= new StringBuilder();
            for(int i = 0; i < Workers.Length; i++)
            {
                team.Append(Workers[i].ToString());
            }
            return team.ToString();
        }

        public void BuildHouse(House house)
        {
            int i = 0;
            while(house.GetRoof() == null)
            {
                if(i == Workers.Length - 1)
                {
                    i = 0; continue;
                }
                i++;
                Workers[i].Working(house);

                
            }
            leader.Working(house);
           
        }

    }
}
