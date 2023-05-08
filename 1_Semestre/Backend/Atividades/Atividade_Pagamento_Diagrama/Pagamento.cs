
namespace Atividade_Pagamento_Diagrama
{
    public class Pagamento
    {
        private DateTime Data { get; set; }
        
        public float Valor { get; set; }
        
        public Pagamento()
        {
        }

        public Pagamento(DateTime data, float valor)
        {
            Data = data;
            Valor = valor;
        }

        public string Cancelar()
        {
            return 0;
            Console.WriteLine($"Operação cancelada.");
        }
    }
}