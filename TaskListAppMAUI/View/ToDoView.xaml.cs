namespace TaskListAppMAUI.View;

public partial class ToDoView : ContentPage
{
	public ToDoView()
	{
		InitializeComponent();
		AddTaskBtn.Clicked += async (o, e) => { await Navigation.PushModalAsync(new AddNewTaskWindow()); };
	}
}