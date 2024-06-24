using Todolist.Communication.Requests;
using Todolist.Communication.Responses;

namespace Todolist.Application.UseCases.Create;

public class CreateTaskUsecase
{
    public ResponseCreateTaskJson Execute(RequestTodoJson request)
    {
        var response = new ResponseCreateTaskJson()
        {
            Priority = request.Priority,
            Status = request.Status,
            Name = request.Name,
            Description = request.Description,
            DateLimit = request.DateLimit,
        };

        return response;
    }
}
