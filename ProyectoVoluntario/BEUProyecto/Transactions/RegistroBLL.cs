using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUProyecto.Transactions
{
    public class RegistroBLL
    {


        public static Registro Get(int? id)
        {
            Entities db = new Entities();
            return db.Registroes.Find(id);
        }

        public static void Create(Registro a)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Registroes.Add(a);
                        Config(a);
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

        public static void Update(Registro Registro)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Registroes.Attach(Registro);
                        db.Entry(Registro).State = System.Data.Entity.EntityState.Modified;
                        Config(Registro);
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
                        Registro Registro = db.Registroes.Find(id);
                        db.Entry(Registro).State = System.Data.Entity.EntityState.Deleted;
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

        public static List<Registro> List()
        {
            Entities db = new Entities();
            return db.Registroes.ToList();
        }

        public static void Config(Registro r)
        {
            r.fecha = DateTime.Now;
            r.estado = "Registrado";
        }

    }
}
