namespace CashFlow.Communications.Responses;

public class ResponseErrorJson
{
    public ResponseErrorJson(string errorMessage)
    {
        ErrorMessages.Add(errorMessage);
    }

    public ResponseErrorJson(List<string> errorMessages)
    {
        ErrorMessages = errorMessages;
    }

    public List<string> ErrorMessages { get; } = [];
}