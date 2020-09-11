using BEUProyecto;
using BEUProyecto.Transactions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WebApiVoluntario.Models;

namespace WebApiUsuario.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/login")]
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate(Usuario usuario)
        {
            if (usuario == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            usuario = UsuarioBLL.Validate(usuario);
            if (usuario != null)
            {
                return Ok(new
                {
                    user = usuario,
                    token = TokenGenerator.GenerateTokenJwt(usuario)
                });
            }
            else
            {
                return Unauthorized();
            }
        }


        public IHttpActionResult Get()
        {

            try
            {
                List<Usuario> todos = UsuarioBLL.List();
                return Content(HttpStatusCode.OK, todos);
                //return Json(todos);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }

        [ResponseType(typeof(Usuario))]

        public IHttpActionResult Delete(int id)
        {
            try
            {
                UsuarioBLL.Delete(id);
                return Ok("Usuario eliminado correctamente");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }
        }

        [ResponseType(typeof(Usuario))]

        public IHttpActionResult Post(Usuario voluntario)
        {
            try
            {
                UsuarioBLL.Create(voluntario);
                return Content(HttpStatusCode.Created, "Usuario creado correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ResponseType(typeof(Usuario))]

        public IHttpActionResult Put(Usuario voluntario)
        {
            try
            {
                UsuarioBLL.Update(voluntario);
                return Content(HttpStatusCode.OK, "Usuario actualizado correctamente");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ResponseType(typeof(Usuario))]

        public IHttpActionResult Get(int id)
        {
            try
            {
                Usuario result = UsuarioBLL.Get(id);
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
