using TaskListAppMAUI.View;

namespace TaskListAppMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ToDoView();
        }
    }
}
    