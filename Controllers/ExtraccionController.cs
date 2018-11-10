using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ExtraccionController : ApiController
    {
        private readonly sistemarecomendacionEntities _db = new sistemarecomendacionEntities();
        // GET: api/Extraccion

        [Route("PueblosMagicos")]
        // GET: api/Extraccion/5
        public List<pueblo_magico> GetPueblosMagicos()
        {
            return _db.pueblo_magico.ToList();
        }

        [Route("Atractivos")]
        // GET: api/Extraccion/5
        public List<atractivo> GetAtractivos(int idPuebloMagico)
        {
            return _db.atractivo.Where(x => x.id_Pueblo_magico.Equals(idPuebloMagico)).ToList();
        }

        // POST: api/Extraccion
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Extraccion/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Extraccion/5
        public void Delete(int id)
        {
        }
    }
}
