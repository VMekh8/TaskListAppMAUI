using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskListAppMAUI.Model
{
    public class ToDoModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string TaskName { get; set; }

        public string Description { get; set; }

        public  uint Prority { get; set; }

        public DateTime DeadLineDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
