using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancos_Contabilidad
{
    class CapaEntidad
    {

        public static string idemp, idcuenta;
        public static MRP_BD con = new MRP_BD("adminseminario", "S@dseminario", "ERPSeminario", "erpseminario.database.windows.net");
        //public static MRP_BD con = new MRP_BD("sa", "Cocodrilo13", "SAD2017", "erpseminario.database.windows.net");

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
        public class configuraion
        {
            string id;
            string nombre;
            string razon;
            string direccion;
            string telefono;
            string identificacion;
            string moneda;
            string pais;

            public string Id
            {
                get
                {
                    return id;
                }

                set
                {
                    id = value;
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

            public string Razon
            {
                get
                {
                    return razon;
                }

                set
                {
                    razon = value;
                }
            }

            public string Direccion
            {
                get
                {
                    return direccion;
                }

                set
                {
                    direccion = value;
                }
            }

            public string Telefono
            {
                get
                {
                    return telefono;
                }

                set
                {
                    telefono = value;
                }
            }

            public string Identificacion
            {
                get
                {
                    return identificacion;
                }

                set
                {
                    identificacion = value;
                }
            }

            public string Moneda
            {
                get
                {
                    return moneda;
                }

                set
                {
                    moneda = value;
                }
            }

            public string Pais
            {
                get
                {
                    return pais;
                }

                set
                {
                    pais = value;
                }
            }
        }
        public class Autorizacion
        {
            private string id;
            private string descripcion;
            private string monto;
            private string estado;
            private string tipopago;
            private string tabla;
            private string beneficiario;

            public string Id
            {
                get
                {
                    return id;
                }

                set
                {
                    id = value;
                }
            }

            public string Descripcion
            {
                get
                {
                    return descripcion;
                }

                set
                {
                    descripcion = value;
                }
            }
            
            public string Monto
            {
                get
                {
                    return monto;
                }

                set
                {
                    monto = value;
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

            public string Tipopago
            {
                get
                {
                    return tipopago;
                }

                set
                {
                    tipopago = value;
                }
            }

            public string Tabla
            {
                get
                {
                    return tabla;
                }

                set
                {
                    tabla = value;
                }
            }

            public string Beneficiario
            {
                get
                {
                    return beneficiario;
                }

                set
                {
                    beneficiario = value;
                }
            }
        }
    }

}
