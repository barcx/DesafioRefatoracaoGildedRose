using MeuAcerto.Selecao.KataGildedRose.Solucao;
using Xunit;

namespace MeuAcerto.Selecao.KataGildedRose.Testes
{
    public class QueijoBrieEnvelhecidoItemTest
    {
        [Fact]
        public void QueijoBrieEnvelhecidoItem_IncrementarQualidade_QuandoPrazoParaVendaPositivo()
        {
            // Arrange
            var qualidade = 20;
            var esperado = qualidade + 1;
            var prazoParaVenda = 10;
            var sut = new ContextoStrategy("Queijo Brie Envelhecido", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }

        [Fact]
        public void QueijoBrieEnvelhecidoItem_IncrementarQualidadeDuasVezesMaisRapido_QuandoPrazoParaVendaNegativo()
        {
            // Arrange
            var qualidade = 20;
            var esperado = qualidade + 2;
            var prazoParaVenda = -10;
            var sut = new ContextoStrategy("Queijo Brie Envelhecido", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }


        [Fact]
        public void QueijoBrieEnvelhecidoItem_QualidadeNaoPodeSerMaiorDoCinquenta()
        {
            // Arrange
            var qualidade = 50;
            var esperado = 50;
            var prazoParaVenda = 10;
            var sut = new ContextoStrategy("Queijo Brie Envelhecido", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }

        [Fact]
        public void QueijoBrieEnvelhecidoItem_DecrementarPrazoParaVenda()
        {
            // Arrange
            var qualidade = 10;
            var prazoParaVenda = 10;
            var esperado = prazoParaVenda - 1;
            var sut = new ContextoStrategy("Queijo Brie Envelhecido", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.prazoParaVenda);
        }
    }
}
