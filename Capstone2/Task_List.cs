using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    class Task_List
    {
        //vars
        List<string> tasks = new List<string>();
        //constructors
        public Task_List(string task)
        {


        }
        //methods
        public void Options()
        {
            Console.WriteLine("Welcome to Task Manager!" +
                "/n     1.  List tasks" +
                "/n     2.  Add task" +
                "/n     3.  Mark task complete" +
                "/n     5.  Quit" +
                "/n What would you like to do?");
            string answer = Console.ReadLine();
            Validate.ValidateOptions(answer);

            if (answer == "1")
            {
                ListTasks();
            }
            else if (answer == "2")
            {

            }
            else if (answer == "3")
            {

            }
            else if (answer == "4")
            {

            }
            else if (answer == "5")
            {

            }
        }





        public void ListTasks()
        {
            int i;
            for (i = 0; i < tasks.Count; i++)
            {


                string task = tasks[i];
                Console.WriteLine("LIST TASKS" +
                      "/n Done?    Due Date    Team Member     Description" +
                      "/n" + [i].TaskName +[i].UserName + [i].TaskDescription);
            }
            Options();



        }

        public void AddTask()
        {

        }

        public void DeleteTask()
        {

        }

        public void CompleteTask()
        {

        }
    }



    }

