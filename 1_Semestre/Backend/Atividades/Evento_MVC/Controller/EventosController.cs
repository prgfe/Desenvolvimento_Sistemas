using Evento_MVC.View;
using Evento_MVC.Model;
namespace Evento_MVC.Controller
{
    public class EventosController
    {
        Eventos evento = new Eventos();

        EventosView eventosView = new EventosView();

        List<Eventos> exibir = new List<Eventos>();

        public void ListarEventos()
        {
            List<Eventos> eventos = evento.Ler();

            eventosView.Listar(eventos);
        }

        public void Cadastrar()
        {
            Eventos novoEvento = eventosView.Cadastrar();

            evento.Inserir(novoEvento);
        }
    }
}