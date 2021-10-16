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
    public class ListEncomiendaModel : PageModel
    {
        private readonly RepositorioEncomienda repositorioEncomienda;
        [BindProperty]
        public Encomienda Package {get;set;}
        public IEnumerable<Encomienda> Encomienda {get;set;}
 
    public ListEncomiendaModel(RepositorioEncomienda repositorioEncomienda)
    {
        this.repositorioEncomienda=repositorioEncomienda;
     }
 
    public void OnGet()
    {
        Encomienda=repositorioEncomienda.GetAll();
    }

    public IActionResult OnPost()
    {
        if(Package.id>0)
        {
            repositorioEncomienda.Delete(Package.id);
        }
        return RedirectToPage("./List");
    }

    }
}