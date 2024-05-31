using AutoMapper;
using CashFlow.Communications.Responses.GetById;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionsBase;

namespace CashFlow.Application.UseCases.Expenses.GetById;

public class GetByIdUseCase(
    IExpensesReadOnlyRepository expensesRepository,
    IMapper autoMapping
) : IGetByIdUseCase
{
    public async Task<ResponseExpenseJson> Execute(long id)
    {
        var response = await expensesRepository.GetByIdAsync(id);
        if (response is null) throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
        return autoMapping.Map<ResponseExpenseJson>(response);
    }
}