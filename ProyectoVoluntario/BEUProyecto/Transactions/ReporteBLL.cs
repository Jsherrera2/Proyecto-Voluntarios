using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUProyecto.Transactions
{
    public class ReporteBLL
    {
        public static List<rptAporteVoluntario_Result> GetAporte()
        {
            Entities db = new Entities();
            return db.rptAporteVoluntario().ToList();
        }

        public static List<rptCategoriasVoluntariado_Result> GetCategoria()
        {
            Entities db = new Entities();
            return db.rptCategoriasVoluntariado().ToList();
        }

        public static List<rptSexoVoluntario_Result> GetSexo()
        {
            Entities db = new Entities();
            return db.rptSexoVoluntario().ToList();
        }



    }
}
