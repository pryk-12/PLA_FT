using CAPA_ENTIDAD;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CD_PERMISO
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR_MENU()
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_PERMISOS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR_MENU");
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "MENU");
            cn.Close();

            return ds.Tables["MENU"];
        }

        public DataTable CONSULTAR_PERMISO_MENU(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_PERMISOS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR_PERMISO_MENU");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "PERMISO_MENU");
            cn.Close();

            return ds.Tables["PERMISO_MENU"];
        }

        public DataTable CONSULTAR_PERMISO(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_PERMISOS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR_PERMISOS");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "PERMISOS");
            cn.Close();

            return ds.Tables["PERMISOS"];
        }

        public DataTable CONSULTAR_PANTALLAS(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_PERMISOS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR_PANTALLAS");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "PANTALLAS");
            cn.Close();

            return ds.Tables["PANTALLAS"];
        }

        public void ELIMINAR_MENU(string USUARIO)
        {
            cn.Close();
            da.DeleteCommand = new SqlCommand("SP_PERMISOS", cn);
            da.DeleteCommand.CommandType = CommandType.StoredProcedure;
            da.DeleteCommand.Parameters.AddWithValue("@OPCION", "ELIMINAR_MENU");
            da.DeleteCommand.Parameters.AddWithValue("@MENU_USUARIO", USUARIO);
            cn.Open();
            da.DeleteCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void INSERTAR_MENU(CE_PERMISO obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_PERMISOS", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR_MENU");
            da.InsertCommand.Parameters.AddWithValue("@MENU_USUARIO", obj.MENU_USUARIO);
            da.InsertCommand.Parameters.AddWithValue("@MENU_MENU", obj.MENU_MENU);
            da.InsertCommand.Parameters.AddWithValue("@MENU_ACCESO", obj.MENU_ACCESO);
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void ELIMINAR_PERMISO(string USUARIO)
        {
            cn.Close();
            da.DeleteCommand = new SqlCommand("SP_PERMISOS", cn);
            da.DeleteCommand.CommandType = CommandType.StoredProcedure;
            da.DeleteCommand.Parameters.AddWithValue("@OPCION", "ELIMINAR_PERMISO");
            da.DeleteCommand.Parameters.AddWithValue("@PERMISO_USUARIO", USUARIO);
            cn.Open();
            da.DeleteCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void INSERTAR_PERMISO(CE_PERMISO obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_PERMISOS", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR_PERMISO");
            da.InsertCommand.Parameters.AddWithValue("@PERMISO_USUARIO", obj.PERMISO_USUARIO);
            da.InsertCommand.Parameters.AddWithValue("@PERMISO_ACCESO", obj.PERMISO_ACCESO);
            da.InsertCommand.Parameters.AddWithValue("@PERMISO_AGREGAR", obj.PERMISO_AGREGAR);
            da.InsertCommand.Parameters.AddWithValue("@PERMISO_EDITAR", obj.PERMISO_EDITAR);
            da.InsertCommand.Parameters.AddWithValue("@PERMISO_PANTALLA", obj.PERMISO_PANTALLA);
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
