using TaskListAppMAUI.DataBase;
using TaskListAppMAUI.Model;

namespace TaskListAppMAUI.View;

public partial class AddNewTaskWindow : ContentPage
{
	private readonly ToDoItemDatabase db = new ToDoItemDatabase();
	public AddNewTaskWindow()
	{
		InitializeComponent();

		CloseWindowBtn.Clicked += async (o, e) => await Navigation.PopModalAsync();

		DeadLinePicker.MinimumDate = DateTime.Now;

		SubmitBtn.Clicked += async (o, e) =>
        {
			await db.SaveItemAsync(new ToDoModel
			{
				TaskName = TaskNameTxtEntry.Text,
				Description = DescriptionTxtEntry.Text,
				Prority = Convert.ToInt32(PriorityPicker.SelectedItem),
				DeadLineDate = DeadLinePicker.Date
			});
			Console.WriteLine("Success to send data");
        };
		
	}
}