using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicio
    {
        List<Servicio> servicios;
        private readonly AppContext _appContext = new AppContext();
 
        public IEnumerable<Servicio> GetAll()
        {
            return _appContext.Servicios;
        }
 
        public Servicio GetServicioWithId(int id){
            return _appContext.Servicios.Find(id);
        }

        public Servicio Create(Servicio newServicio)
        {
            var addServicio = _appContext.Servicios.Add(newServicio);
            _appContext.SaveChanges();
            return addServicio.Entity;
        }

        public Servicio Update(Servicio newServicio){
            var servicio= _appContext.Servicios.Find(newServicio.id);

            if(servicio != null){
                servicio.origen = newServicio.origen;
                servicio.destino = newServicio.destino;
                servicio.fecha = newServicio.fecha;
                servicio.hora = newServicio.hora;
                servicio.encomienda = newServicio.encomienda;
                //Guardar en base de datos
                _appContext.SaveChanges();
            }
        return servicio;
        }

        public void Delete(int id)
        {
        var service= _appContext.Servicios.Find(id);
        if (service == null)
            return;
        _appContext.Servicios.Remove(service);
        _appContext.SaveChanges();
        }
    }
}