using Evento_MVC.Model;
using Evento_MVC.Controller;

Eventos eventos = new Eventos();

EventosController controller = new EventosController();

controller.Cadastrar();

controller.ListarEventos();