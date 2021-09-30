using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicio
    {
        List<Servicio> servicios;
 
    public RepositorioServicio()
        {
            servicios= new List<Servicio>()
            {
                new Servicio{id=1,origen="Bogotá",destino= "Manizales",fecha= "20/09/2021", hora= "7:00 p.m.", encomienda= 1},
                new Servicio{id=2,origen="Medellin",destino= "Sincelejo",fecha= "22/09/2021", hora= "5:00 p.m.", encomienda= 2},
                new Servicio{id=3,origen="Bucaramanga",destino= "Bogotá",fecha= "14/09/2021", hora= "10:00 a.m.", encomienda= 3}
            };
        }
 
        public IEnumerable<Servicio> GetAll()
        {
            return servicios;
        }
 
        public Servicio GetServicioWithId(int id){
            return servicios.SingleOrDefault(b => b.id == id);
        }

        public Servicio Update(Servicio newServicio){
            var servicio= servicios.SingleOrDefault(b => b.id == newServicio.id);
            if(servicio != null){
                servicio.origen = newServicio.origen;
                servicio.destino = newServicio.destino;
                servicio.fecha = newServicio.fecha;
                servicio.hora = newServicio.hora;
                servicio.encomienda = newServicio.encomienda;
            }
        return servicio;
        }
    }
}