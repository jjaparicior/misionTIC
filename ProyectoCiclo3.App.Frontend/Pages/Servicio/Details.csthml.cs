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
    public class DetailsServicioModel : PageModel
    {
       private readonly RepositorioServicio repositorioServicio;
              public Servicio Servicio {get;set;}
 
        public DetailsServicioModel(RepositorioServicio repositorioServicio)
       {
            this.repositorioServicio=repositorioServicio;
       }
 
        public IActionResult OnGet(int servicioId)
        {
                Servicio=repositorioServicio.GetServicioWithId(servicioId);
                return Page();
 
        }
    }
}