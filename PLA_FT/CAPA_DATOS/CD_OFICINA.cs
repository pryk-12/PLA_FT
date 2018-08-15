using System.Data;
using System.Data.SqlClient;
using CAPA_ENTIDAD;

namespace CAPA_DATOS
{
    public class CD_OFICINA
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_OFICINAS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION",  CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "OFICINAS");
            cn.Close();

            return ds.Tables["OFICINAS"];
        }

        public void INSERTAR(CE_OFICINA obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_OFICINAS", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR");
            da.InsertCommand.Parameters.AddWithValue("@DESCRIPCION", obj.DESCRIPCION);
            da.InsertCommand.Parameters.AddWithValue("@DIRECCION", obj.DIRECCION);
            da.InsertCommand.Parameters.AddWithValue("@TELEFONO", obj.TELEFONO);
            da.InsertCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
            da.InsertCommand.Parameters.AddWithValue("@VALORACION", obj.VALORACION);
            da.InsertCommand.Parameters.AddWithValue("@NIVEL_RIESGO", obj.NIVEL_RIESGO);

            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void ACTUALIZAR(CE_OFICINA obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_OFICINAS", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@OPCION", "ACTUALIZAR");
            da.UpdateCommand.Parameters.AddWithValue("@ID_OFICINA", obj.ID_OFICINA);
            da.UpdateCommand.Parameters.AddWithValue("@DESCRIPCION", obj.DESCRIPCION);
            da.UpdateCommand.Parameters.AddWithValue("@DIRECCION", obj.DIRECCION);
            da.UpdateCommand.Parameters.AddWithValue("@TELEFONO", obj.TELEFONO);
            da.UpdateCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
            da.UpdateCommand.Parameters.AddWithValue("@VALORACION", obj.VALORACION);
            da.UpdateCommand.Parameters.AddWithValue("@NIVEL_RIESGO", obj.NIVEL_RIESGO);
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
