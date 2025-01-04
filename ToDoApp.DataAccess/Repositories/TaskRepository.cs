using ToDoApp.DataAccess.Contexts;
using ToDoApp.DataAccess.Entities;

namespace ToDoApp.DataAccess.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly ToDoDbContext _dbContext;

    public TaskRepository(ToDoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public TaskEntity[] Get()
    {
        return _dbContext.Tasks.ToArray();
    }

    public TaskEntity GetById(int id)
    {
        return _dbContext.Tasks.SingleOrDefault(x => x.Id == id);
    }

    public void Add(TaskEntity task)
    {
        _dbContext.Tasks.Add(task);
        _dbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        var task = _dbContext.Tasks.SingleOrDefault(x => x.Id == id);
        if (task == null) return;
        _dbContext.Tasks.Remove(task);
        _dbContext.SaveChanges();
    }

    public void Put(TaskEntity task)
    {
        _dbContext.Tasks.Update(task);
        _dbContext.SaveChanges();
    }
}