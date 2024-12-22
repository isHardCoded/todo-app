namespace ToDoApp.Messages.Requests;

public class TaskRequest
{
    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Status { get; set; }

    public int? Priority { get; set; }

    public string? Tags { get; set; }

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset EndDate { get; set; }
}