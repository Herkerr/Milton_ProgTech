// 1, Olvassunk kódot!
// 2, Ismerjük fel milyen tervezési mintát láthatunk a kódban?

using System;

public interface IApiMock
{
    bool ValidateApiKey(string apiKey);
}

public class SimpleApiMock : IApiMock
{
    public bool ValidateApiKey(string apiKey)
    {
        Console.WriteLine("Checking API key...");
        bool isValid = apiKey == "valid_key";
        Console.WriteLine("API key validation result: " + isValid);
        return isValid;
    }
}

public class ApiMockWithLogging : IApiMock
{
    private readonly IApiMock apiMock;

    public ApiMockWithLogging(IApiMock apiMock)
    {
        this.apiMock = apiMock;
    }

    public bool ValidateApiKey(string apiKey)
    {
        Console.WriteLine("Logging request...");
        Console.WriteLine("API key: " + apiKey);

        bool isValid = apiMock.ValidateApiKey(apiKey);

        Console.WriteLine("Logging response...");
        Console.WriteLine("API key validation result: " + isValid);
        return isValid;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IApiMock apiMock = new SimpleApiMock();
        IApiMock apiMockWithLogging = new ApiMockWithLogging(apiMock);

        bool isValidApiKey = apiMockWithLogging.ValidateApiKey("valid_key");
        Console.WriteLine("API key is valid: " + isValidApiKey);
    }
}
