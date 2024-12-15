using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        public string[] GetTasks()
        {
            return new[] { "1", "2", "3" };
        } 
    }
}
