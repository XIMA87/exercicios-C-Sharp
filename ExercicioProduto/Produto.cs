using System.Globalization;

namespace Exercicio_Produto
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        
        public double ValorTotalEmEstoque() 
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) //void não retorna valor de saida
        {
            Quantidade += quantidade; // Quantidade = local do objeto. quantidade = valor que sera alterado
        }

        public void RemoverProdutos(int quantidade) //void não retorna valor de saida
        {
            Quantidade -= quantidade; // Quantidade = local do objeto. quantidade = valor que sera alterado
        }

        //ToString converte o objeto para string
        public override string ToString() //override = sobreposição que indica que a operação veio de outra classe
        {
            return Nome 
            + ", $ " 
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}