using MuebleriaCostaRica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MuebleriaCostaRica.Controllers
{
    public class CatalogoController : ApiController
    {
        //api/catalogo        
        public IHttpActionResult Get()
        {
            return Ok(Inventario.Listar());
        }

        //api/catalogo        
        public IHttpActionResult Get(string id)
        {
            return Ok(Inventario.ListarPorId(id));
        }

        //api/catalogo        
        public IHttpActionResult Post(Mueble mueble)
        {
            Inventario.Agregar(mueble);
            return Content(HttpStatusCode.Created, mueble);
        }

        //api/catalogo        
        public IHttpActionResult Put(Mueble mueble)
        {
            Inventario.Actualizar(mueble);
            return Content(HttpStatusCode.OK, mueble);
        }

        //api/catalogo        
        public IHttpActionResult Delete(Mueble mueble)
        {
            Inventario.Eliminar(mueble);
            return Content(HttpStatusCode.OK, mueble);
        }
    }
}
