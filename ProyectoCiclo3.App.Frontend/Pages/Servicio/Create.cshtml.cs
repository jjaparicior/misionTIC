using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
using Microsoft.AspNetCore.Authorization;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    [Authorize]
    public class FormServicioModel : PageModel
    {
 
        private readonly RepositorioServicio repositorioServicio;
        private readonly RepositorioUsuario repositorioUsuario;
        private readonly RepositorioEncomienda repositorioEncomienda;

        public IEnumerable<Usuario> Usuarios {get;set;}
        public IEnumerable<Encomienda> Encomiendas {get;set;}

        [BindProperty]
        public Servicio Servicio {get;set;}
 
        public FormServicioModel(RepositorioServicio repositorioServicio, RepositorioUsuario repositorioUsuario, RepositorioEncomienda repositorioEncomienda)
       {
            this.repositorioServicio=repositorioServicio;
            this.repositorioUsuario=repositorioUsuario;
            this.repositorioEncomienda=repositorioEncomienda;
       }

        public void OnGet()
    {
        Usuarios=repositorioUsuario.GetAll();
        Encomiendas=repositorioEncomienda.GetAll();
    }
 
        public IActionResult OnPost(int origen, int destino, string fecha, string hora, int encomienda)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }            
            Servicio = repositorioServicio.Create(origen, destino, fecha, hora, encomienda);
            return RedirectToPage("./List");
        }
    }
}