using MeuAcerto.Selecao.KataGildedRose.Solucao;
using Xunit;

namespace MeuAcerto.Selecao.KataGildedRose.Testes
{
    public class IngressosItemTest
    {
        [Fact]
        public void IngressosItem_IncrementarQualidade_QuandoPrazoMaiorDoQueDez()
        {
            // Arrange
            var qualidade = 20;
            var esperado = qualidade + 1;
            var prazoParaVenda = 15;
            var sut = new ContextoStrategy("Ingressos para o concerto do Turisas", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }

        [Fact]
        public void IngressosItem_IncrementarQualidadeDuasVezesMaisRapido_QuandoPrazoEstaEntreSeisEDez()
        {
            // Arrange
            var qualidade = 20;
            var esperado = qualidade + 2;
            var prazoParaVenda = 7;
            var sut = new ContextoStrategy("Ingressos para o concerto do Turisas", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }

        [Fact]
        public void IngressosItem_IncrementarQualidadeTresVezesMaisRapido_QuandoPrazoEstaEntreZeroECinco()
        {
            // Arrange
            var qualidade = 20;
            var esperado = qualidade + 3;
            var prazoParaVenda = 3;
            var sut = new ContextoStrategy("Ingressos para o concerto do Turisas", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }

        [Fact]
        public void IngressosItem_QualidadeDeveriaSerZeroOrMenorDoZero_QuandoPrazoParaVendaNegativo()
        {
            // Arrange
            var qualidade = 10;
            var esperado = 0;
            var prazoParaVenda = 0;
            var sut = new ContextoStrategy("Ingressos para o concerto do Turisas", prazoParaVenda, qualidade);

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
            var prazoParaVenda = 3;
            var sut = new ContextoStrategy("Ingressos para o concerto do Turisas", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.qualidade);
        }

        [Fact]
        public void IngressosItem_DecrementarPrazoParaVenda()
        {
            // Arrange
            var qualidade = 10;
            var prazoParaVenda = 10;
            var esperado = prazoParaVenda - 1;
            var sut = new ContextoStrategy("Ingressos para o concerto do Turisas", prazoParaVenda, qualidade);

            // Act
            var resultado = sut.Atualizar();

            // Assert XUnit
            Assert.Equal(esperado, resultado.prazoParaVenda);
        }
    }
}
