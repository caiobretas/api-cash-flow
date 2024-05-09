using CashFlow.Communications.Requests.Register;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpenseJson>
{
    public RegisterExpenseValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Title cannot be empty");
        RuleFor(x => x.Title).NotNull().WithMessage("Title cannot be null");
        RuleFor(x => x.Amount).GreaterThan(0).WithMessage("Amount cannot be less than 0");
        RuleFor(x => x.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Date cannot be in the future");
        RuleFor(x => x.PaymentType).IsInEnum().WithMessage("PaymentType not valid");
    }
}