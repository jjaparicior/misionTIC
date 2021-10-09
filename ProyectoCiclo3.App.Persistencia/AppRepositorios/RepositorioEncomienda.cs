using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomienda
    {
        List<Encomienda> encomiendas;
        private readonly AppContext _appContext = new AppContext();

        public IEnumerable<Encomienda> GetAll()
        {
            return _appContext.Encomiendas;
        }

        public Encomienda GetEncomiendaWithId(int id){
            return _appContext.Encomiendas.Find(id);
        }
 
        public Encomienda Create(Encomienda newEncomienda)
        {
            var addEncomienda = _appContext.Encomiendas.Add(newEncomienda);
            _appContext.SaveChanges();
            return addEncomienda.Entity;
        }

        public Encomienda Update(Encomienda newEncomienda){
            var encomienda= _appContext.Encomiendas.Find(newEncomienda.id);

            if(encomienda != null){
                encomienda.descripcion = newEncomienda.descripcion;
                encomienda.peso = newEncomienda.peso;
                encomienda.tipo = newEncomienda.tipo;
                encomienda.presentacion = newEncomienda.presentacion;
                //Guardar en base de datos
                _appContext.SaveChanges();
            }
        return encomienda;
        }

        public void Delete(int id)
        {
        var user= _appContext.Encomiendas.Find(id);
        if (user == null)
            return;
        _appContext.Encomiendas.Remove(user);
        _appContext.SaveChanges();
        }
    }
}