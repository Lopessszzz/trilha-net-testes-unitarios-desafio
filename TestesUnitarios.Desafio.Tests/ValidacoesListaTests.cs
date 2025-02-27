using System.ComponentModel.DataAnnotations;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //DONE: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);


        // Assert
        Assert.False(resultado);
    }

    //DONE: Corrigir a anotação [Fact]
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //DONE: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //DONE: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        int resultadoEsperado = lista.Max();

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);
        

        // Assert
        //DONE: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //DONE: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9, -100 };
        int resultadoEsperado = lista.Min();

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //DONE: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(resultado, resultadoEsperado);
    }
}
