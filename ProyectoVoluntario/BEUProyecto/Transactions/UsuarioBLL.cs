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
        }


        public static Usuario Get(int? id)
        {
            Entities db = new Entities();
            return db.Usuarios.Find(id);
        }

        public static void Create(Usuario a)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Usuarios.Add(a);
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void Update(Usuario Usuario)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Usuarios.Attach(Usuario);
                        db.Entry(Usuario).State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void Delete(int? id)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Usuario Usuario = db.Usuarios.Find(id);
                        db.Entry(Usuario).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static List<Usuario> List()
        {
            Entities db = new Entities();
            return db.Usuarios.ToList();
        }



       




    }
}
