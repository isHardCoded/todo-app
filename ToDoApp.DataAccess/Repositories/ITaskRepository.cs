using ToDoApp.DataAccess.Entities;

namespace ToDoApp.DataAccess.Repositories;

public interface ITaskRepository
{
    TaskEntity[] Get();

    TaskEntity GetById(int id);

    void Add(TaskEntity task);

    void Delete(int id);

    void Put(TaskEntity task);
}