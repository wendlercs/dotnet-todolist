namespace Todolist.Communication.Responses
{
    public class ResponseGetAllTasksJson
    {
        public List<ResponseGetTaskJson> Tasks { get; set; } = [];
    }
}
