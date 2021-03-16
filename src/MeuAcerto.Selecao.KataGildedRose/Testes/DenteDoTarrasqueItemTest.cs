using MeuAcerto.Selecao.KataGildedRose.Solucao;
using Xunit;

namespace MeuAcerto.Selecao.KataGildedRose.Testes
{
    public class DenteDoTarrasqueItemTest
    {
        private readonly int _qualidade = 80;
        private readonly int _prazoParaVenda = 0;

        [Fact]
        public void DenteDoTarrasqueItem_NaoDecrementatQualidade()
        {
            // Arrange
            var sut = new ContextoStrategy("Dente do Tarrasque", _prazoParaVenda, _qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(_qualidade, resultado.qualidade);
        }

        [Fact]
        public void DenteDoTarrasqueItem_NaoDecrementaPrazoParaVenda()
        {
            // Arrange
            var sut = new ContextoStrategy("Dente do Tarrasque", _prazoParaVenda, _qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(_prazoParaVenda, resultado.prazoParaVenda);
        }
    }
}
