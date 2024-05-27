using AutoMapper;
using CashFlow.Communications.Responses.GetById;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Application.UseCases.Expenses.GetById;

public class GetByIdUseCase(
    IExpensesRepository expensesRepository,
    IMapper autoMapping
) : IGetByIdUseCase
{
    public async Task<ResponseExpenseJson> Execute(long id)
    {
        var response = await expensesRepository.GetByIdAsync(id);
        return autoMapping.Map<ResponseExpenseJson>(response);
    }
}