﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUProyecto.Transactions
{
    public class ReporteAgrupadoEyGBLL
    {
        public static List<rptAgrupadoEventoGenero_Result> Get()
        {
            Entities db = new Entities();
            return db.rptAgrupadoEventoGenero().ToList();
        }
    }
}
