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
        public static MRP_BD con = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "JREVMENPC");

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
        public class DocumentoRef{
            string ID;
            string Documento;
            string Descripcion;
            string total;
            string fecha;
            string estado;

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

            public string Documento1
            {
                get
                {
                    return Documento;
                }

                set
                {
                    Documento = value;
                }
            }

            public string Descripcion1
            {
                get
                {
                    return Descripcion;
                }

                set
                {
                    Descripcion = value;
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

            public string Estado
            {
                get
                {
                    return estado;
                }

                set
                {
                    estado = value;
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
        public class cuentaBancos
        {
            string ID_CUENTA;
            string saldo;
            string nombre_cuenta;
            string numero_cuenta;
            string banco;
            string activo;
            string estado;
            string ID_EMP;
            
            public string ID_CUENTA1
            {
                get
                {
                    return ID_CUENTA;
                }

                set
                {
                    ID_CUENTA = value;
                }
            }

            public string Nombre_cuenta
            {
                get
                {
                    return nombre_cuenta;
                }

                set
                {
                    nombre_cuenta = value;
                }
            }

            public string Numero_cuenta
            {
                get
                {
                    return numero_cuenta;
                }

                set
                {
                    numero_cuenta = value;
                }
            }

            public string Banco
            {
                get
                {
                    return banco;
                }

                set
                {
                    banco = value;
                }
            }

            public string Activo
            {
                get
                {
                    return activo;
                }

                set
                {
                    activo = value;
                }
            }

            public string Estado
            {
                get
                {
                    return estado;
                }

                set
                {
                    estado = value;
                }
            }

            public string ID_EMP1
            {
                get
                {
                    return ID_EMP;
                }

                set
                {
                    ID_EMP = value;
                }
            }

            public string Saldo
            {
                get
                {
                    return saldo;
                }

                set
                {
                    saldo = value;
                }
            }
        }
    }

}
