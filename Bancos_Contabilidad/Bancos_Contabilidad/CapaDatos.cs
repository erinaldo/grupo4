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

        #region Poliza
        public static int agregarPoliza(CapaEntidad.poliza p)
        {
            int i = 0;
            try
            {
                CapaEntidad.con.insertSQL("INSERT INTO DETALLEPOLIZA VALUES('" + p.Nombre + "','" + p.Total + "','" + p.Fecha + "','" + p.Cuenta + "','" + p.Empresa+"',+'"+p.Status+"')");
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
                CapaEntidad.con.updateSQL("update detallepoliza set nombre = '"+p.Nombre+"', total = '"+p.Total+"', fecha = '"+p.Fecha+"', idcuentacontable = '"+p.Cuenta+"', idempresa = '"+p.Empresa+"' where idpoliza = '"+p.ID1+"'");
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
                CapaEntidad.con.updateSQL("update detallepoliza set stat = '0' where idpoliza = '" + p.ID1 + "'");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        #endregion

        #region Configuracion
        public static int agregarConfig(CapaEntidad.configuraion p)
        {
            int i = 0;
            try
            {
                CapaEntidad.con.insertSQL("INSERT INTO empresa VALUES('" + p.Nombre + "',1,'" + p.Pais + "','" + p.Moneda + "','" + p.Razon + "','" + p.Direccion + "','" + p.Telefono + "','" + p.Identificacion + "')");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        public static int actualizarConfig(CapaEntidad.configuraion p)
        {
            int i = 0;
            try
            {
                string temp = "update empresa set nombre_empresa = '" + p.Nombre + "', razonsocial = '" + p.Razon + "', direccion = '" + p.Direccion + "', identificaciontributaria = '" + p.Identificacion + "', id_sede = '" + p.Pais + "', id_moneda = '" + p.Moneda + "' where id_empresa = '" + p.Id + "'";
                MessageBox.Show(temp);
                CapaEntidad.con.updateSQL("update empresa set telefono = '"+p.Telefono+"', nombre_empresa = '" + p.Nombre + "', razonsocial = '" + p.Razon + "', direccion = '" + p.Direccion + "', identificaciontributaria = '" + p.Identificacion + "', id_sede = '" + p.Pais + "', id_moneda = '"+p.Moneda+"' where idempresa = '" + p.Id + "'");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        public static int eliminarConfig(CapaEntidad.configuraion p)
        {
            int i = 0;
            try
            {
                CapaEntidad.con.updateSQL("update empresa set activo = '0' where idempresa = '" + p.Id + "'");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        #endregion

        #region Documento Referencia
        public static int agregarDocRef(CapaEntidad.DocumentoRef p)
        {
            int i = 0;
            try
            {
                CapaEntidad.con.insertSQL("INSERT INTO DOCUMENTOREF VALUES('" + p.Documento1 + "','" + p.Descripcion1 + "',GETDATE(),'" + p.Estado + "','" + p.Total + "')");
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
                CapaEntidad.con.updateSQL("update documentoref set serieDocumento = '" + p.Documento1 + "', descripcon = '" + p.Descripcion1 + "', fecha = getdate(), stat = '" + p.Estado + "', MONTO = '" + p.Total + "' where idDocumento = '" + p.ID1 + "'");
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
                CapaEntidad.con.updateSQL("update documentoref set stat = '0' where idDocumento = '" + p.ID1 + "'");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        #endregion

        #region Cuenta Contable
        public static int agregarCuentaContable(CapaEntidad.cuentacontable p)
        {
            int i = 0;
            try
            {
                CapaEntidad.con.insertSQL("INSERT INTO CUENTACONTABLE VALUES('" + p.Nombre + "','" + p.Estadofinanciero + "','" + p.Clasificacion + "','" + p.Status + "')");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        public static int actualizarCuentaContable(CapaEntidad.cuentacontable p)
        {
            int i = 0;
            try
            {
                CapaEntidad.con.updateSQL("update CUENTACONTABLE set nombre = '" + p.Nombre + "', estadofinanciero = '" + p.Estadofinanciero + "', clasificacion = '" + p.Clasificacion + "' where idcuentacontable = '" + p.ID1 + "'");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        public static int eliminarCuentaContable(CapaEntidad.cuentacontable p)
        {
            int i = 0;
            try
            {
                CapaEntidad.con.updateSQL("update CUENTACONTABLE set stat = '0' where idcuentacontable = '" + p.ID1 + "'");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        #endregion

        #region Cuenta Bancaria
        public static int agregarCuenta(CapaEntidad.cuentaBancos p)
        {

            int i = 0;
            try
            {
                
                CapaEntidad.con.insertSQL("INSERT INTO CUENTA VALUES('" + p.Saldo + "','" + p.Nombre_cuenta+ "','" + p.Numero_cuenta + "','" + p.Banco + "','" + p.Activo + "','" + p.Estado + "',+'" + p.ID_EMP1+ "')");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        public static int actualizarCuenta(CapaEntidad.cuentaBancos p)
        {
            int i = 0;
            try
            {
                //  CapaEntidad.con.updateSQL("update cuenta set nombre_cuenta = '" + p.Nombre_cuenta + "', numero_cuenta = '" + p.Numero_cuenta + "', saldo = '" + p.Saldo + "', banco = '" + p.Banco + "', idempresa = '" + p.ID_EMP1 + "' where idcuenta = '" + p.ID_CUENTA1+ "'");

                //update CUENTACONTABLE set nombre = '" + p.Nombre + "', estadofinanciero = '" + p.Estadofinanciero + "', clasificacion = '" + p.Clasificacion + "' where idcuentacontable = '" + p.ID1 + "'");
               
                CapaEntidad.con.updateSQL("update cuenta set nombre_cuenta = '" + p.Nombre_cuenta +  "' where idcuenta = '" + p.ID_CUENTA1 + "'");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        public static int eliminarCuenta(CapaEntidad.cuentaBancos p)
        {
            int i = 0;
            try
            {
                CapaEntidad.con.updateSQL(" update cuenta set stat = '0' where idcuenta = '" + p.ID_CUENTA1 + "'");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        #endregion

    }
	 public static int agregarTipoTransaccion(CapaEntidad.tipoTransaccion p)
        {
            int i = 0;
            try
            {
                CapaEntidad.con.insertSQL("INSERT INTO TIPOTRANS VALUES('" + p.EstadoTrans + "','" + p.NombreTrans + "','" + p.AccionTrans + "')");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        public static int actualizarTipoTransaccion(CapaEntidad.tipoTransaccion p)
        {
            int i = 0;
            try
            {

                CapaEntidad.con.updateSQL("update tipotrans set nombre = '" + p.NombreTrans + "', accion = '" + p.AccionTrans + "', stat = '" + p.EstadoTrans +  "' where idtipotrans= '" + p.IdTipoTrans + "'");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        public static int eliminarTipoTransaccion(CapaEntidad.tipoTransaccion p)
        {
            int i = 0;
            try
            {
                CapaEntidad.con.updateSQL("update TIPOTRANS set stat = '0' where idtipotrans = '" + p.IdTipoTrans + "'");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        #endregion

    }

}


