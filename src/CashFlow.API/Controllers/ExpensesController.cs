using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communications.Requests.Register;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        RegisterExpenseUseCase useCase = new();
        var response = useCase.Execute(request);
        return Created(string.Empty, response);
    }
}