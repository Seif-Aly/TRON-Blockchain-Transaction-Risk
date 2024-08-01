using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

public class Program
{
    private static readonly HttpClient client = new();

    public static async Task Main(string[] args)
    {
        string textxHash = "853793d552635f533aa982b92b35b00e63a1c1add062c099da2450a15119bcb2";
        var riskData = await GetRiskData(textxHash);
        Console.WriteLine($"Risk levels for transaction {textxHash} :\n{riskData}");
    }

    /// <summary>
    /// Function to get risk data by <paramref name="textHash"/>
    /// </summary>
    /// <param name="textHash"></param>
    /// <returns></returns>
    public static async Task<string> GetRiskData(string textHash)
    {
        string tronscanUrl = $"https://api.tronscan.org/api/transaction-info?hash={textHash}";
        try
        {
            HttpResponseMessage httpResponse = await client.GetAsync(tronscanUrl);
            httpResponse.EnsureSuccessStatusCode();
            string response = await httpResponse.Content.ReadAsStringAsync();
            using JsonDocument document = JsonDocument.Parse(response);
            JsonElement root = document.RootElement;
            if (root.TryGetProperty("normalAddressInfo", out JsonElement normalAddressInfoElement))
            {
                string riskResults = "";
                foreach (JsonProperty addressProperty in normalAddressInfoElement.EnumerateObject())
                {
                    string address = addressProperty.Name;
                    if (addressProperty.Value.TryGetProperty("risk", out JsonElement riskElement))
                    {
                        bool isRisk = riskElement.GetBoolean();
                        riskResults += $"Address {address} is {(isRisk ? "Risky" : "Not Risky")}\n";
                    }
                }
                return string.IsNullOrEmpty(riskResults) ? "No risk data available for addresses." : riskResults;
            }

            return "Risk data not available";
        }
        catch (HttpRequestException e)
        {
            return $"HTTP Request error: {e.Message}";
        }
        catch (Exception e)
        {
            return $"Error: {e.Message}";
        }
    }
}
