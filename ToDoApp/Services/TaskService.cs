using ToDoApp.DataAccess.Contexts;
using ToDoApp.DataAccess.Entities;

namespace ToDoApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly ToDoDbContext dbContext;

        public TaskService(ToDoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(TaskEntity task)
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

        public TaskEntity[] Get()
        {
            return dbContext.Tasks.ToArray();
        }

        public TaskEntity GetById(int id)
        {
            return dbContext.Tasks.SingleOrDefault(x => x.Id == id);
        }

        public void Put(TaskEntity task)
        {
            dbContext.Tasks.Update(task);
            dbContext.SaveChanges();
        }
    }
}