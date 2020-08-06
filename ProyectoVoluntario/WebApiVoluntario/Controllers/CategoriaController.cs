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

namespace WebApiVoluntario.Controllers
{
    public class CategoriaController : ApiController
    {
        [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
        [ResponseType(typeof(Categoria))]
        public IHttpActionResult Get()
        {

            try
            {
                List<Categoria> todos = CategoriaBLL.List();
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