using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
   public class CD_LISTA_DOCUMENTO
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_LISTA_DOCUMENTOS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "LISTA_DOCUMENTOS");
            cn.Close();

            return ds.Tables["LISTA_DOCUMENTOS"];
        }

        public void INSERTAR(CE_LISTA_DOCUMENTO obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_LISTA_DOCUMENTOS", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR");
            da.InsertCommand.Parameters.AddWithValue("@DESCRIPCION", obj.DESCRIPCION);
            da.InsertCommand.Parameters.AddWithValue("@ENTREGADO", false);
            da.InsertCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void ACTUALIZAR(CE_LISTA_DOCUMENTO obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_LISTA_DOCUMENTOS", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@OPCION", "ACTUALIZAR");
            da.UpdateCommand.Parameters.AddWithValue("@ID_DOCUMENTO", obj.ID_DOCUMENTO);
            da.UpdateCommand.Parameters.AddWithValue("@DESCRIPCION", obj.DESCRIPCION);
            da.UpdateCommand.Parameters.AddWithValue("@ENTREGADO", false);
            da.UpdateCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
