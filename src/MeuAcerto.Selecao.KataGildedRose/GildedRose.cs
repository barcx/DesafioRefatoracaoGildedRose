using System.Collections.Generic;
using MeuAcerto.Selecao.KataGildedRose.Solucao;

namespace MeuAcerto.Selecao.KataGildedRose
{
    class GildedRose
    {
        IList<Item> Itens;
        public GildedRose(IList<Item> Itens)
        {
            this.Itens = Itens;
        }

        public void AtualizarQualidade()
        {
            foreach (var item in Itens)
            {
                var itemParaAtualizar = new ContextoStrategy(item.Nome, item.PrazoParaVenda, item.Qualidade);
                var result = itemParaAtualizar.Atualizar();
                item.PrazoParaVenda = result.prazoParaVenda;
                item.Qualidade = result.qualidade;
            }
        }
    }
}
