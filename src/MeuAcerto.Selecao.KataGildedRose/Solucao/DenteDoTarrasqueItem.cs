namespace MeuAcerto.Selecao.KataGildedRose.Solucao
{
    public class DenteDoTarrasqueItem : Item, IAtualizacaoStrategy
    {

        // Por ser um item lendário não atualiza qualidade.
        public int AtualizarQualidade() => Qualidade;

        public int AtualizarPrazoVenda()
        {
            // Por ser um item lendário não atualiza o prazo de venda.
            return PrazoParaVenda;
        }
    }
}