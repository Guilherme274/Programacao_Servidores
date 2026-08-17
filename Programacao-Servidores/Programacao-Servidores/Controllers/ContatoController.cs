using Microsoft.AspNetCore.Mvc;
using Programacao_Servidores.Models;

namespace Programacao_Servidores.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            ListaContatosModel modelo = new ListaContatosModel();
            return View(modelo);
        }
    }
}
