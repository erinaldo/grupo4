﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bancos_Contabilidad
{
    class CapaDatos
    {
        public static int agregarPoliza(CapaEntidad.poliza p)
        {
            int i = 0;
            try
            {
                MRP_BD con = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "JREVMENPC");
                con.insertSQL("INSERT INTO DETALLEPOLIZA VALUES('" + p.Nombre + "','" + p.Total + "','" + p.Fecha + "','" + p.Cuenta + "','" + p.Empresa+"',+'"+p.Status+"')");

                i = 1;
            }catch(Exception e)
            {
                i = 0;
            }
            return i;
        }
        public static int actualizarPoliza(CapaEntidad.poliza p)
        {
            int i = 0;
            try
            {
                MRP_BD con = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "JREVMENPC");
                con.updateSQL("update detallepoliza set nombre = '"+p.Nombre+"', total = '"+p.Total+"', fecha = '"+p.Fecha+"', idcuentacontable = '"+p.Cuenta+"', idempresa = '"+p.Empresa+"' where idpoliza = '"+p.ID1+"'");

                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }

        public static int eliminarPoliza(CapaEntidad.poliza p)
        {
            int i = 0;
            try
            {
                MRP_BD con = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "JREVMENPC");
                con.updateSQL("update detallepoliza set stat = '0' where idpoliza = '" + p.ID1 + "'");

                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
    }
}
