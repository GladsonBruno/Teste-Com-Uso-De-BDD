using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using CalculoDeDesconto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteDesconto
{
    [Binding]
    public sealed class TesteDescontoStepDefinition
    {
        double _preco;
        double _desconto;
        double _precoFinal;
        //Obtendo a entrada do preço
        [Given("um produto que custa (.*) reais")]
        public void CarregarPreco(double preco)
        {
            this._preco = preco;
        }
        //Quando solicitado o desconto calcular o desconto e calcular o preco final
        [When("eu solicitar o calculo do desconto de (.*) %")]
        public void CalcularDesconto(double desconto)
        {
            this._desconto = desconto;
            _precoFinal = CalculorDeDesconto.calcularDesconto(_preco, _desconto);
        }
        //Estão o programa irá verificar se o resultado obtido esta correto
        [Then("o programa retornará que o preço final será de (.*)")]
        public void verificarResultado(double precoFinal)
        {
            Assert.AreEqual(precoFinal, _precoFinal);
        }
    }
}
