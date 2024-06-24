using Todolist.Communication.Enums;

namespace Todolist.Communication.Responses;

public class ResponseGetTaskByIdJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityEnum Priority { get; set; }
    public DateTime DateLimit { get; set; }
    public StatusEnum Status { get; set; }
}
