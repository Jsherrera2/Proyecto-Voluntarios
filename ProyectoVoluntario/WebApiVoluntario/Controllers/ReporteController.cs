using BEUProyecto;
using BEUProyecto.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiVoluntario.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ReporteController : ApiController
    {
        //public IHttpActionResult Get()
        //{
        //    try
        //    {
        //        List<rptAporteVoluntario_Result> todos = ReporteBLL.GetAporte();
        //        return Content(HttpStatusCode.OK, todos);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Content(HttpStatusCode.BadRequest, ex);
        //    }
        //}

        //public IHttpActionResult Get1()
        //{
        //    try
        //    {
        //        List<rptCategoriasVoluntariado_Result> todos = ReporteBLL.GetCategoria();
        //        return Content(HttpStatusCode.OK, todos);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Content(HttpStatusCode.BadRequest, ex);
        //    }
        //}

        //public IHttpActionResult Get2()
        //{
        //    try
        //    {
        //        List<rptSexoVoluntario_Result> todos = ReporteBLL.GetSexo();
        //        return Content(HttpStatusCode.OK, todos);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Content(HttpStatusCode.BadRequest, ex);
        //    }
        //}





    }
}
