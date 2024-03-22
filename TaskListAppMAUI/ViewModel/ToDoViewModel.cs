

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.Platform;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TaskListAppMAUI.DataBase;
using TaskListAppMAUI.Model;

namespace TaskListAppMAUI.ViewModel
{
    public class ToDoViewModel : ObservableObject
    {
        ToDoItemDatabase _db = new ToDoItemDatabase();

        ObservableCollection<ToDoModel> toDoModels;

        public ObservableCollection<ToDoModel> ToDoModels
        {
            get { return toDoModels; }
            set { SetProperty(ref toDoModels, value); }
        }

        public ToDoViewModel()
        {
            toDoModels = new ObservableCollection<ToDoModel>();

            ToDoModels.Add(new ToDoModel()
            {
                Id = 1,
                TaskName = "Test",
                Description = "Test",
                Prority = 1
            });
        }

  

    }
}
