using Microsoft.AspNetCore.Mvc;
using WMVCLivros.Models;

namespace WMVCLivros.Controllers
{
    public class QueryController : Controller
    {
        private readonly Contexto contexto;

        public QueryController(Contexto context)
        {
            contexto = context;
        }

        public IActionResult Clientes(string Nome)
        {
            List<Clientes> lista = new List<Clientes>();
            if (Nome == null) 
            {         
                lista = contexto.Clientes.OrderBy(o => o.Nome).ToList();

            }
            else
            {               
                lista = contexto.Clientes.Where(c => c.Nome == Nome).OrderBy(o => o.Nome).ToList();
            }
            return View(lista);
        }

        public IActionResult Pesquisa()
        {
            return View();
        }
    }
}