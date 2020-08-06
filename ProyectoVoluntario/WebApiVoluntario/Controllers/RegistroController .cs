using BEUProyecto;
using BEUProyecto.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace WebApiRegistro.Controllers
{
    public class RegistroController : ApiController
    {
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [ResponseType(typeof(Registro))]
        public IHttpActionResult Get()
        {

            try
            {
                List<Registro> todos = RegistroBLL.List();
                return Content(HttpStatusCode.OK, todos);
                //return Json(todos);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }


        [ResponseType(typeof(Registro))]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                RegistroBLL.Delete(id);
                return Ok("Registro eliminado correctamente");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }

        [ResponseType(typeof(Registro))]
        public IHttpActionResult Post(Registro Registro)
        {
            try
            {
                RegistroBLL.Create(Registro);
                return Content(HttpStatusCode.Created, "Registro creado correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ResponseType(typeof(Registro))]
        public IHttpActionResult Put(Registro Registro)
        {
            try
            {
                RegistroBLL.Update(Registro);
                return Content(HttpStatusCode.OK, "Registro actualizado correctamente");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ResponseType(typeof(Registro))]
        public IHttpActionResult Get(int id)
        {
            try
            {
                Registro result = RegistroBLL.Get(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Content(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}