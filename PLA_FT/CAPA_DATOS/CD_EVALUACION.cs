using CAPA_ENTIDAD;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
   public class CD_EVALUACION
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_EVALUACIONES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "EVALUACIONES");
            cn.Close();

            return ds.Tables["EVALUACIONES"];
        }

        public DataTable CONSULTAR_MAX()
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_EVALUACIONES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "MAX");
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "EVALUACIONES");
            cn.Close();

            return ds.Tables["EVALUACIONES"];
        }

        public void INSERTAR(CE_EVALUACION obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_EVALUACIONES", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR");
            da.InsertCommand.Parameters.AddWithValue("@FECHA", obj.FECHA);
            da.InsertCommand.Parameters.AddWithValue("@ID_ACTIVIDAD", obj.ID_ACTIVIDAD);
            da.InsertCommand.Parameters.AddWithValue("@ID_CANTIDAD", obj.ID_CANTIDAD);
            da.InsertCommand.Parameters.AddWithValue("@ID_CLIENTE", obj.ID_CLIENTE);
            da.InsertCommand.Parameters.AddWithValue("@ID_NACIONALIDAD", obj.ID_NACIONALIDAD);
            da.InsertCommand.Parameters.AddWithValue("@ID_PAIS", obj.ID_PAIS);
            da.InsertCommand.Parameters.AddWithValue("@ID_PROVINCIA", obj.ID_PROVINCIA);
            da.InsertCommand.Parameters.AddWithValue("@ID_RECOMENDACION", obj.ID_RECOMENDACION);
            da.InsertCommand.Parameters.AddWithValue("@VALOR_ACTIVIDAD", obj.VALOR_ACTIVIDAD);
            da.InsertCommand.Parameters.AddWithValue("@VALOR_CANAL", obj.VALOR_CANAL);
            da.InsertCommand.Parameters.AddWithValue("@VALOR_CANTIDAD", obj.VALOR_CANTIDAD);
            da.InsertCommand.Parameters.AddWithValue("@VALOR_NACIONALIDAD", obj.VALOR_NACIONALIDAD);
            da.InsertCommand.Parameters.AddWithValue("@VALOR_PAIS", obj.VALOR_PAIS);
            da.InsertCommand.Parameters.AddWithValue("@VALOR_PRODUCTO", obj.VALOR_PRODUCTO);
            da.InsertCommand.Parameters.AddWithValue("@VALOR_PROVINCIA", obj.VALOR_PROVINCIA);
            da.InsertCommand.Parameters.AddWithValue("@VALOR_TOTAL", obj.VALOR_TOTAL);


            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void ACTUALIZAR(CE_EVALUACION obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_EVALUACIONES", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@OPCION", "ACTUALIZAR");
            da.UpdateCommand.Parameters.AddWithValue("@ID_EVALUACION", obj.ID_EVALUACION);
            da.UpdateCommand.Parameters.AddWithValue("@ID_ACTIVIDAD", obj.ID_ACTIVIDAD);
            da.UpdateCommand.Parameters.AddWithValue("@ID_CANTIDAD", obj.ID_CANTIDAD);
            da.UpdateCommand.Parameters.AddWithValue("@ID_CLIENTE", obj.ID_CLIENTE);
            da.UpdateCommand.Parameters.AddWithValue("@ID_NACIONALIDAD", obj.ID_NACIONALIDAD);
            da.UpdateCommand.Parameters.AddWithValue("@ID_PAIS", obj.ID_PAIS);
            da.UpdateCommand.Parameters.AddWithValue("@ID_PROVINCIA", obj.ID_PROVINCIA);
            da.UpdateCommand.Parameters.AddWithValue("@ID_RECOMENDACION", obj.ID_RECOMENDACION);
            da.UpdateCommand.Parameters.AddWithValue("@VALOR_ACTIVIDAD", obj.VALOR_ACTIVIDAD);
            da.UpdateCommand.Parameters.AddWithValue("@VALOR_CANAL", obj.VALOR_CANAL);
            da.UpdateCommand.Parameters.AddWithValue("@VALOR_CANTIDAD", obj.VALOR_CANTIDAD);
            da.UpdateCommand.Parameters.AddWithValue("@VALOR_NACIONALIDAD", obj.VALOR_NACIONALIDAD);
            da.UpdateCommand.Parameters.AddWithValue("@VALOR_PAIS", obj.VALOR_PAIS);
            da.UpdateCommand.Parameters.AddWithValue("@VALOR_PRODUCTO", obj.VALOR_PRODUCTO);
            da.UpdateCommand.Parameters.AddWithValue("@VALOR_PROVINCIA", obj.VALOR_PROVINCIA);
            da.UpdateCommand.Parameters.AddWithValue("@VALOR_TOTAL", obj.VALOR_TOTAL);
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
