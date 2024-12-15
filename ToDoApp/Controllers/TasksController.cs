using Microsoft.AspNetCore.Mvc;
using ToDoApp.DataAccess;
using Task = ToDoApp.DataAccess.Task;

namespace ToDoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ToDoDbContext dbContext;

        public TasksController(ToDoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public Task[] GetTasks()
        {
            return dbContext.Tasks.ToArray();
        } 
    }
}
