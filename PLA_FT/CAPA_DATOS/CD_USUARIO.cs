using CAPA_ENTIDAD;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CD_USUARIO
    {
        public class CD_PUESTO
        {
            SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
            SqlDataAdapter da = new SqlDataAdapter();

            public DataTable CONSULTAR(string CONDICION)
            {
                cn.Close();
                da.SelectCommand = new SqlCommand("SP_USUARIOS", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
                da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
                cn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "USUARIOS");
                cn.Close();

                return ds.Tables["USUARIOS"];
            }

            public void INSERTAR(CE_USUARIO obj)
            {
                cn.Close();
                da.InsertCommand = new SqlCommand("SP_USUARIOS", cn);
                da.InsertCommand.CommandType = CommandType.StoredProcedure;
                da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR");
                da.InsertCommand.Parameters.AddWithValue("@ID_OFICINA", obj.ID_OFICINA);
                da.InsertCommand.Parameters.AddWithValue("@ID_DEPARTAMENTO", obj.ID_DEPARTAMENTO);
                da.InsertCommand.Parameters.AddWithValue("@ID_PUESTO", obj.ID_PUESTO);
                da.InsertCommand.Parameters.AddWithValue("@NOMBRE", obj.NOMBRE);
                da.InsertCommand.Parameters.AddWithValue("@USUARIO", obj.USUARIO);
                da.InsertCommand.Parameters.AddWithValue("@CLAVE", obj.CLAVE);
                da.InsertCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
                da.InsertCommand.Parameters.AddWithValue("@SEXO", obj.ESTADO == "MASCULINO" ? "M" : "F");
                cn.Open();
                da.InsertCommand.ExecuteNonQuery();
                cn.Close();
            }

            public void ACTUALIZAR(CE_USUARIO obj)
            {
                cn.Close();
                da.UpdateCommand = new SqlCommand("SP_USUARIOS", cn);
                da.UpdateCommand.CommandType = CommandType.StoredProcedure;
                da.UpdateCommand.Parameters.AddWithValue("@OPCION", "ACTUALIZAR");
                da.UpdateCommand.Parameters.AddWithValue("@ID_USUARIO", obj.ID_USUARIO);
                da.UpdateCommand.Parameters.AddWithValue("@ID_OFICINA", obj.ID_OFICINA);
                da.UpdateCommand.Parameters.AddWithValue("@ID_DEPARTAMENTO", obj.ID_DEPARTAMENTO);
                da.UpdateCommand.Parameters.AddWithValue("@ID_PUESTO", obj.ID_PUESTO);
                da.UpdateCommand.Parameters.AddWithValue("@NOMBRE", obj.NOMBRE);
                da.UpdateCommand.Parameters.AddWithValue("@USUARIO", obj.USUARIO);
                da.UpdateCommand.Parameters.AddWithValue("@CLAVE", obj.CLAVE);
                da.UpdateCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
                da.UpdateCommand.Parameters.AddWithValue("@SEXO", obj.ESTADO == "MASCULINO" ? "M" : "F");
                cn.Open();
                da.UpdateCommand.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}