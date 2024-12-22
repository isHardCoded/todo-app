namespace ToDoApp.DataAccess;

public class User
{
    public int Id { get; set; }

    public string UserName { get; set; }
    
    public List<Task> Tasks { get; set; }
}