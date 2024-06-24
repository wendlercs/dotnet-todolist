using Todolist.Communication.Responses;

namespace Todolist.Application.UseCases.GetAll;

public class GetAllTasksUseCase
{
    public ResponseGetAllTasksJson Execute()
    {
        return new ResponseGetAllTasksJson()
        {
            Tasks = new List<ResponseGetTaskJson>
            {
                new ResponseGetTaskJson
                {
                    Id = 1,
                    Name = "Lavar Cozinha",
                    Description = "Lavar louça e passar pano no chão",
                    DateLimit = DateTime.Now,
                    Priority = Communication.Enums.PriorityEnum.high,
                    Status = Communication.Enums.StatusEnum.pending,
                },

                new ResponseGetTaskJson
                {
                    Id = 2,
                    Name = "Lavar escritório",
                    DateLimit = DateTime.Now,
                    Description = "Tirar poeira e passar pano no chão",
                    Priority = Communication.Enums.PriorityEnum.high,
                    Status = Communication.Enums.StatusEnum.pending,
                }
            }
        };
    }

}
