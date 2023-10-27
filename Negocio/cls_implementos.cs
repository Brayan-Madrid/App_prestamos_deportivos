using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Negocio
{
    public class cls_implementos
    {
        private String str_codigo;
        private String str_nombre;
        private String str_descripcion;
        private double flt_precio;
        private int int_cantidad;
        cls_conexion objconect = new cls_conexion();


        public void fnt_registrar(string codigo, string nombre, string descripcion, double precio, int cantidad)
        {
            SqlCommand con = new SqlCommand("SP_AgregarImplementos", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo", codigo);
            con.Parameters.AddWithValue("@nombre", nombre);
            con.Parameters.AddWithValue("@especificaciones", descripcion);
            con.Parameters.AddWithValue("@valor", precio);
            con.Parameters.AddWithValue("@cantidad", cantidad);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
            MessageBox.Show("Implemento resgistrado con éxito", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void fnt_consultar(string codigo)
        {
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_ConsultarImplemento", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo", codigo);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                str_nombre = Convert.ToString(Lectura[0]);
                str_descripcion = Convert.ToString(Lectura[1]);
                int_cantidad = Convert.ToInt32(Lectura[2]);
                flt_precio = Convert.ToDouble(Lectura[3]);
            }
            objconect.connection.Close();
        }

        public string getNombre() { return this.str_nombre; }
        public string getDescripcion() {  return this.str_descripcion;}
        public int getCantidad() { return this.int_cantidad; }
        public double getValor() { return this.flt_precio; }
    }
}
