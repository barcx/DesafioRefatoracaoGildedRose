namespace MeuAcerto.Selecao.KataGildedRose.Solucao
{
    public class Helper
    {
        public static int ValidarQualidade(int qualidade)
        {
            if (qualidade < 0)
            {
                qualidade = 0;
            }
            else if (qualidade > 50)
            {
                qualidade = 50;
            }
            return qualidade;
        }
    }
}