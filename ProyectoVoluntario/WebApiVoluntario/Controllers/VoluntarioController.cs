using BEUProyecto;
using BEUProyecto.Transactions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;


namespace WebApiVoluntario.Controllers
{
    public class VoluntarioController : ApiController
    {
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]

        [ResponseType(typeof (Voluntario))]
        [Authorize(Roles = "usuario")]
        public IHttpActionResult Get()
        {

            try
            {
                List<Voluntario> todos = VoluntarioBLL.List();
                return Content(HttpStatusCode.OK, todos);
                //return Json(todos);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
            
        }

        [ResponseType(typeof(Voluntario))]
        [Authorize(Roles = "usuario")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                VoluntarioBLL.Delete(id);
                return Ok("Voluntario eliminado correctamente");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }

        [ResponseType(typeof(Voluntario))]
        [Authorize(Roles = "usuario")]
        public IHttpActionResult Post(Voluntario voluntario)
        {
            try
            {
                VoluntarioBLL.Create(voluntario);
                return Content(HttpStatusCode.Created, "Voluntario creado correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ResponseType(typeof(Voluntario))]
        [Authorize(Roles = "usuario")]
        public IHttpActionResult Put(Voluntario voluntario)
        {
            try
            {
                VoluntarioBLL.Update(voluntario);
                return Content(HttpStatusCode.OK, "Voluntario actualizado correctamente");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ResponseType(typeof(Voluntario))]
        [Authorize(Roles = "usuario")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                Voluntario result = VoluntarioBLL.Get(id);
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