using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUProyecto.Transactions
{
    public class ReporteBLL
    {

        public static List<rptSexo_Result> Get()
        {
            Entities db = new Entities();
            return db.rptSexo().ToList();


        }


    }
}
