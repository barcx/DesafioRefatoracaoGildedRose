namespace MeuAcerto.Selecao.KataGildedRose.Solucao
{
    public class ConjuradoItem : Item, IAtualizacaoStrategy
    {
        public int AtualizarPrazoVenda() => PrazoParaVenda -= 1;

        public int AtualizarQualidade()
        {
            Qualidade -= 2;
            if (PrazoParaVenda < 0)
                Qualidade -= 2;
            return Qualidade = Helper.ValidarQualidade(Qualidade);
        }
    }
}