using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;

namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class ListServicioModel : PageModel
    {
        private readonly RepositorioServicio repositorioServicio;
        [BindProperty]
        public Servicio Service {get;set;}
        public IEnumerable<Servicio> Servicio {get;set;}
 
    public ListServicioModel(RepositorioServicio repositorioServicio)
    {
        this.repositorioServicio=repositorioServicio;
     }
 
    public void OnGet()
    {
        Servicio=repositorioServicio.GetAll();
    }

    public IActionResult OnPost()
    {
        if(Service.id>0)
        {
            repositorioServicio.Delete(Service.id);
        }
        return RedirectToPage("./List");
    }

    }
}