

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TaskListAppMAUI.DataBase;
using TaskListAppMAUI.Model;

namespace TaskListAppMAUI.ViewModel
{
    public class ToDoViewModel : ObservableObject
    {
        private readonly ToDoItemDatabase _db = new();

        ObservableCollection<ToDoModel> toDoModels;

        public ICommand RemoveItemCommand { get; }

        public ObservableCollection<ToDoModel> ToDoModels
        {
            get { return toDoModels; }
            set
            {
                if (toDoModels != value)
                {
                    toDoModels = value;
                    OnPropertyChanged(nameof(ToDoModels));
                }
            }
        }

        public ToDoViewModel()
        {
            toDoModels = new ObservableCollection<ToDoModel>();
            LoadItemsAsync();

        }

        public async Task LoadItemsAsync()
        {
            var toDoItems = await _db.GetItemsAsync();
            foreach (var item in toDoItems)
            {
                if (!ToDoModels.Contains(item))
                {
                    ToDoModels.Add(item);
                }
            }
        }

        public async Task RemoveItemAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var item = sender as ToDoModel;
            await _db.DeleteItemAsync(item);
        }


    }
}
