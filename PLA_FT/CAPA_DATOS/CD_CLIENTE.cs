using CAPA_ENTIDAD;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
   public class CD_CLIENTE
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_CLIENTES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "CLIENTES");
            cn.Close();

            return ds.Tables["CLIENTES"];
        }

        public DataTable VISTA_CLIENTE(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SELECT * FROM V_CLIENTES WHERE ESTADO='A' AND "+ CONDICION +"", cn);
            da.SelectCommand.CommandType = CommandType.Text;
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "V_CLIENTES");
            cn.Close();

            return ds.Tables["V_CLIENTES"];
        }

        public void INSERTAR(CE_CLIENTE obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_CLIENTES", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR");
            da.InsertCommand.Parameters.AddWithValue("@NOMBRE", obj.NOMBRE);
            da.InsertCommand.Parameters.AddWithValue("@IDENTIFICACION", obj.IDENTIFICACION);
            da.InsertCommand.Parameters.AddWithValue("@ID_OFICINA", obj.ID_OFICINA);
            da.InsertCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
            da.InsertCommand.Parameters.AddWithValue("@TIPO", obj.TIPO == "FISICO" ? "F" : "J");

            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void ACTUALIZAR(CE_CLIENTE obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_CLIENTES", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@OPCION", "ACTUALIZAR");
            da.UpdateCommand.Parameters.AddWithValue("@ID_CLIENTE", obj.ID_CLIENTE);
            da.UpdateCommand.Parameters.AddWithValue("@NOMBRE", obj.NOMBRE);
            da.UpdateCommand.Parameters.AddWithValue("@IDENTIFICACION", obj.IDENTIFICACION);
            da.UpdateCommand.Parameters.AddWithValue("@ID_OFICINA", obj.ID_OFICINA);
            da.UpdateCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
            da.UpdateCommand.Parameters.AddWithValue("@TIPO", obj.TIPO == "FISICO" ? "F" : "J");
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
