using Polly;
using Polly.CircuitBreaker;

namespace AspireApp.Services.Polly;

public static class PagamentosService
{
    public static async Task<bool> ExemploRetry(string urlalvo)
    {
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));

        HttpClient client = new();

        await retryPolicy.ExecuteAsync(async () =>
        {
            var response = await client.GetAsync(urlalvo);
            response.EnsureSuccessStatusCode();
        });
        return true;
    }


    public static async Task<bool> ExemploCircuitBreaker(string urlalvo)
    {
        var breakerPolicy = Policy
            .Handle<HttpRequestException>()
            .CircuitBreakerAsync(
                exceptionsAllowedBeforeBreaking: 2,
                durationOfBreak: TimeSpan.FromSeconds(30));

        try
        {
            HttpClient client = new();

            await breakerPolicy.ExecuteAsync(async () =>
            {
                var response = await client.GetAsync(urlalvo);
                response.EnsureSuccessStatusCode();
            });
        }
        catch (BrokenCircuitException)
        {
            Console.WriteLine("Circuito aberto. Ignorando chamada.");
            throw;
        }
        catch (HttpRequestException)
        {
            Console.WriteLine("Falha na chamada HTTP.");
            return false;
        }

        return true;
    }


    public static async Task<bool> ExemploComCancelationToken(string urlalvo, int tempo)
    {
        var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(tempo));
        try
        {
            HttpClient client = new();
            var response = await client.GetAsync(urlalvo, cts.Token);
            response.EnsureSuccessStatusCode();
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("Timeout atingido.");
            throw; 
        }
        return true;
    }


    public static async Task<bool> ExemploComBulkHead(string urlalvo)
    {
        var bulkhead = Policy.BulkheadAsync<HttpResponseMessage>(maxParallelization: 3, maxQueuingActions: 2);

        await bulkhead.ExecuteAsync(async () =>
        {
            HttpClient client = new();
            return await client.GetAsync(urlalvo);
        });

        return true;
    }
}
