using TaskListAppMAUI.DataBase;
using TaskListAppMAUI.Model;
using TaskListAppMAUI.ViewModel;

namespace TaskListAppMAUI.View;

public partial class AddNewTaskWindow : ContentPage
{
    private readonly ToDoItemDatabase _db = new ToDoItemDatabase();
    private readonly ToDoViewModel _viewModel;
    public AddNewTaskWindow(ToDoViewModel td)
    {
        InitializeComponent();
        _viewModel = td;

        CloseWindowBtn.Clicked += async (o, e) => await Navigation.PopModalAsync();

        DeadLinePicker.MinimumDate = DateTime.Now;

        SubmitBtn.Clicked += async (o, e) =>
        {
            var item = new ToDoModel
            {
                TaskName = TaskNameTxtEntry.Text,
                Description = DescriptionTxtEntry.Text,
                Prority = Convert.ToInt32(PriorityPicker.SelectedItem),
                DeadLineDate = DeadLinePicker.Date
            };

            await _db.SaveItemAsync(item);
            Console.WriteLine("Success to send data");
            await _viewModel.LoadItemsAsync();
        };
    }
}
