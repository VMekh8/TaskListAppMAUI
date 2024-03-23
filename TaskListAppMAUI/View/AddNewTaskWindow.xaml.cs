namespace TaskListAppMAUI.View;

public partial class AddNewTaskWindow : ContentPage
{
	public AddNewTaskWindow()
	{
		InitializeComponent();

		CloseWindowBtn.Clicked += async (o, e) => await Navigation.PopModalAsync();

		DeadLinePicker.MinimumDate = DateTime.Now;
	}
}