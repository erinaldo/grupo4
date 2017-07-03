using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PruebaConexion
{
    class Conexion
    {
        public SqlConnection cn;
        public SqlCommand cmd;
        public SqlDataReader dr;

        public Conexion()
        {
            try
            {
                //cn = new SqlConnection("Data Source=JREVMENPC;Initial Catalog=Tutorial;Integrated Security=True");
                //cn = new SqlConnection("Data Source = JREVMENPC; Integrated Security = False; User ID = sa; Password = Cocodrilo13; Connect Timeout = 15; //Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; Initial Catalog = SAD2017");
               // cn.Open();
			    cn = new SqlConnection("Data Source = erpseminario.database.windows.net; Integrated Security = False; User ID = adminseminario; Password = S@dseminario; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; Initial Catalog = ERPSeminario");
                cn.Open();
                //MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }

        public string insertar(int id, string nombre, string apellidos, string fecha)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Insert into Persona(Id,Nombre,Apellidos,FechaNacimiento) values(" + id + ",'" + nombre + "','" + apellidos + "','" + fecha + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }



        public int personaRegistrada(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Persona where Id=" + id + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }



    }
}
