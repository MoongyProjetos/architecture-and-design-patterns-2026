using AspireApp.Services.Polly;
using Polly.CircuitBreaker;

namespace AspireApp.Tests.Polly;

public class PollyTests
{
    /// <summary>
    /// Exemplo uso do Polly com Retry
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task DeveSerCapazDeConsultarUmaAPIExternaERetentarCasoNaoConsiga()
    {
        // Given
                
        // When
        var result = await PagamentosService.ExemploRetry("https://petstore.swagger.io/v2/store/inventory");

        // Then
        Assert.True(result);
    }


    /// <summary>
    /// Exemplo uso do Polly com Retry
    /// Com polly, esperamos uma excessão após 3 tentativas 
    /// Atenção que colocamos o tempo de espera exponencial com expoente 2, 
    /// vai testar por 3 vezes, primeiro com 2 seg de timeout, 
    /// depois com 4 e por fim com 8
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task NaoDeveSerCapazDeConsultarUmaAPIExternaQueNaoExistaERetentarCasoNaoConsiga()
    {
        // Given
        var url = "https://petstore.swagger.io/v2/store/inventoree";

        // When & Then
        await Assert.ThrowsAsync<HttpRequestException>(async () =>
        {
            await PagamentosService.ExemploRetry(url);
        });
    }


    /// <summary>
    /// Exemplo uso do Polly com Circuit Breaker
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task DeveSerCapazDeConsultarUmaAPIExternaESeguirAVidaCasoNaoConsiga()
    {
        // Given

        // When
        var result = await PagamentosService.ExemploCircuitBreaker("https://petstore.swagger.io/v2/store/inventory");

        // Then
        Assert.True(result);
    }


    /// <summary>
    /// Exemplo uso do Polly com Circuit Breaker
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task NaoDeveSerCapazDeConsultarUmaAPIExternaQueNaoExistaESeguirAvida()
    {
        // Given
        var url = "https://petstore.swagger.io/v2/store/inventoree";

        // When
        var result = await PagamentosService.ExemploCircuitBreaker(url);

        // Then
        Assert.False(result);
    }


    /// <summary>
    /// Exemplo uso do Polly com Retry
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task NaoDeveSerCapazDeCancelarUmaChamadaQuePasseDeXSegundos()
    {
        // Given

        // When
        var result = await PagamentosService.ExemploComCancelationToken("https://petstore.swagger.io/v2/store/inventory", 30000);

        // Then
        Assert.True(result);
    }


    /// <summary>
    /// Exemplo uso com CancelationToken
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task DeveSerCapazDeCancelarUmaChamadaQuePasseDeXSegundos()
    {
        // Given
        var url = "https://petstore.swagger.io/v2/store/inventory";

        // When & Then
        await Assert.ThrowsAsync<TaskCanceledException>(async () =>
        {
            await PagamentosService.ExemploComCancelationToken(url, 1);
        });
    }


    /// <summary>
    /// Exemplo uso com CancelationToken
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task DeveSerCapazDeParalelizarChamadasComBulkHead()
    {
        // Given
        var url = "https://petstore.swagger.io/v2/store/inventory";

        // When
        var result = await PagamentosService.ExemploComBulkHead(url);

        // Then
        Assert.True(result);
    }
}