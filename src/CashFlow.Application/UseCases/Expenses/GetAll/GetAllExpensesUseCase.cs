using AutoMapper;
using CashFlow.Communications.Responses;
using CashFlow.Communications.Responses.GetAll;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Application.UseCases.Expenses.GetAll;

public class GetAllExpensesUseCase(
    IExpensesRepository expensesRepository,
    IMapper autoMapping) : IGetAllExpensesUseCase
{
    public async Task<ResponseExpensesJson> Execute()
    {
        var result = await expensesRepository.GetAllAsync();

        return new ResponseExpensesJson
        {
            Expenses = autoMapping.Map<List<ResponseShortExpensesJson>>(result)
        };
    }
}