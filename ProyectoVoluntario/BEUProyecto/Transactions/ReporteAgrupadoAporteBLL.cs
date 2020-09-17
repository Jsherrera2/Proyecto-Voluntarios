using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUProyecto.Transactions
{
    public class ReporteAgrupadoAporteBLL
    {

        public static List<rptAgrupadoAporte_Result> Get()
        {
            Entities db = new Entities();
            return db.rptAgrupadoAporte().ToList();
        }
    }
}
