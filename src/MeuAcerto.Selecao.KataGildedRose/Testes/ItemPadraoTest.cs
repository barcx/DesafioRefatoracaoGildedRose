using MeuAcerto.Selecao.KataGildedRose.Solucao;
using Xunit;

namespace MeuAcerto.Selecao.KataGildedRose.Testes
{
    public class ItemPadraoTest
    {
        [Fact]
        public void ItemPadrao_DecrementarQualidade_QuandoPrazoParaVendaPositivo()
        {
            // Arrange
            var qualidade = 20;
            var esperado = qualidade - 1;
            var prazoParaVenda = 10;
            var sut = new ContextoStrategy("Corselete +5 DEX", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }

        [Fact]
        public void ItemPadrao_DecrementarQualidadeDuasVezesMaisRapido_QuandoPrazoParaVendaNegativo()
        {
            // Arrange
            var qualidade = 20;
            var esperado = qualidade - 2;
            var prazoParaVenda = 0;
            var sut = new ContextoStrategy("Corselete +5 DEX", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }

        [Fact]
        public void ItemPadrao_QualidadeNaoPodeSerNegativo()
        {
            // Arrange
            var qualidade = 0;
            var esperado = qualidade;
            var prazoParaVenda = 10;
            var sut = new ContextoStrategy("Corselete +5 DEX", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }

        [Fact]
        public void ItemPadrao_DecrementarPrazoParaVenda()
        {
            // Arrange
            var qualidade = 10;
            var prazoParaVenda = 10;
            var esperado = prazoParaVenda - 1;
            var sut = new ContextoStrategy("Corselete +5 DEX", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.prazoParaVenda);
        }
    }
}
