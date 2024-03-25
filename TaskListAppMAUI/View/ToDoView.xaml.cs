using TaskListAppMAUI.ViewModel;

namespace TaskListAppMAUI.View;

public partial class ToDoView : ContentPage
{
    private ToDoViewModel _viewModel = new ToDoViewModel();

    public ToDoView()
    {
        InitializeComponent();
        BindingContext = _viewModel;
        AddTaskBtn.Clicked += async (o, e) => { await Navigation.PushModalAsync(new AddNewTaskWindow(_viewModel)); };
    }
}