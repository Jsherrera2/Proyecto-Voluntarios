using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUProyecto.Transactions
{
    public class UsuarioBLL
    {
        public static Usuario Validate(Usuario usuario)
        {
            Entities db = new Entities();
            return db.Usuarios.FirstOrDefault(x => x.nombre == usuario.nombre
                && x.contrasena == usuario.contrasena);

            /*            foreach (var item in db.Usuarios.ToList())
                        {
                            if (item.correo == persona.correo && item.password == persona.password)
                            {
                                return item;
                            }
                        }
                        return null;*/

        }

    }
}
