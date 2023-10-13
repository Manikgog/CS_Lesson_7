using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_7
{
    internal interface IWorker
    {
        String Name { get; }

        void Working(House house);

    }
}
