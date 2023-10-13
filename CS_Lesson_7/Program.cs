using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfWorkers = 10;
            do {
                try
                {
                    Console.Write("Введите количество рабочих: ");
                    numbersOfWorkers = Convert.ToInt32(Console.ReadLine());
                } catch (Exception ex)
                {
                    String errorMessage = ex.Message;
                    Console.WriteLine(errorMessage);
                    continue;
                }
                finally
                {
                   
                }
                break; 
            } while (true);



            Team team = new Team(5, "Бригадир Василий");
            House house= new House();
            team.BuildHouse(house);
        }


        public static void Lesson()
        {
            try
            {

            }
            catch (Exception ex)
            {
                String errorString = ex.Message; // сообщение об исключении
                String errorSource = ex.Source;     // хранит имя объекта или сборки, которое вызвало исключение
                String errorTraceMethods = ex.StackTrace; // возвращает строковое представление представление
                                                          // стека вызовов, котороые привели к возникновению исключений
            }
            finally
            {

            }
        }
    }
}
