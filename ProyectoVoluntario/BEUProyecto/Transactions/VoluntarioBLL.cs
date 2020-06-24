using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUProyecto.Transactions
{
    public class VoluntarioBLL
    {

        public static Voluntario Get(int? id)
        {
            Entities db = new Entities();
            return db.Voluntarios.Find(id);
        }

        public static void Create(Voluntario a)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Voluntarios.Add(a);
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

        public static void Update(Voluntario Voluntario)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Voluntarios.Attach(Voluntario);
                        db.Entry(Voluntario).State = System.Data.Entity.EntityState.Modified;
                        
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
                        Voluntario Voluntario = db.Voluntarios.Find(id);
                        db.Entry(Voluntario).State = System.Data.Entity.EntityState.Deleted;
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

        public static List<Voluntario> List()
        {
            Entities db = new Entities();
            return db.Voluntarios.ToList();
        }



        public static List<Voluntario> ListToNames()
        {
            Entities db = new Entities();
            List<Voluntario> resultado = new List<Voluntario>();
            db.Voluntarios.ToList().ForEach(x => resultado.Add(new Voluntario { nombres = x.nombres + " " + x.apellidos, idvoluntario = x.idvoluntario }));
            return resultado;
        }





    }
}
