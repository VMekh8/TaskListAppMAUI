using SQLite;
using TaskListAppMAUI.Model;

namespace TaskListAppMAUI.DataBase
{
    public class ToDoItemDatabase
    {
        private SQLiteAsyncConnection _dataBase;

        async Task Init()
        {
            if (_dataBase is not null)
                return;

            else
            {
                _dataBase = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
                await _dataBase.CreateTableAsync<ToDoModel>();
                Console.WriteLine(Constants.DatabasePath);
            }
        }

        public async Task<List<ToDoModel>> GetItemsAsync()
        {
            await Init();
            return await _dataBase.Table<ToDoModel>().ToListAsync();
        }

        public async Task<ToDoModel> GetItemByIdAsync(int id)
        {
            await Init();
            return await _dataBase.Table<ToDoModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(ToDoModel item)
        {
            await Init();
            if (item.Id != 0)
                return await _dataBase.UpdateAsync(item);
            else
                return await _dataBase.InsertAsync(item);
        }

        public async Task<int> DeleteItemAsync(ToDoModel item)
        {
            await Init();
            return await _dataBase.DeleteAsync(item);
        }
    }
}


