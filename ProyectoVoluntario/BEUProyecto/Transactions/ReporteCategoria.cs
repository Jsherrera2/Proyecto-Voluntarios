using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUProyecto.Transactions
{
    public class ReporteCategoria
    {

        public static List<rptCatV_Result> Get()
        {
            Entities db = new Entities();
            return db.rptCatV().ToList();


        }

        public static List<rptCatV_Result> Get(int? id)
        {
            Entities db = new Entities();
            return db.rptCatV().ToList();


        }
    }
}
