using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bancos_Contabilidad
{
    class CapaNegocio
    {

        #region Poliza
        public void insertPoliza(CapaEntidad.poliza p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre) || string.IsNullOrWhiteSpace(p.Total) || string.IsNullOrWhiteSpace(p.Cuenta))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.agregarPoliza(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Poliza Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la Poliza", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void actualizarPoliza(CapaEntidad.poliza p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre) || string.IsNullOrWhiteSpace(p.Total) || string.IsNullOrWhiteSpace(p.Cuenta))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.actualizarPoliza(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Poliza Editada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo editar la Poliza", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        public void eliminarPoliza(CapaEntidad.poliza p)
        {
            if (string.IsNullOrWhiteSpace(p.ID1))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.eliminarPoliza(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Poliza Eliminada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la Poliza", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        #endregion

        #region Configuracion
        public void insertConfig(CapaEntidad.configuraion p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre) || string.IsNullOrWhiteSpace(p.Razon) || string.IsNullOrWhiteSpace(p.Telefono) || string.IsNullOrWhiteSpace(p.Direccion) || string.IsNullOrWhiteSpace(p.Identificacion) || string.IsNullOrWhiteSpace(p.Moneda) || string.IsNullOrWhiteSpace(p.Pais))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.agregarConfig(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Configuracion Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la Configuracion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void actualizarConfig(CapaEntidad.configuraion p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre) || string.IsNullOrWhiteSpace(p.Razon) || string.IsNullOrWhiteSpace(p.Telefono) || string.IsNullOrWhiteSpace(p.Direccion) || string.IsNullOrWhiteSpace(p.Identificacion) || string.IsNullOrWhiteSpace(p.Moneda) || string.IsNullOrWhiteSpace(p.Pais))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.actualizarConfig(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Configuracion Editada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo editar la Configuracion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        public void eliminarConfig(CapaEntidad.configuraion p)
        {
            if (string.IsNullOrWhiteSpace(p.Id))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.eliminarConfig(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Configuracion Eliminada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la Configuracion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        #endregion

        #region Documento Referencia
        public void insertarDocRef(CapaEntidad.DocumentoRef p)
        {
            if (string.IsNullOrWhiteSpace(p.Descripcion1) || string.IsNullOrWhiteSpace(p.Documento1) || string.IsNullOrWhiteSpace(p.Total))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.agregarDocRef(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Documento Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Documento", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void actualizarDocRef(CapaEntidad.DocumentoRef p)
        {
            if (string.IsNullOrWhiteSpace(p.Documento1) || string.IsNullOrWhiteSpace(p.Descripcion1) || string.IsNullOrWhiteSpace(p.Total))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.actualizarDocRef(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Documento Editado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo editar el Documento", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        public void eliminarDocRef(CapaEntidad.DocumentoRef p)
        {
            if (string.IsNullOrWhiteSpace(p.ID1))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.eliminarDocRef(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Documento Eliminado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Documento", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        #endregion

        #region Cuenta Contable
        public void insertCuentaContable(CapaEntidad.cuentacontable p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre) || string.IsNullOrWhiteSpace(p.Estadofinanciero) || string.IsNullOrWhiteSpace(p.Clasificacion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.agregarCuentaContable(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Cuenta Contable Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la cuenta contable", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void actualizarCuentaContable(CapaEntidad.cuentacontable p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre) || string.IsNullOrWhiteSpace(p.Estadofinanciero) || string.IsNullOrWhiteSpace(p.Clasificacion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.actualizarCuentaContable(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Cuenta contable Editada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo editar la cuenta contable", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        public void eliminarCuentaContable(CapaEntidad.cuentacontable p)
        {
            if (string.IsNullOrWhiteSpace(p.ID1))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.eliminarCuentaContable(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Poliza Eliminada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la Poliza", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        #endregion

        #region Cuenta Bancaria
        public void insertCuenta(CapaEntidad.cuentaBancos p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre_cuenta) || string.IsNullOrWhiteSpace(p.Nombre_cuenta) || string.IsNullOrWhiteSpace(p.Saldo) || string.IsNullOrWhiteSpace(p.Banco))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.agregarCuenta(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Cuenta guardada con exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar cuenta", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void actualizarCuenta(CapaEntidad.cuentaBancos p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre_cuenta) || string.IsNullOrWhiteSpace(p.Numero_cuenta) || string.IsNullOrWhiteSpace(p.Saldo))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.actualizarCuenta(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Cuenta Editada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo editar la cuenta", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        public void eliminarCuenta(CapaEntidad.cuentaBancos p)
        {
           // if (string.IsNullOrWhiteSpace(p.Nombre_cuenta))
            //{
               // MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
                int resultado = CapaDatos.eliminarCuenta(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Cuenta Eliminada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la Poliza", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        #endregion
		  //TipoTransaccion
        public void insertTipoTransaccion(CapaEntidad.tipoTransaccion p)
        {
            if (string.IsNullOrWhiteSpace(p.NombreTrans) || string.IsNullOrWhiteSpace(p.AccionTrans) || string.IsNullOrWhiteSpace(p.EstadoTrans))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.agregarTipoTransaccion(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Tipo transaccion guardado con exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar tipo transaccion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void actualizarTipoTransaccion(CapaEntidad.tipoTransaccion p)
        {
            if (string.IsNullOrWhiteSpace(p.NombreTrans) || string.IsNullOrWhiteSpace(p.AccionTrans) || string.IsNullOrWhiteSpace(p.EstadoTrans))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.actualizarTipoTransaccion(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Tipo transaccion Editada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo editar tipo transaccion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
        public void eliminarTipoTransaccion(CapaEntidad.tipoTransaccion p)
        {
            if (string.IsNullOrWhiteSpace(p.IdTipoTrans))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = CapaDatos.eliminarTipoTransaccion(p);

                if (resultado > 0)
                {
                    MessageBox.Show("Tipo transaccion Eliminada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar tipo transaccion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

    }


