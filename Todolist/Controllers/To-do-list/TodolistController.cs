using Microsoft.AspNetCore.Mvc;
using Todolist.Application.UseCases.Create;
using Todolist.Application.UseCases.Delete;
using Todolist.Application.UseCases.GetAll;
using Todolist.Application.UseCases.GetById;
using Todolist.Application.UseCases.Update;
using Todolist.Communication.Requests;
using Todolist.Communication.Responses;

namespace Todolist.Controllers.To_do_list;

public class TodolistController : TodolistBaseController
{
    [HttpGet("get-all-tasks")]
    [ProducesResponseType(typeof(ResponseGetAllTasksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetAllTasks()
    {
        var response = new GetAllTasksUseCase().Execute();

        return Ok(response);

    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseGetTaskByIdJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetTaskById([FromRoute] int id)
    {
        var response = new GetByIdUseCase().Execute(id);

        return Ok(response);
    }
    

    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateTaskJson),StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestTodoJson request)
    {
        var response = new CreateTaskUsecase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTodoJson request)
    {
        var useCase = new UpdateUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        var useCase = new DeleteUseCase();

        useCase.Execute(id);

        return NoContent();
    }
}
