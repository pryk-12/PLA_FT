using CAPA_ENTIDAD;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
   public class CD_ACTIVIDAD_ECONOMICA
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_ACTIVIDADES_ECONOMICAS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "ACTIVIDADES_ECONOMICAS");
            cn.Close();

            return ds.Tables["ACTIVIDADES_ECONOMICAS"];
        }

        public void INSERTAR(CE_ACTIVIDAD_ECONOMICA obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_ACTIVIDADES_ECONOMICAS", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR");
            da.InsertCommand.Parameters.AddWithValue("@DESCRIPCION", obj.DESCRIPCION);
            da.InsertCommand.Parameters.AddWithValue("@VALORACION", obj.VALORACION);
            da.InsertCommand.Parameters.AddWithValue("@NIVEL_RIESGO", obj.NIVEL_RIESGO);
            da.InsertCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void ACTUALIZAR(CE_ACTIVIDAD_ECONOMICA obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_ACTIVIDADES_ECONOMICAS", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@OPCION", "ACTUALIZAR");
            da.UpdateCommand.Parameters.AddWithValue("@ID_ACTIVIDAD", obj.ID_ACTIVIDAD);
            da.UpdateCommand.Parameters.AddWithValue("@DESCRIPCION", obj.DESCRIPCION);
            da.UpdateCommand.Parameters.AddWithValue("@VALORACION", obj.VALORACION);
            da.UpdateCommand.Parameters.AddWithValue("@NIVEL_RIESGO", obj.NIVEL_RIESGO);
            da.UpdateCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
