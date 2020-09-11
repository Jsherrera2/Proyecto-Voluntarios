using BEUProyecto;
using BEUProyecto.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace WebApiVoluntario.Controllers
{
    public class ReporteCateController : ApiController
    {
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [ResponseType(typeof(rptCatV_Result))]
        public IHttpActionResult Get()
        {

            try
            {
                List<rptCatV_Result> todos = ReporteCategoria.Get();
                return Content(HttpStatusCode.OK, todos);
                //return Json(todos);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }
    }
}
