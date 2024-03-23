using SQLite;

namespace TaskListAppMAUI.Model
{
    public class ToDoModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string TaskName { get; set; }

        public string Description { get; set; }

        public  uint Prority { get; set; }

        public DateOnly DeadLineDate { get; set; }

    }
}
