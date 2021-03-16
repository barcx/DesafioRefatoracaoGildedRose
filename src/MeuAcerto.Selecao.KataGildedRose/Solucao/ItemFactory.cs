namespace MeuAcerto.Selecao.KataGildedRose.Solucao
{
    public class ItemFactory
    {
        public static Item CriarItem(string nome, int prazoParaVenda, int qualidade)
        {
            return nome switch
            {
                "Queijo Brie Envelhecido" => new QueijoBrieEnvelhecidoItem { Nome = nome, PrazoParaVenda = prazoParaVenda, Qualidade = qualidade },
                "Dente do Tarrasque" => new DenteDoTarrasqueItem { Nome = nome, PrazoParaVenda = prazoParaVenda, Qualidade = qualidade },
                "Ingressos para o concerto do Turisas" => new IngressosItem { Nome = nome, PrazoParaVenda = prazoParaVenda, Qualidade = qualidade },
                "Bolo de Mana Conjurado" => new ConjuradoItem { Nome = nome, PrazoParaVenda = prazoParaVenda, Qualidade = qualidade },
                _ => new ItemPadrao { Nome = nome, PrazoParaVenda = prazoParaVenda, Qualidade = qualidade }
            };
        }
    }
}
