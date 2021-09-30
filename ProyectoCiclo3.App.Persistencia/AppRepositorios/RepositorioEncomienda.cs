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
                new Encomienda{id=1,descripcion="Sobre tamaño carta",tipo= "Documentos",peso= 10,presentacion= "Sobre"},
                new Encomienda{id=2,descripcion="Caja mediana",tipo= "Alimentos",peso= 8000,presentacion= "Caja"},
                new Encomienda{id=3,descripcion="Caja grande",tipo= "Electrodoméstico",peso= 3000,presentacion= "Caja"}
            };
        }
 
        public IEnumerable<Encomienda> GetAll()
        {
            return encomiendas;
        }
 
        public Encomienda GetEncomiendaWithId(int id){
            return encomiendas.SingleOrDefault(b => b.id == id);
        }

        public Encomienda Update(Encomienda newEncomienda){
            var encomienda= encomiendas.SingleOrDefault(b => b.id == newEncomienda.id);
            if(encomienda != null){
                encomienda.descripcion = newEncomienda.descripcion;
                encomienda.peso = newEncomienda.peso;
                encomienda.tipo = newEncomienda.tipo;
                encomienda.presentacion = newEncomienda.presentacion;
            }
        return encomienda;
        }
    }
}