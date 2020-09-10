using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUProyecto.Transactions
{
    public class ReporteSexoBLL
    {
        public static List<rptAporteVoluntario_Result> GetProductosCarritoPorCategorias()
        {
            using (Entities db = new Entities())
            {
                return db.rptAporteVoluntario.ToList();
            }
        }
    }
}
