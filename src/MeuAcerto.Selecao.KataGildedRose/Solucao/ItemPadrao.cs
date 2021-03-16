namespace MeuAcerto.Selecao.KataGildedRose.Solucao
{
    public class ItemPadrao : Item, IAtualizacaoStrategy
    {
        public int AtualizarPrazoVenda() => PrazoParaVenda -= 1;

        public int AtualizarQualidade()
        {
            Qualidade -= 1;
            if (PrazoParaVenda < 0)
                Qualidade -= 1;
            return Qualidade = Helper.ValidarQualidade(Qualidade);
        }
    }
}