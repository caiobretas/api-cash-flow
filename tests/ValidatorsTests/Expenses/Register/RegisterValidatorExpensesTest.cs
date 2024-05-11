using CashFlow.Application.UseCases.Expenses.Register;
using CommonTestUtilities.Requests;

namespace ValidatorsTests.Expenses.Register;

public class RegisterValidatorExpensesTest
{
    [Fact]
    public void Sucess()
    {
        // Arrange
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();
        
        // Act
        var result = validator.Validate(request);

        // Assert
        Assert.True(result.IsValid);
    }
}