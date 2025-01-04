using System;
using System.Collections.Generic;

namespace ToDoApp.DataAccess;

public class Task
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

    public virtual User AuthorUser { get; set; }

    public virtual User? AssignedUser { get; set; }
}