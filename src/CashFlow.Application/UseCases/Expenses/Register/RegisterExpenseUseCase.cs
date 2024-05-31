using AutoMapper;
using CashFlow.Communications.Requests.Register;
using CashFlow.Communications.Responses.Register;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception.ExceptionsBase;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase(
    IExpensesWriteOnlyRepository repository,
    IUnitOfWork unitOfWork,
    IMapper autoMapping) : IRegisterExpenseUseCase
{
    public async Task<ResponseRegisterExpenseJson> Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);

        var expense = autoMapping.Map<Expense>(request);

        await repository.AddAsync(expense);

        await unitOfWork.CommitAsync();

        return autoMapping.Map<ResponseRegisterExpenseJson>(expense);
    }

    private void Validate(RequestRegisterExpenseJson request)
    {
        var validator = new RegisterExpenseValidator();
        var result = validator.Validate(request);

        if (result.IsValid) return;

        var errors = result.Errors.Select(x => x.ErrorMessage).ToList();
        throw new ErrorOnValidationException(errors);
    }
}