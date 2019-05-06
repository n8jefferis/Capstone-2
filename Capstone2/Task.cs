using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    class Task
    {
        //properties
        private string TaskName { get; set; }
        public string DueDate { get; set; }
        public string TaskDescription { get; set; }
        public string UserName { get; set; }
        public bool IsComplete { get; set; }
        public string Status
        {
            get;

            set;

        }

        //constructors
        public Task(string TaskName, string DueDate, string UserName, string TaskDescription)
        {
            this.TaskName = TaskName;
            this.DueDate = DueDate;
            this.UserName = UserName;
            this.TaskDescription = TaskDescription;

        }

        //methods
    }
}
