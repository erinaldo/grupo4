using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

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
                CapaEntidad.con.insertSQL("INSERT INTO POLIZA VALUES('" + p.Nombre + "','" + p.Descripcion + "','" + p.Fecha + "','" + p.Empresa + "','" + p.Status+"')");
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
                CapaEntidad.con.updateSQL("update poliza set nombre = '"+p.Nombre+"', descripcion = '"+p.Descripcion+"', fecha = '"+p.Fecha+"', idempresa = '"+p.Empresa+"' where idpoliza = '"+p.ID1+"'");
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
                CapaEntidad.con.updateSQL("update poliza set stat = '0' where idpoliza = '" + p.ID1 + "'");
                i = 1;
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }
        #endregion

        #region DetallePoliza
        public static int agregarDetallePoliza(CapaEntidad.DetallePoliza dp, DataGridView dg)
        {
            int i = 0;
            try
            {
                foreach (DataGridViewRow row in dg.Rows)
                {
                    dp.Cuenta1 = row.Cells[0].Value.ToString();
                    string[] cortador = dp.Cuenta1.Split('-');
                    string nomenclatura = cortador[0];
                    string nombrecuenta = cortador[1];
                    try
                    {
                        PruebaConexion.Conexion con = new PruebaConexion.Conexion();
                        con.cmd = new SqlCommand("Select rtrim(idcuenta) from CUENTACONTABLE where nomenclatura = '" + nomenclatura + "' AND nombre = '" + nombrecuenta + "'", con.cn);
                        con.dr = con.cmd.ExecuteReader();
                        if (con.dr.Read())
                            dp.Cuenta1 = con.dr.GetString(0);
                        con.dr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo obtener el detalle de la poliza " + ex);
                    }

                    if (row.Cells[1].Value.ToString() == "" && row.Cells[2].Value.ToString() != "")
                    {
                        dp.Clasificacion = "Haber";
                        dp.Valor = row.Cells[2].Value.ToString();
                    }
                    else if(row.Cells[2].Value.ToString() == "" && row.Cells[1].Value.ToString() != "")
                    {
                        dp.Clasificacion = "Debe";
                        dp.Valor = row.Cells[1].Value.ToString();
                    }

                    CapaEntidad.con.insertSQL("INSERT INTO DETALLEPOLIZA VALUES('" + dp.Poliza1 + "','" + dp.Cuenta1 + "','" + dp.Clasificacion + "','" + dp.Valor + "')");
                    i = 1;
                }
                
            }
            catch (Exception e)
            {
                i = 0;
            }
            return i;
        }

        public static int editarDetallePoliza(CapaEntidad.DetallePoliza dp, DataGridView dg)
        {
            int i = 1;
            try
            {
                PruebaConexion.Conexion con = new PruebaConexion.Conexion();
                con.cmd = new SqlCommand("delete from DETALLEPOLIZA where idPoliza = '"+dp.Poliza1+"'", con.cn);
                con.dr = con.cmd.ExecuteReader();
                con.dr.Close();
                agregarDetallePoliza(dp, dg);
            }
            catch (Exception ex)
            {
                i = 0;
                MessageBox.Show("No se pudo obtener el detalle de la poliza " + ex);
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
}

