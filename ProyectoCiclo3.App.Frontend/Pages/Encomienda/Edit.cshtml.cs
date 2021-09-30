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
    public class EditEncomiendaModel : PageModel
    {
       private readonly RepositorioEncomienda repositorioEncomienda;
       [BindProperty]
        public Encomienda Encomienda {get;set;}
 
        public EditEncomiendaModel(RepositorioEncomienda repositorioEncomienda)
       {
            this.repositorioEncomienda=repositorioEncomienda;
       }
 
        public IActionResult OnGet(int encomiendaId)
        {
                Encomienda=repositorioEncomienda.GetEncomiendaWithId(encomiendaId);
                return Page();
 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Encomienda.id>0)
            {
            Encomienda = repositorioEncomienda.Update(Encomienda);
            }
            return RedirectToPage("./List");
        }
    }
}