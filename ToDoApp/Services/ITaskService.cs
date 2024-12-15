using Task = ToDoApp.DataAccess.Task;

namespace ToDoApp.Services
{
    public interface ITaskService
    {
        Task[] Get();

        Task GetById(int id);

        void Add(Task task);

        void Delete(int id);

        void Put(Task task);
    }
}