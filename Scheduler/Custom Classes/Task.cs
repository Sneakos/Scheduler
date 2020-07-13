using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class Task
    {
        public string Text { get; set; }
        public DateTime DueDate { get; set; }
        public People OwnedBy { get; set; }
        public bool Recurring { get; set; }
        public bool Alternate { get; set; }
        public int DaysBetween { get; set; }
        public bool Completed { get; set; }

        public static Task CreateNewTask(Task oldTask)
        {
            int person = (int)oldTask.OwnedBy;

            if (oldTask.Alternate)
            {
                person = ((person + 1) % 4) + 1;
            }

            People owner = (People)person;

            DateTime dueDate = oldTask.DueDate;
            
            if (oldTask.Recurring)
            {
                dueDate = dueDate.AddDays(oldTask.DaysBetween);
            }

            Task newTask = new Task
            {
                Text = oldTask.Text,
                DueDate = dueDate,
                OwnedBy = owner,
                Recurring = oldTask.Recurring,
                DaysBetween = oldTask.DaysBetween,
                Completed = false
            };

            return newTask;
        }
    }
}
