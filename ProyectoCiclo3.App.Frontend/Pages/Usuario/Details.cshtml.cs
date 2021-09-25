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
    public class DetailsUsuarioModel : PageModel
    {
       private readonly RepositorioUsuario repositorioUsuario;
              public Usuario Usuario {get;set;}
 
        public DetailsUsuarioModel(RepositorioUsuario repositorioUsuario)
       {
            this.repositorioUsuario=repositorioUsuario;
       }
 
        public IActionResult OnGet(int usuarioId)
        {
                Usuario=repositorioUsuario.GetUsuarioWithId(usuarioId);
                return Page();
 
        }
    }
}