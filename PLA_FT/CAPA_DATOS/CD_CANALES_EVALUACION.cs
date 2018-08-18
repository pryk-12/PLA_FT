using CAPA_ENTIDAD;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
   public class CD_CANALES_EVALUACION
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_CANALES_EVALUACION", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "CANALES_EVALUACION");
            cn.Close();

            return ds.Tables["CANALES_EVALUACION"];
        }

        public void INSERTAR(CE_CANALES_EVALUACION obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_CANALES_EVALUACION", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR");
            da.InsertCommand.Parameters.AddWithValue("@ID_EVALUACION", obj.ID_EVALUACION);
            da.InsertCommand.Parameters.AddWithValue("@ID_CANAL", obj.ID_CANAL);
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void ELIMINAR(int ID_EVALUACION)
        {
            cn.Close();
            da.DeleteCommand = new SqlCommand("SP_CANALES_EVALUACION", cn);
            da.DeleteCommand.CommandType = CommandType.StoredProcedure;
            da.DeleteCommand.Parameters.AddWithValue("@OPCION", "ELIMINAR");
            da.DeleteCommand.Parameters.AddWithValue("@ID_EVALUACION", ID_EVALUACION);
            cn.Open();
            da.DeleteCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
