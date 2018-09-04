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
            da.SelectCommand = new SqlCommand("SELECT * FROM V_CLIENTES WHERE ESTADO='ACTIVO' AND "+ CONDICION +"", cn);
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
            da.InsertCommand.Parameters.AddWithValue("@NOMBRES", obj.NOMBRES);
            da.InsertCommand.Parameters.AddWithValue("@APELLIDO_MAT", obj.APELLIDO_MAT);
            da.InsertCommand.Parameters.AddWithValue("@APELLIDO_PAT", obj.APELLIDO_PAT);
            da.InsertCommand.Parameters.AddWithValue("@CELULAR", obj.CELULAR);
            da.InsertCommand.Parameters.AddWithValue("@DIRECCION_RESIDENCIAL", obj.DIRECCION_RESIDENCIAL);
            da.InsertCommand.Parameters.AddWithValue("@EMAIL", obj.EMAIL);
            da.InsertCommand.Parameters.AddWithValue("@ES_PEP", obj.ES_PEP == true ? "1" : "0");
            da.InsertCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
            da.InsertCommand.Parameters.AddWithValue("@ESTADO_CIVIL", obj.ESTADO_CIVIL);
            da.InsertCommand.Parameters.AddWithValue("@FECHA_NACIMIENTO", obj.FECHA_NACIMIENTO);
            da.InsertCommand.Parameters.AddWithValue("@ID_LUGAR_NACIMIENTO", obj.ID_LUGAR_NACIMIENTO);
            da.InsertCommand.Parameters.AddWithValue("@ID_NACIONALIDAD", obj.ID_NACIONALIDAD);
            da.InsertCommand.Parameters.AddWithValue("@ID_OCUPACION", obj.ID_OCUPACION);
            da.InsertCommand.Parameters.AddWithValue("@ID_OFICINA", obj.ID_OFICINA);
            da.InsertCommand.Parameters.AddWithValue("@ID_PROVINCIA", obj.ID_PROVINCIA);
            da.InsertCommand.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", obj.ID_TIPO_IDENTIFICACION);
            da.InsertCommand.Parameters.AddWithValue("@IDENTIFICACION", obj.IDENTIFICACION);
            da.InsertCommand.Parameters.AddWithValue("@SEXO", obj.SEXO == "MASCULINO" ? "M" : "F");
            da.InsertCommand.Parameters.AddWithValue("@TELEFONO", obj.TELEFONO);
            da.InsertCommand.Parameters.AddWithValue("@TIPO_CLIENTE", obj.TIPO_CLIENTE == "FISICO" ? "F" : "J");
            da.InsertCommand.Parameters.AddWithValue("@TIPO_VIVIENDA", obj.TIPO_VIVIENDA);
            da.InsertCommand.Parameters.AddWithValue("@VINCULADO_PEP", obj.VINCULADO_PEP == true ? "1" : "0");


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
            da.UpdateCommand.Parameters.AddWithValue("@NOMBRES", obj.NOMBRES);
            da.UpdateCommand.Parameters.AddWithValue("@APELLIDO_MAT", obj.APELLIDO_MAT);
            da.UpdateCommand.Parameters.AddWithValue("@APELLIDO_PAT", obj.APELLIDO_PAT);
            da.UpdateCommand.Parameters.AddWithValue("@CELULAR", obj.CELULAR);
            da.UpdateCommand.Parameters.AddWithValue("@DIRECCION_RESIDENCIAL", obj.DIRECCION_RESIDENCIAL);
            da.UpdateCommand.Parameters.AddWithValue("@EMAIL", obj.EMAIL);
            da.UpdateCommand.Parameters.AddWithValue("@ES_PEP", obj.ES_PEP == true ? "1" : "0");
            da.UpdateCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
            da.UpdateCommand.Parameters.AddWithValue("@ESTADO_CIVIL", obj.ESTADO_CIVIL);
            da.UpdateCommand.Parameters.AddWithValue("@FECHA_NACIMIENTO", obj.FECHA_NACIMIENTO);
            da.UpdateCommand.Parameters.AddWithValue("@ID_LUGAR_NACIMIENTO", obj.ID_LUGAR_NACIMIENTO);
            da.UpdateCommand.Parameters.AddWithValue("@ID_NACIONALIDAD", obj.ID_NACIONALIDAD);
            da.UpdateCommand.Parameters.AddWithValue("@ID_OCUPACION", obj.ID_OCUPACION);
            da.UpdateCommand.Parameters.AddWithValue("@ID_OFICINA", obj.ID_OFICINA);
            da.UpdateCommand.Parameters.AddWithValue("@ID_PROVINCIA", obj.ID_PROVINCIA);
            da.UpdateCommand.Parameters.AddWithValue("@ID_TIPO_IDENTIFICACION", obj.ID_TIPO_IDENTIFICACION);
            da.UpdateCommand.Parameters.AddWithValue("@IDENTIFICACION", obj.IDENTIFICACION);
            da.UpdateCommand.Parameters.AddWithValue("@SEXO", obj.SEXO == "MASCULINO" ? "M" : "F");
            da.UpdateCommand.Parameters.AddWithValue("@TELEFONO", obj.TELEFONO);
            da.UpdateCommand.Parameters.AddWithValue("@TIPO_CLIENTE", obj.TIPO_CLIENTE == "FISICO" ? "F" : "J");
            da.UpdateCommand.Parameters.AddWithValue("@TIPO_VIVIENDA", obj.TIPO_VIVIENDA);
            da.UpdateCommand.Parameters.AddWithValue("@VINCULADO_PEP", obj.VINCULADO_PEP == true ? "1" : "0");
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
