
using Evento_MVC.Model;

namespace Evento_MVC.View
{
    public class EventosView
    {
        public void Listar(List<Eventos> eventos)
        {
            foreach (var item in eventos)
            {
                Console.WriteLine($"\n Nome: {item.Nome}");
                Console.WriteLine($" Descricao: {item.Descricao}");
                Console.WriteLine($" Data: {item.Data}");
            }
        }

        public Eventos Cadastrar()
        {
            Eventos novoEvento = new Eventos();

            Console.WriteLine($"Informe o nome: ");
            novoEvento.Nome = Console.ReadLine();

            Console.WriteLine($"Informe a descricao: ");
            novoEvento.Descricao = Console.ReadLine();

            Console.WriteLine($"Informe a data: ");
            novoEvento.Data = Console.ReadLine();

            return novoEvento;
        }
    }
}