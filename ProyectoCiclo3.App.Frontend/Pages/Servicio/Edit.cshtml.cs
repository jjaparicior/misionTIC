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
    public class EditServicioModel : PageModel
    {
       private readonly RepositorioServicio repositorioServicio;
       [BindProperty]
        public Servicio Servicio {get;set;}
 
        public EditServicioModel(RepositorioServicio repositorioServicio)
       {
            this.repositorioServicio=repositorioServicio;
       }
 
        public IActionResult OnGet(int servicioId)
        {
                Servicio=repositorioServicio.GetServicioWithId(servicioId);
                return Page();
 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Servicio.id>0)
            {
            Servicio = repositorioServicio.Update(Servicio);
            }
            return RedirectToPage("./List");
        }

    }
}