using System;
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

        public static int agregarDocRef(CapaEntidad.DocumentoRef p)
        {
            int i = 0;
            try
            {
                MRP_BD con = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "DIEGO-HP");
                con.insertSQL("INSERT INTO DOCUMENTOREF VALUES('" + p.Documento1 + "','" + p.Descripcion1 + "',GETDATE(),'" + p.Estado + "','" + p.Total + "')");

                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }

        public static int actualizarDocRef(CapaEntidad.DocumentoRef p)
        {
            int i = 0;
            try
            {
                MRP_BD con = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "DIEGO-HP");
                con.updateSQL("update documentoref set serieDocumento = '" + p.Documento1 + "', descripcon = '" + p.Descripcion1 + "', fecha = getdate(), stat = '" + p.Estado + "', MONTO = '" + p.Total + "' where idDocumento = '" + p.ID1 + "'");

                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }

        public static int eliminarDocRef(CapaEntidad.DocumentoRef p)
        {
            int i = 0;
            try
            {
                MRP_BD con = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "DIEGO-HP");
                con.updateSQL("update documentoref set stat = '0' where idDocumento = '" + p.ID1 + "'");

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
