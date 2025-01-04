using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.DataAccess.Entities;
using ToDoApp.Messages.Requests;
using ToDoApp.Services;

namespace ToDoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService taskService;
        private readonly IMapper _mapper;

        public TasksController(ITaskService taskService, IMapper mapper)
        {
            this.taskService = taskService;
            _mapper = mapper;
        }

        [HttpGet]
        public TaskEntity[] Get()
        {
            return taskService.Get();
        }

        // /tasks/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var task = taskService.GetById(id);
            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        [HttpPost]
        public void Add([FromBody] TaskRequest request)
        {
            var task = _mapper.Map<TaskEntity>(request);
            task.StartDate = DateTime.UtcNow;
            taskService.Add(task);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            taskService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public void Put(TaskEntity task)
        {
            taskService.Put(task);
        }
    }
}
