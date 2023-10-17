using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class cls_modulos_usuarios
    {
        private String str_id;
        private String str_pnombre;
        private String str_snombre;
        private String str_papellido;
        private String str_sapellido;
        private String str_contacto;
        private String str_correo;
        private String str_direccion;
        private String str_sexo;
        cls_conexion objConectar = new cls_conexion();

        public void fnt_guardar(String id, String p_nombre, String s_nombre, String p_apellido,
            String s_apellido, String contacto, String correo, String direccion, String sexo)
        {
            if (id.Equals("") || p_nombre.Equals("") || s_nombre.Equals("") || p_apellido.Equals("")
                || s_apellido.Equals("") || contacto.Equals("") || correo.Equals("") || direccion.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand command = new SqlCommand("SP_Registrar", objConectar.connection);

                //especifico que el tipo de comando que quiero ejecutar es un procedimiento almacenado
                command.CommandType = CommandType.StoredProcedure;

                //agrego los valores correspondientes a las variables declaradas en el SP
                //nuevo comentario
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@p_nombre", p_nombre);
                command.Parameters.AddWithValue("@s_nombre", s_nombre);
                command.Parameters.AddWithValue("@p_apellido", p_apellido);
                command.Parameters.AddWithValue("@s_apellido", s_apellido);
                command.Parameters.AddWithValue("@contacto", contacto);
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@direccion", direccion);

                objConectar.connection.Open();
                command.ExecuteNonQuery();
                objConectar.connection.Close();
                MessageBox.Show("Persona registrada con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
