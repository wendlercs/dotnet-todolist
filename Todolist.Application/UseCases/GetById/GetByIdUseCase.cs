using Todolist.Communication.Responses;

namespace Todolist.Application.UseCases.GetById;

public class GetByIdUseCase
{
    public ResponseGetTaskByIdJson Execute(int id)
    {
        return new ResponseGetTaskByIdJson
        {
            Id = 1,
            Name = "Lavar Cozinha",
            Description = "Lavar louça e passar pano no chão",
            DateLimit = DateTime.Now,
            Priority = Communication.Enums.PriorityEnum.high,
            Status = Communication.Enums.StatusEnum.pending
        };
    }
}
