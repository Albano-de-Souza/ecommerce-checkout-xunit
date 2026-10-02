using EcommerceCheckout.App;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    private readonly PedidoService _service = new PedidoService();

    [Fact]
    public void GerarCodigoRastreio_DeveRetornarMascaraExata()
    {
        var resultado = _service.GerarCodigoRastreio("sudeste", 42);

        Assert.Equal("SUDESTE-0042", resultado);
    }

    [Fact]
    public void CalcularPontosFidelidade_DeveRetornar30ParaCompraDe150()
    {
        var resultado = _service.CalcularPontosFidelidade(150);

        Assert.Equal(30, resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_ClienteVipAbaixoDe200_DeveRetornarTrue()
    {
        var resultado = _service.TemDireitoAFreteGratis(150, true);

        Assert.True(resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_NaoVipAbaixoDe200_DeveRetornarFalse()
    {
        var resultado = _service.TemDireitoAFreteGratis(150, false);

        Assert.False(resultado);
    }
}