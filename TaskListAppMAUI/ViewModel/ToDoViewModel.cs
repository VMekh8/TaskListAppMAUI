

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.Platform;
using System.Collections.ObjectModel;
using System.Windows.Input;
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
            
        }

        private async void RemoveItem(object sender, SelectedItemChangedEventArgs e)
        {
            var item = sender as ToDoModel;
            await _db.DeleteItemAsync(item);
        }

    }
}
