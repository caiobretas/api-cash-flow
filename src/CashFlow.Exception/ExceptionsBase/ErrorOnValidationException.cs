namespace CashFlow.Exception.ExceptionsBase;

public class ErrorOnValidationException(List<string> errorMessages) : CashFlowException
{
    public List<string> ErrorMessages { get; set; } = errorMessages;
}