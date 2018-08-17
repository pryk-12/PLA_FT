using CAPA_ENTIDAD;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
   public class CD_OBSERVACION
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_OBSERVACIONES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "OBSERVACIONES");
            cn.Close();

            return ds.Tables["OBSERVACIONES"];
        }

        public void INSERTAR(CE_OBSERVACION obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_RECOMENDACIONES", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "INSERTAR");
            da.InsertCommand.Parameters.AddWithValue("@ID_EVALUACION", obj.ID_EVALUACION);
            da.InsertCommand.Parameters.AddWithValue("@DESCRIPCION", obj.DESCRIPCION);
            da.InsertCommand.Parameters.AddWithValue("@FECHA", obj.FECHA);
            da.InsertCommand.Parameters.AddWithValue("@USUARIO", obj.USUARIO);
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
