
namespace Celular_POO
{
    public class Celular
    {
        public string Cor;

        public string Modelo;

        public string Tamanho;

        public bool Ligado;

        public string Ligar()
        {
            return Console.WriteLine($"Ligando...");
        }

        public string Desligar()
        {
            return Console.WriteLine($"Desligando...");
        }

        public string Ligacao()
        {
            return Console.WriteLine($"Ligando..."); 
        }

        public string Mensagem()
        {
            return Console.WriteLine($"Enviando mensagem...");
        }
    }
}