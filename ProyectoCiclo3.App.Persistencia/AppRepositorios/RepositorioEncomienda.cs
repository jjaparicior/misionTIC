using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomienda
    {
        List<Encomienda> encomiendas;
 
    public RepositorioEncomienda()
        {
            encomiendas= new List<Encomienda>()
            {
                new Encomienda{id=1,descripcion="Sobre con documentos",tipo= "Documentos",peso= 10,presentacion= "sobre"},
                new Encomienda{id=2,descripcion="XXXX",tipo= "XXXX",peso= 20,presentacion= "XXXX"},
                new Encomienda{id=3,descripcion="XXXX",tipo= "XXXX",peso= 30,presentacion= "XXXX"}
            };
        }
 
        public IEnumerable<Encomienda> GetAll()
        {
            return encomiendas;
        }
 
        public Encomienda GetEncomiendaWithId(int id){
            return encomiendas.SingleOrDefault(b => b.id == id);
        }
    }
}