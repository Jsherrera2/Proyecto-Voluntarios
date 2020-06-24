using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUProyecto.Transactions
{
    public class EventoBLL
    {

        public static Evento Get(int? id)
        {
            Entities db = new Entities();
            return db.Eventoes.Find(id);
        }

        public static void Create(Evento a)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Eventoes.Add(a);
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

        public static void Update(Evento Evento)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Eventoes.Attach(Evento);
                        db.Entry(Evento).State = System.Data.Entity.EntityState.Modified;

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
                        Evento Evento = db.Eventoes.Find(id);
                        db.Entry(Evento).State = System.Data.Entity.EntityState.Deleted;
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

        public static List<Evento> List()
        {
            Entities db = new Entities();
            return db.Eventoes.ToList();
        }

        public static List<Evento> ListToNames()
        {
            Entities db = new Entities();
            List<Evento> resultado = new List<Evento>();
            db.Eventoes.ToList().ForEach(x => resultado.Add(new Evento { nombre = x.nombre, idevento = x.idevento }));
            return resultado;
        }






    }
}
