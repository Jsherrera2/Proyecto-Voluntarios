using BEUProyecto;
using BEUProyecto.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace WebApiVoluntario.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class VoluntarioController : ApiController
    {

        public IHttpActionResult Post(Voluntario Voluntario)
        {
            try
            {
                VoluntarioBLL.Create(Voluntario);
                return Content(HttpStatusCode.Created, "Voluntario creado correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IHttpActionResult Get()
        {
            List<Voluntario> todos = VoluntarioBLL.List();
            return Content(HttpStatusCode.OK, todos);
        }

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
    }
}