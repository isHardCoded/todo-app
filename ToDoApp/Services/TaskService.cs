using Microsoft.EntityFrameworkCore;
using ToDoApp.DataAccess;
using Task = ToDoApp.DataAccess.Task;

namespace ToDoApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly ToDoDbContext dbContext;

        public TaskService(ToDoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(Task task)
        {
            dbContext.Tasks.Add(task);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var task = dbContext.Tasks.SingleOrDefault(x => x.Id == id);
            if (task != null)
            {
                dbContext.Tasks.Remove(task);
                dbContext.SaveChanges();
            }
        }

        public Task[] Get()
        {
            return dbContext.Tasks.ToArray();
        }

        public Task GetById(int id)
        {
            return dbContext.Tasks.SingleOrDefault(x => x.Id == id);
        }

        public void Put(Task task)
        {
            dbContext.Tasks.Update(task);
            dbContext.SaveChanges();
        }
    }
}