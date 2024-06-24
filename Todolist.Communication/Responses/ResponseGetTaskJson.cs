using Todolist.Communication.Enums;

namespace Todolist.Communication.Responses;

public class ResponseGetTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DateLimit { get; set; }
    public PriorityEnum Priority { get; set; }
    public StatusEnum Status { get; set; }
}
