using CAPA_ENTIDAD;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
   public class CD_PRODUCTO_EVALUACION
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_PRODUCTOS_EVALUACION", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "PRODUCTOS_EVALUACION");
            cn.Close();

            return ds.Tables["PRODUCTOS_EVALUACION"];
        }

        public void INSERTAR(CE_PRODUCTO_EVALUACION obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_PRODUCTOS_EVALUACION", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR");
            da.InsertCommand.Parameters.AddWithValue("@ID_EVALUACION", obj.ID_EVALUACION);
            da.InsertCommand.Parameters.AddWithValue("@ID_PRODUCTO", obj.ID_PRODUCTO);
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void ELIMINAR(int ID_EVALUACION)
        {
            cn.Close();
            da.DeleteCommand = new SqlCommand("SP_PRODUCTOS_EVALUACION", cn);
            da.DeleteCommand.CommandType = CommandType.StoredProcedure;
            da.DeleteCommand.Parameters.AddWithValue("@OPCION", "ELIMINAR");
            da.DeleteCommand.Parameters.AddWithValue("@ID_EVALUACION", ID_EVALUACION);
            cn.Open();
            da.DeleteCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
