using ToDoApp.DataAccess.Entities;
using ToDoApp.Models;

namespace ToDoApp.Services;

public interface ITaskService
{
    TaskEntity[] Get();

    TaskEntity GetById(int id);

    void Add(TaskModel task);

    void Delete(int id);

    void Update(TaskModel task);
}