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
        public Task[] Get()
        {
            return dbContext.Tasks.ToArray();
        }

        // /tasks/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var task = dbContext.Tasks.SingleOrDefault(x=>x.Id == id);
            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        [HttpPost]
        public void Add([FromBody] Task task)
        {
            dbContext.Tasks.Add(task);
            dbContext.SaveChanges();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var task = dbContext.Tasks.SingleOrDefault(x => x.Id == id);
            if (task != null)
            {
                dbContext.Tasks.Remove(task);
                dbContext.SaveChanges();
            }

            return Ok();
        }

        [HttpPut]
        public void Put(Task task)
        {
            dbContext.Tasks.Update(task);
            dbContext.SaveChanges();
        }
    }
}
