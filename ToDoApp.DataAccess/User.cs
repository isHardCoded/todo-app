namespace ToDoApp.DataAccess;

public class User
{
    public int Id { get; set; }

    public string UserName { get; set; }
    
    public virtual ICollection<Task> TaskAssignedUsers { get; set; } = new List<Task>();

    public virtual ICollection<Task> TaskAuthorUsers { get; set; } = new List<Task>();
}