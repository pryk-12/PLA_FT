using CAPA_ENTIDAD;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CD_PONDERACION
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR(int ID_PONDERACION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_PONDERACIONES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
            da.SelectCommand.Parameters.AddWithValue("@ID_PONDERACION", ID_PONDERACION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "PONDERACIONES");
            cn.Close();

            return ds.Tables["PONDERACIONES"];
        }

        public void ACTUALIZAR(CE_PONDERACION obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_PONDERACIONES", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@OPCION", "ACTUALIZAR");
            da.UpdateCommand.Parameters.AddWithValue("@ID_PONDERACION", obj.ID_PONDERACION);
            da.UpdateCommand.Parameters.AddWithValue("@PORCIENTO", obj.PORCIENTO);
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
