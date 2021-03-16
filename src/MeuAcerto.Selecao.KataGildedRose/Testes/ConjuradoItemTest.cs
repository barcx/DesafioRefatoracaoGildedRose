using MeuAcerto.Selecao.KataGildedRose.Solucao;
using Xunit;

namespace MeuAcerto.Selecao.KataGildedRose.Testes
{
    public class ConjuradoItemTest
    {
        [Fact]
        public void ConjuradoItem_DecrementarQualidade_QuandoPrazoParaVendaPositivo()
        {
            // Arrange
            var qualidade = 20;
            var esperado = qualidade - 2;
            var prazoParaVenda = 10;
            var sut = new ContextoStrategy("Bolo de Mana Conjurado", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }

        [Fact]
        public void ConjuradoItem_DecrementarQualidadeDuasVezesMaisRapido_QuandoPrazoParaVendaNegativo()
        {
            // Arrange
            var qualidade = 20;
            var esperado = qualidade - 4;
            var prazoParaVenda = 0;
            var sut = new ContextoStrategy("Bolo de Mana Conjurado", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }

        [Fact]
        public void ConjuradoItem_QualidadeNaoPodeSerNegativo()
        {
            // Arrange
            var qualidade = 0;
            var esperado = qualidade;
            var prazoParaVenda = 10;
            var sut = new ContextoStrategy("Bolo de Mana Conjurado", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }

        [Fact]
        public void ConjuradoItem_DecrementarPrazoParaVenda()
        {
            // Arrange
            var qualidade = 10;
            var prazoParaVenda = 10;
            var esperado = prazoParaVenda - 1;
            var sut = new ContextoStrategy("Bolo de Mana Conjurado", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.prazoParaVenda);
        }
    }
}