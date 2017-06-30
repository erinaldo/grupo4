using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancos_Contabilidad
{
    class CapaEntidad
    {

        public static string idemp;
        public class poliza{
            string ID;
            string nombre;
            string total;
            string fecha;
            string cuenta;
            string empresa;
            string status;

            public string Nombre
            {
                get
                {
                    return nombre;
                }

                set
                {
                    nombre = value;
                }
            }

            public string Total
            {
                get
                {
                    return total;
                }

                set
                {
                    total = value;
                }
            }

            public string Fecha
            {
                get
                {
                    return fecha;
                }

                set
                {
                    fecha = value;
                }
            }

            public string Cuenta
            {
                get
                {
                    return cuenta;
                }

                set
                {
                    cuenta = value;
                }
            }

            public string Empresa
            {
                get
                {
                    return empresa;
                }

                set
                {
                    empresa = value;
                }
            }

            public string ID1
            {
                get
                {
                    return ID;
                }

                set
                {
                    ID = value;
                }
            }

            public string Status
            {
                get
                {
                    return status;
                }

                set
                {
                    status = value;
                }
            }
        }

        public class cuentacontable
        {
            string ID;
            string nombre;
            string estadofinanciero;
            string clasificacion;
            string status;

            public string ID1
            {
                get
                {
                    return ID;
                }

                set
                {
                    ID = value;
                }
            }

            public string Nombre
            {
                get
                {
                    return nombre;
                }

                set
                {
                    nombre = value;
                }
            }

            public string Estadofinanciero
            {
                get
                {
                    return estadofinanciero;
                }

                set
                {
                    estadofinanciero = value;
                }
            }

            public string Clasificacion
            {
                get
                {
                    return clasificacion;
                }

                set
                {
                    clasificacion = value;
                }
            }

            public string Status
            {
                get
                {
                    return status;
                }

                set
                {
                    status = value;
                }
            }
        }

    }
}
