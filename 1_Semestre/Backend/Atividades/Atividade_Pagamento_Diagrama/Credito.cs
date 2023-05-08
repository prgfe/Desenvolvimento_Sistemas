
namespace Atividade_Pagamento_Diagrama
{
    public class Credito : Cartao
    {
        private float Limite;

    public Credito(float limite)
    {
        if(limite < saldo)
        {
            throw new Exception ($"Limite menor que o saldo. Escolha outra opção de pagamento.");
        }
        this.Limite = limite;
    }
    }
}