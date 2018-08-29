using CAPA_ENTIDAD;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
   public class CD_EMPRESA
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR()
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_EMPRESA", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "EMPRESA");
            cn.Close();

            return ds.Tables["EMPRESA"];
        }

        public void ACTUALIZAR(CE_EMPRESA obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_EMPRESA", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@OPCION", "ACTUALIZAR");
            da.UpdateCommand.Parameters.AddWithValue("@NOMBRE_EMPRESA", obj.NOMBRE_EMPRESA);
            da.UpdateCommand.Parameters.AddWithValue("@DIRECCION", obj.DIRECCION);
            da.UpdateCommand.Parameters.AddWithValue("@TELEFONO", obj.TELEFONO);
            da.UpdateCommand.Parameters.AddWithValue("@CELULAR", obj.CELULAR);
            da.UpdateCommand.Parameters.AddWithValue("@EMAIL", obj.EMAIL);
            da.UpdateCommand.Parameters.AddWithValue("@IDENTIFICACION", obj.IDENTIFICACION);
            da.UpdateCommand.Parameters.AddWithValue("@PAGINA_WEB", obj.PAGINA_WEB);
            da.UpdateCommand.Parameters.AddWithValue("@LOGO", obj.LOGO);
            da.UpdateCommand.Parameters.AddWithValue("@POLITICA_CLAVE", obj.POLITICA_CLAVE);
            da.UpdateCommand.Parameters.AddWithValue("@FONDO_PANTALLA", obj.FONDO_PANTALLA);
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
