
namespace Celular_POO
{
    public class Celular
    {
        public string Cor;

        public string Modelo;

        public string Tamanho;

        public bool Ligado;

        public void Ligar()
        {
           Console.WriteLine($"Ligando...");
        }

        public void Desligar()
        {
           Console.WriteLine($"Desligando...");
        }

        public void Ligacao()
        {
            Console.WriteLine($"Ligando para..."); 
        }

        public void Mensagem()
        {
            Console.WriteLine($"Enviando mensagem...");
        }
    }
}