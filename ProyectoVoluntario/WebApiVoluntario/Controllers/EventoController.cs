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

namespace WebApiEvento.Controllers
{
    public class EventoController : ApiController
    {
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [ResponseType(typeof(Evento))]
        public IHttpActionResult Get()
        {

            try
            {
                List<Evento> todos = EventoBLL.List();
                return Content(HttpStatusCode.OK, todos);
                //return Json(todos);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }


        [ResponseType(typeof(Evento))]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                EventoBLL.Delete(id);
                return Ok("Evento eliminado correctamente");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }

        [ResponseType(typeof(Evento))]
        public IHttpActionResult Post(Evento Evento)
        {
            try
            {
                EventoBLL.Create(Evento);
                return Content(HttpStatusCode.Created, "Evento creado correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ResponseType(typeof(Evento))]
        public IHttpActionResult Put(Evento Evento)
        {
            try
            {
                EventoBLL.Update(Evento);
                return Content(HttpStatusCode.OK, "Evento actualizado correctamente");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ResponseType(typeof(Evento))]
        public IHttpActionResult Get(int id)
        {
            try
            {
                Evento result = EventoBLL.Get(id);
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