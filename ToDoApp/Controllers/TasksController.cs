using Microsoft.AspNetCore.Mvc;
using ToDoApp.DataAccess;

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
        public string[] GetTasks()
        {
            return dbContext.Tasks.Select(x => x.Title).ToArray();
        } 
    }
}
