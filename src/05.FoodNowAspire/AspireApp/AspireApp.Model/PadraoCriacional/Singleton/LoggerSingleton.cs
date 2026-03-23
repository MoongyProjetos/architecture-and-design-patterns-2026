namespace AspireApp.Model.PadraoCriacional.Singleton;

/// <summary>
/// Exemplo implementacao Singleton: Classe Highlander - Só pode haver 1 objeto em memória
/// se já tiver instanciado, aponta para o objeto anterior, senão, instancia na primeira vez.
/// Pode ser considerado um antipadrão, porque algumas implementações não se protegem de memory leaks. 
/// O uso aceitável é em loggers, conexões com Databases e outras implementações estáticas
/// </summary>
public class LoggerSingleton
{
    private LoggerSingleton _loggerSingleton;

    public LoggerSingleton()
    {
        if (_loggerSingleton == null)
        {
            _loggerSingleton = new LoggerSingleton();
        }
    }

    public LoggerSingleton ObterLoggerSingleton()
    {
        return _loggerSingleton;
    }
}