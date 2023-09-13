namespace Tests;

public class BatatinhaTestes
{
    [Fact]
    public void TesteDeImplementacao()
    {
        ICalculadoraMaluca multiplicadinho = new Multiplicadinho();

        var calculadoraService = new CalculadoraService(multiplicadinho);
        
        var resultado = calculadoraService.MeDa10();
        
        Assert.Equal(10, resultado);
    }
}

public class CalculadoraService
{
    private readonly ICalculadoraMaluca _calculadoraMaluca;

    public CalculadoraService(ICalculadoraMaluca implementacao)
    {
        _calculadoraMaluca = implementacao;
    }
    
    public int MeDa10()
    {
        return _calculadoraMaluca.Calcula10();
    }
}

public interface ICalculadoraMaluca
{
    int Calcula10();
}

public class Somadinho : ICalculadoraMaluca
{
    public int Calcula10()
    {
        return 2 + 2 + 2 + 2 + 2;
    }
}

public class Multiplicadinho : ICalculadoraMaluca
{
    public int Calcula10()
    {
        return 2 * 5;
    }
}