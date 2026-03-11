using Calculadora;

namespace Calculadora.Test;

public class OperacionesMatematicasTest
{
    private readonly OperacionesMatematicas _operacionesMatematicas = new();

    [Fact]
    public void Sumar_DosPositivos_RetornaSuma()
    {
        //Arrage
        var a = 2;
        var b = 3;
        //Act
        var resultado = _operacionesMatematicas.Sumar(a, b);
        //Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Sumar_NegativoMasPositivo_RetornaValorCorrecto()
    {
        //Arrage
        var a = -2;
        var b = 3;
        //Act
        var resultado = _operacionesMatematicas.Sumar(a, b);
        //Assert
        Assert.Equal(1, resultado);
    }

    [Fact]
    public void Sumar_CeroMasCero_RetornaCero()
    {
        //Arrage
        var a = 0;
        var b = 0;
        //Act
        var resultado = _operacionesMatematicas.Sumar(a, b);
        //Assert
        Assert.Equal(0, resultado);
    }
}