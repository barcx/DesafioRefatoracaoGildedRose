namespace MeuAcerto.Selecao.KataGildedRose.Solucao
{
    public class ContextoStrategy
    {
        private readonly IAtualizacaoStrategy _atualizacaoStrategy;

        public ContextoStrategy(string nome, int prazoParaVenda, int qualidade)
        {
            _atualizacaoStrategy = ItemFactory.CriarItem(nome, prazoParaVenda, qualidade) as IAtualizacaoStrategy;
        }

        public (int prazoParaVenda, int qualidade) Atualizar() => (_atualizacaoStrategy.AtualizarPrazoVenda(), _atualizacaoStrategy.AtualizarQualidade());
    }
}