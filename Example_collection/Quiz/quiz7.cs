// 1, Olvassunk kódot!
// 2, Ismerjük fel milyen tervezési mintát láthatunk a kódban?

using System;

public interface IApiBackend
{
    void ProcessRequest(string apiKey, string request);
}

public class RealApiBackend : IApiBackend
{
    public void ProcessRequest(string apiKey, string request)
    {
        Console.WriteLine("Processing request in the real API backend...");
        Console.WriteLine("Request: " + request);
        Console.WriteLine("API key: " + apiKey);
        Console.WriteLine("Request processed successfully.");
    }
}

public class ApiAuthGateway : IApiBackend
{
    private readonly IApiBackend realApiBackend;
    private readonly string validApiKey;

    public ApiAuthGateway(string validApiKey)
    {
        this.realApiBackend = new RealApiBackend();
        this.validApiKey = validApiKey;
    }

    public void ProcessRequest(string apiKey, string request)
    {
        if (apiKey != validApiKey)
        {
            Console.WriteLine("Invalid API key. Access denied.");
            return;
        }
        realApiBackend.ProcessRequest(apiKey, request);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string apiKey = "valid_key";
        IApiBackend apiBackend = new ApiAuthGateway(apiKey);

        string request = "Sample request data";
        apiBackend.ProcessRequest(apiKey, request);
    }
}
