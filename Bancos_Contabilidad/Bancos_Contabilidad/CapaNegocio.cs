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


    }
}
