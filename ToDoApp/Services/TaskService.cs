using ToDoApp.DataAccess.Contexts;
using ToDoApp.DataAccess.Entities;

namespace ToDoApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly ToDoDbContext _dbContext;

        public TaskService(ToDoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(TaskEntity task)
        {
            _dbContext.Tasks.Add(task);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var task = _dbContext.Tasks.SingleOrDefault(x => x.Id == id);
            if (task != null)
            {
                _dbContext.Tasks.Remove(task);
                _dbContext.SaveChanges();
            }
        }

        public TaskEntity[] Get()
        {
            return _dbContext.Tasks.ToArray();
        }

        public TaskEntity GetById(int id)
        {
            return _dbContext.Tasks.SingleOrDefault(x => x.Id == id);
        }

        public void Put(TaskEntity task)
        {
            _dbContext.Tasks.Update(task);
            _dbContext.SaveChanges();
        }
    }
}