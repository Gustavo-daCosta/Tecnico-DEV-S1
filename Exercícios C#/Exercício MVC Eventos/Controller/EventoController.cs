using Exercício_MVC_Eventos.Model;
using Exercício_MVC_Eventos.View;

namespace Exercício_MVC_Eventos.Controller
{
    public class EventoController
    {
        Evento evento = new Evento();
        EventoView eventoView = new EventoView();

        public void Listar() {
            List<Evento> eventos = evento.Ler();

            eventoView.Listar(eventos);
        }

        public void Cadastrar() {
            List<Evento> eventos = evento.Ler();

            Evento novoEvento = eventoView.Cadastrar(eventos);
            evento.Inserir(novoEvento);
        }
    }
}