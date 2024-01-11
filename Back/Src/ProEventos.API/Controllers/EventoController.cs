using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
   public IEnumerable<Evento> _evento = new Evento[]
   {
        new()
       {
        EventoId = 1,
        Tema = "Angular 11 e NET 5",
        Local = "Porto Alegre",
        Lote = "1o Lote",
        QtdPessoas = 250,
        DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/YYYY"),
        ImagemURL = "Foto.png"
       },
        new()
       {
        EventoId = 2,
        Tema = "Angular e Suas Novidades",
        Local = "Porto Alegre",
        Lote = "12 Lote",
        QtdPessoas = 250,
        DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/YYYY"),
        ImagemURL = "Foto.png"
       }
   };

    public EventoController()
    {
       
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
       return  _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> Get(int id)
    {
       return  _evento.Where(evento => evento.EventoId==id);
    }
}
