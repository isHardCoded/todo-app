using AutoMapper;
using ToDoApp.DataAccess.Entities;
using ToDoApp.DataAccess.Repositories;
using ToDoApp.Models;

namespace ToDoApp.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;

    public TaskService(ITaskRepository taskRepository, IMapper mapper)
    {
        _taskRepository = taskRepository;
        _mapper = mapper;
    }

    public void Add(TaskModel task)
    {
        task.StartDate = DateTime.UtcNow;
        _taskRepository.Add(_mapper.Map<TaskEntity>(task));
    }

    public void Delete(int id)
    {
        _taskRepository.Delete(id);
    }

    public TaskEntity[] Get()
    {
        return _taskRepository.Get();
    }

    public TaskEntity GetById(int id)
    {
        return _taskRepository.GetById(id);
    }

    public void Update(TaskModel task)
    {
        _taskRepository.Put(_mapper.Map<TaskEntity>(task));
    }
}