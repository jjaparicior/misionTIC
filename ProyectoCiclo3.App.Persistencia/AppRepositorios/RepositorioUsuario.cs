using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario
    {
        List<Usuario> usuarios;
 
    public RepositorioUsuario()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombre="Jairo",apellidos= "Gonzalez",direccion= "Carrera 3 No. 10-11",telefono= "3145475876", ciudad= "Bogotá"},
                new Usuario{id=2,nombre="Andrea",apellidos= "Sanchez",direccion= "Calle 54 No. 14-67",telefono= "3210485840", ciudad= "Manizales"},
                new Usuario{id=3,nombre="Santiago",apellidos= "Barrios",direccion= "Diagonal 7 No. 100-15",telefono= "3103538503", ciudad= "Medellin"}
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetUsuarioWithId(int id){
            return usuarios.SingleOrDefault(b => b.id == id);
        }

        public Usuario Create(Usuario newUsuario)
        {
           if(usuarios.Count > 0){
           newUsuario.id=usuarios.Max(r => r.id) +1; 
            }else{
               newUsuario.id = 1; 
            }
           usuarios.Add(newUsuario);
           return newUsuario;
        }

        public Usuario Update(Usuario newUsuario){
            var usuario= usuarios.SingleOrDefault(b => b.id == newUsuario.id);
            if(usuario != null){
                usuario.nombre = newUsuario.nombre;
                usuario.apellidos = newUsuario.apellidos;
                usuario.direccion = newUsuario.direccion;
                usuario.telefono = newUsuario.telefono;
                usuario.ciudad = newUsuario.ciudad;
            }
        return usuario;
        }

        public Usuario Delete(int id)
        {
        var usuario= usuarios.SingleOrDefault(b => b.id == id);
        usuarios.Remove(usuario);
        return usuario;
        }

    }
}