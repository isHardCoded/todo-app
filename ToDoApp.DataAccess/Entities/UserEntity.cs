namespace ToDoApp.DataAccess.Entities;

public class UserEntity
{
    public int Id { get; set; }

    public string UserName { get; set; }

    public virtual ICollection<TaskEntity> TaskAssignedUsers { get; set; } = new List<TaskEntity>();

    public virtual ICollection<TaskEntity> TaskAuthorUsers { get; set; } = new List<TaskEntity>();
}