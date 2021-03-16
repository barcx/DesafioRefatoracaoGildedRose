namespace MeuAcerto.Selecao.KataGildedRose.Solucao
{
    public class IngressosItem : Item, IAtualizacaoStrategy
    {
        public int AtualizarPrazoVenda() => PrazoParaVenda -= 1;

        public int AtualizarQualidade()
        {
            if (PrazoParaVenda < 0)
            {
                Qualidade = 0;
            }
            else if (PrazoParaVenda <= 5)
            {
                Qualidade += 3;
            }
            else if (PrazoParaVenda <= 10)
            {
                Qualidade += 2;
            }
            else
            {
                Qualidade += 1;
            }
            return Qualidade = Helper.ValidarQualidade(Qualidade);
        }
    }
}