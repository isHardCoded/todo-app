using Microsoft.AspNetCore.Mvc;
using ToDoApp.Services;
using Task = ToDoApp.DataAccess.Task;

namespace ToDoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService taskService;

        public TasksController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet]
        public Task[] Get()
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
        public void Add([FromBody] Task task)
        {
            taskService.Add(task);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            taskService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public void Put(Task task)
        {
            taskService.Put(task);
        }
    }
}
