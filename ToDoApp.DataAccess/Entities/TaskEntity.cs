namespace ToDoApp.DataAccess.Entities;

public class TaskEntity
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Status { get; set; }

    public int? Priority { get; set; }

    public string? Tags { get; set; }

    public DateTimeOffset StartDate { get; set; }

    public int AuthorUserId { get; set; }

    public int? AssignedUserId { get; set; }

    public DateTimeOffset EndDate { get; set; }

    public virtual UserEntity AuthorUser { get; set; }

    public virtual UserEntity? AssignedUser { get; set; }
}