using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : ApiController
    {
        private readonly sistemarecomendacionEntities _db = new sistemarecomendacionEntities();

        [Route("Login")]
        public string GetLogon(string usuario, string password)
        {
            try
            {
                usuario usuarioRegistrado = _db.usuario.Where(x => x.nombre.Equals(usuario)).FirstOrDefault();
                if(usuarioRegistrado != null)
                {
                    return ("Usuario registrado");
                    
                }
                return ("Usuario no registrado");
            }
            catch (Exception e)
            {
                return ("Usuario no registrado");
            }

        }

        [Route("Registro")]
        public string PostRegistro(usuario nuevoUsuario)
        {
            try
            {
                _db.usuario.Add(nuevoUsuario);
                _db.SaveChanges();
                return ("Usuario registrado correctamente");
            }
            catch (Exception e)
            {
                return ("El usuario pudo ser registrado");
            }

        }


    }
}
