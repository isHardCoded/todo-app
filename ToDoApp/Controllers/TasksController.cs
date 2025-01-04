using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.DataAccess.Entities;
using ToDoApp.Messages.Requests;
using ToDoApp.Models;
using ToDoApp.Services;

namespace ToDoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;
        private readonly IMapper _mapper;

        public TasksController(ITaskService taskService, IMapper mapper)
        {
            _taskService = taskService;
            _mapper = mapper;
        }

        [HttpGet]
        public TaskEntity[] Get()
        {
            return _taskService.Get();
        }

        // /tasks/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var task = _taskService.GetById(id);
            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        [HttpPost]
        public void Add([FromBody] TaskRequest request)
        {
            var task = _mapper.Map<TaskModel>(request);
            _taskService.Add(task);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _taskService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public void Put(TaskModel task)
        {
            _taskService.Update(task);
        }
    }
}
