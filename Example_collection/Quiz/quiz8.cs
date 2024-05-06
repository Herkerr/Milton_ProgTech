// 1, Olvassunk kódot!
// 2, Ismerjük fel milyen tervezési mintát láthatunk a kódban?

using System;
using System.Collections.Generic;

public interface ISecurityEvent
{
    void NotifyInvalidApiKey(string apiKey);
}

public class SIEMSystem : ISecurityEvent
{
    public void NotifyInvalidApiKey(string apiKey)
    {
        Console.WriteLine("SIEM System Alert: Invalid API key detected - " + apiKey);
    }
}

public class ApiBackend
{
    private readonly List<string> apiKeys;

    public ApiBackend()
    {
        apiKeys = new List<string> { "valid_key1", "valid_key2", "valid_key3" };
    }

    public bool IsApiKeyValid(string apiKey)
    {
        return apiKeys.Contains(apiKey);
    }
}