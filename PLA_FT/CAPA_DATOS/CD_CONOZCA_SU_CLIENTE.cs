using CAPA_ENTIDAD;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
   public class CD_CONOZCA_SU_CLIENTE
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "CONOZCA_SU_CLIENTES");
            cn.Close();

            return ds.Tables["CONOZCA_SU_CLIENTES"];
        }

        public DataTable CONSULTAR_MAX()
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "MAX");
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "CONOZCA_SU_CLIENTES");
            cn.Close();

            return ds.Tables["CONOZCA_SU_CLIENTES"];
        }

        public void INSERTAR(CE_CONOZCA_SU_CLIENTE obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR");
            da.InsertCommand.Parameters.AddWithValue("@ACTIVIDAD_CAGO_PEP", obj.ACTIVIDAD_CAGO_PEP);
            da.InsertCommand.Parameters.AddWithValue("@ACTIVIDAD_DEL_NEGOCIO", obj.ACTIVIDAD_DEL_NEGOCIO);
            da.InsertCommand.Parameters.AddWithValue("@ACTIVIDAD_EMPRESA", obj.ACTIVIDAD_EMPRESA);
            da.InsertCommand.Parameters.AddWithValue("@ANTIGUEDAD_CONYUGUE", obj.ANTIGUEDAD_CONYUGUE);
            da.InsertCommand.Parameters.AddWithValue("@CARGO_CONYUGUE", obj.CARGO_CONYUGUE);
            da.InsertCommand.Parameters.AddWithValue("@CARGO_EN_EMPRESA", obj.CARGO_EN_EMPRESA);
            da.InsertCommand.Parameters.AddWithValue("@DIRECCION_EMPRESA", obj.DIRECCION_EMPRESA);
            da.InsertCommand.Parameters.AddWithValue("@DIRECCION_NEGOCIO", obj.DIRECCION_NEGOCIO);
            da.InsertCommand.Parameters.AddWithValue("@DIRECCION_TRABAJO_CONYUGUE", obj.DIRECCION_TRABAJO_CONYUGUE);
            da.InsertCommand.Parameters.AddWithValue("@EMPRESA_DONDE_LABORA", obj.EMPRESA_DONDE_LABORA);
            da.InsertCommand.Parameters.AddWithValue("@EMPRESA_TRAJAJO_CONYUGUE", obj.EMPRESA_TRAJAJO_CONYUGUE);
            da.InsertCommand.Parameters.AddWithValue("@FECHA", obj.FECHA);
            da.InsertCommand.Parameters.AddWithValue("@FECHA_INGRESO", obj.FECHA_INGRESO);
            da.InsertCommand.Parameters.AddWithValue("@ID_CLIENTE", obj.ID_CLIENTE);
            da.InsertCommand.Parameters.AddWithValue("@IDENTIFICACION_BENEFICIARIO", obj.IDENTIFICACION_BENEFICIARIO);
            da.InsertCommand.Parameters.AddWithValue("@IDENTIFICACION_CONYUGUE", obj.IDENTIFICACION_CONYUGUE);
            da.InsertCommand.Parameters.AddWithValue("@INGRESO_MENSUAL", obj.INGRESO_MENSUAL);
            da.InsertCommand.Parameters.AddWithValue("@NACIONALIDAD_CONYUGUE", obj.NACIONALIDAD_CONYUGUE);
            da.InsertCommand.Parameters.AddWithValue("@NEGOCIO_PROPIO", obj.NEGOCIO_PROPIO);
            da.InsertCommand.Parameters.AddWithValue("@NOMBRE_BENEFICIARIO", obj.NOMBRE_BENEFICIARIO);
            da.InsertCommand.Parameters.AddWithValue("@NOMBRE_CONYUGUE", obj.NOMBRE_CONYUGUE);
            da.InsertCommand.Parameters.AddWithValue("@NOMBRE_NEGOCIO", obj.NOMBRE_NEGOCIO);
            da.InsertCommand.Parameters.AddWithValue("@NOMBRE_PEP1", obj.NOMBRE_PEP1);
            da.InsertCommand.Parameters.AddWithValue("@NOMBRE_PEP2", obj.NOMBRE_PEP2);
            da.InsertCommand.Parameters.AddWithValue("@NUMERO_RUC", obj.NUMERO_RUC);
            da.InsertCommand.Parameters.AddWithValue("@OCUPACION_CONYUGUE", obj.OCUPACION_CONYUGUE);
            da.InsertCommand.Parameters.AddWithValue("@PARENTEZCO1", obj.PARENTEZCO1);
            da.InsertCommand.Parameters.AddWithValue("@PARENTEZCO2", obj.PARENTEZCO2);
            da.InsertCommand.Parameters.AddWithValue("@REFERENCIA_UBICACION_EMPRESA", obj.REFERENCIA_UBICACION_EMPRESA);
            da.InsertCommand.Parameters.AddWithValue("@REFERENCIA_UBICACION_NEGOCIO", obj.REFERENCIA_UBICACION_NEGOCIO);
            da.InsertCommand.Parameters.AddWithValue("@SUELDO", obj.SUELDO);
            da.InsertCommand.Parameters.AddWithValue("@SUELDO_MENSUAL_CONYUGUE", obj.SUELDO_MENSUAL_CONYUGUE);
            da.InsertCommand.Parameters.AddWithValue("@TELEFONO_EMPRESA", obj.TELEFONO_EMPRESA);
            da.InsertCommand.Parameters.AddWithValue("@TELEFONO_NEGOCIO", obj.TELEFONO_NEGOCIO);
            da.InsertCommand.Parameters.AddWithValue("@TELEFONO_TRABAJO_CONYUGUE", obj.TELEFONO_TRABAJO_CONYUGUE);
            da.InsertCommand.Parameters.AddWithValue("@TIEMPO_EN_EL_MERCADO", obj.TIEMPO_EN_EL_MERCADO);
            da.InsertCommand.Parameters.AddWithValue("@COMO_SE_ENTERO", obj.COMO_SE_ENTERO);

            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void ACTUALIZAR(CE_CONOZCA_SU_CLIENTE obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@OPCION", "ACTUALIZAR");
            da.UpdateCommand.Parameters.AddWithValue("@ID_CONOZCA", obj.ID_CONOZCA);
            da.UpdateCommand.Parameters.AddWithValue("@ACTIVIDAD_CAGO_PEP", obj.ACTIVIDAD_CAGO_PEP);
            da.UpdateCommand.Parameters.AddWithValue("@ACTIVIDAD_DEL_NEGOCIO", obj.ACTIVIDAD_DEL_NEGOCIO);
            da.UpdateCommand.Parameters.AddWithValue("@ACTIVIDAD_EMPRESA", obj.ACTIVIDAD_EMPRESA);
            da.UpdateCommand.Parameters.AddWithValue("@ANTIGUEDAD_CONYUGUE", obj.ANTIGUEDAD_CONYUGUE);
            da.UpdateCommand.Parameters.AddWithValue("@CARGO_CONYUGUE", obj.CARGO_CONYUGUE);
            da.UpdateCommand.Parameters.AddWithValue("@CARGO_EN_EMPRESA", obj.CARGO_EN_EMPRESA);
            da.UpdateCommand.Parameters.AddWithValue("@DIRECCION_EMPRESA", obj.DIRECCION_EMPRESA);
            da.UpdateCommand.Parameters.AddWithValue("@DIRECCION_NEGOCIO", obj.DIRECCION_NEGOCIO);
            da.UpdateCommand.Parameters.AddWithValue("@DIRECCION_TRABAJO_CONYUGUE", obj.DIRECCION_TRABAJO_CONYUGUE);
            da.UpdateCommand.Parameters.AddWithValue("@EMPRESA_DONDE_LABORA", obj.EMPRESA_DONDE_LABORA);
            da.UpdateCommand.Parameters.AddWithValue("@EMPRESA_TRAJAJO_CONYUGUE", obj.EMPRESA_TRAJAJO_CONYUGUE);
            da.UpdateCommand.Parameters.AddWithValue("@FECHA", obj.FECHA);
            da.UpdateCommand.Parameters.AddWithValue("@FECHA_INGRESO", obj.FECHA_INGRESO);
            da.UpdateCommand.Parameters.AddWithValue("@ID_CLIENTE", obj.ID_CLIENTE);
            da.UpdateCommand.Parameters.AddWithValue("@IDENTIFICACION_BENEFICIARIO", obj.IDENTIFICACION_BENEFICIARIO);
            da.UpdateCommand.Parameters.AddWithValue("@IDENTIFICACION_CONYUGUE", obj.IDENTIFICACION_CONYUGUE);
            da.UpdateCommand.Parameters.AddWithValue("@INGRESO_MENSUAL", obj.INGRESO_MENSUAL);
            da.UpdateCommand.Parameters.AddWithValue("@NACIONALIDAD_CONYUGUE", obj.NACIONALIDAD_CONYUGUE);
            da.UpdateCommand.Parameters.AddWithValue("@NEGOCIO_PROPIO", obj.NEGOCIO_PROPIO);
            da.UpdateCommand.Parameters.AddWithValue("@NOMBRE_BENEFICIARIO", obj.NOMBRE_BENEFICIARIO);
            da.UpdateCommand.Parameters.AddWithValue("@NOMBRE_CONYUGUE", obj.NOMBRE_CONYUGUE);
            da.UpdateCommand.Parameters.AddWithValue("@NOMBRE_NEGOCIO", obj.NOMBRE_NEGOCIO);
            da.UpdateCommand.Parameters.AddWithValue("@NOMBRE_PEP1", obj.NOMBRE_PEP1);
            da.UpdateCommand.Parameters.AddWithValue("@NOMBRE_PEP2", obj.NOMBRE_PEP2);
            da.UpdateCommand.Parameters.AddWithValue("@NUMERO_RUC", obj.NUMERO_RUC);
            da.UpdateCommand.Parameters.AddWithValue("@OCUPACION_CONYUGUE", obj.OCUPACION_CONYUGUE);
            da.UpdateCommand.Parameters.AddWithValue("@PARENTEZCO1", obj.PARENTEZCO1);
            da.UpdateCommand.Parameters.AddWithValue("@PARENTEZCO2", obj.PARENTEZCO2);
            da.UpdateCommand.Parameters.AddWithValue("@REFERENCIA_UBICACION_EMPRESA", obj.REFERENCIA_UBICACION_EMPRESA);
            da.UpdateCommand.Parameters.AddWithValue("@REFERENCIA_UBICACION_NEGOCIO", obj.REFERENCIA_UBICACION_NEGOCIO);
            da.UpdateCommand.Parameters.AddWithValue("@SUELDO", obj.SUELDO);
            da.UpdateCommand.Parameters.AddWithValue("@SUELDO_MENSUAL_CONYUGUE", obj.SUELDO_MENSUAL_CONYUGUE);
            da.UpdateCommand.Parameters.AddWithValue("@TELEFONO_EMPRESA", obj.TELEFONO_EMPRESA);
            da.UpdateCommand.Parameters.AddWithValue("@TELEFONO_NEGOCIO", obj.TELEFONO_NEGOCIO);
            da.UpdateCommand.Parameters.AddWithValue("@TELEFONO_TRABAJO_CONYUGUE", obj.TELEFONO_TRABAJO_CONYUGUE);
            da.UpdateCommand.Parameters.AddWithValue("@TIEMPO_EN_EL_MERCADO", obj.TIEMPO_EN_EL_MERCADO);
            da.UpdateCommand.Parameters.AddWithValue("@COMO_SE_ENTERO", obj.COMO_SE_ENTERO);

            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }

        //REFERENCIAS_PERSONALES
        public void INSERTAR_REFERENCIAS_PERSONALES(CE_CONOZCA_SU_CLIENTE obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR_REFERENCIAS_PERSONALES");
            da.InsertCommand.Parameters.AddWithValue("@ID_CONOZCA_RP", obj.ID_CONOZCA_RP);
            da.InsertCommand.Parameters.AddWithValue("@NOMBRE_RP", obj.NOMBRE_RP);
            da.InsertCommand.Parameters.AddWithValue("@DIRECCION_RP", obj.DIRECCION_RP);
            da.InsertCommand.Parameters.AddWithValue("@IDENTIFICACION_RP", obj.IDENTIFICACION_RP);
            da.InsertCommand.Parameters.AddWithValue("@PARENTEZCO_RP", obj.PARENTEZCO_RP);
            da.InsertCommand.Parameters.AddWithValue("@TELEFONO_RP", obj.TELEFONO_RP);
            
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable CONSULTAR_REFERENCIAS_PERSONALES(int ID_CONOZCA_RP)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR_REFERENCIAS_PERSONALES");
            da.SelectCommand.Parameters.AddWithValue("@ID_CONOZCA_RP", ID_CONOZCA_RP);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "REFERENCIAS_PERSONALES");
            cn.Close();

            return ds.Tables["REFERENCIAS_PERSONALES"];
        }

        public void ELIMINAR_REFERENCIAS_PERSONALES(int ID_CONOZCA_RP)
        {
            cn.Close();
            da.DeleteCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.DeleteCommand.CommandType = CommandType.StoredProcedure;
            da.DeleteCommand.Parameters.AddWithValue("@OPCION", "ELIMINAR_REFERENCIAS_PERSONALES");
            da.DeleteCommand.Parameters.AddWithValue("@ID_CONOZCA_RP", ID_CONOZCA_RP);
            cn.Open();
            da.DeleteCommand.ExecuteNonQuery();
            cn.Close();
        }

        //REFERENCIAS_COMERCIALES
        public void INSERTAR_REFERENCIAS_COMERCIALES(CE_CONOZCA_SU_CLIENTE obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR_REFERENCIAS_COMERCIALES");
            da.InsertCommand.Parameters.AddWithValue("@ID_CONOZCA_RC", obj.ID_CONOZCA_RC);
            da.InsertCommand.Parameters.AddWithValue("@DIRECCION_RC", obj.DIRECCION_RC);
            da.InsertCommand.Parameters.AddWithValue("@NOMBRE_RC", obj.NOMBRE_RC);
            da.InsertCommand.Parameters.AddWithValue("@TELEFONO_RC", obj.TELEFONO_RC);

            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable CONSULTAR_REFERENCIAS_COMERCIALES(int ID_CONOZCA_RC)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR_REFERENCIAS_COMERCIALES");
            da.SelectCommand.Parameters.AddWithValue("@ID_CONOZCA_RC", ID_CONOZCA_RC);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "REFERENCIAS_COMERCIALES");
            cn.Close();

            return ds.Tables["REFERENCIAS_COMERCIALES"];
        }

        public void ELIMINAR_REFERENCIAS_COMERCIALES(int ID_CONOZCA_RC)
        {
            cn.Close();
            da.DeleteCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.DeleteCommand.CommandType = CommandType.StoredProcedure;
            da.DeleteCommand.Parameters.AddWithValue("@OPCION", "ELIMINAR_REFERENCIAS_COMERCIALES");
            da.DeleteCommand.Parameters.AddWithValue("@ID_CONOZCA_RC", ID_CONOZCA_RC);
            cn.Open();
            da.DeleteCommand.ExecuteNonQuery();
            cn.Close();
        }

        //REFERENCIAS_BANCARIAS
        public void INSERTAR_REFERENCIAS_BANCARIAS(CE_CONOZCA_SU_CLIENTE obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR_REFERENCIAS_BANCARIAS");
            da.InsertCommand.Parameters.AddWithValue("@ID_CONOZCA_RB", obj.ID_CONOZCA_RB);
            da.InsertCommand.Parameters.AddWithValue("@BANCO_RB", obj.BANCO_RB);
            da.InsertCommand.Parameters.AddWithValue("@TIPO_CUENTA_RB", obj.TIPO_CUENTA_RB);

            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable CONSULTAR_REFERENCIAS_BANCARIAS(int ID_CONOZCA_RB)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR_REFERENCIAS_BANCARIAS");
            da.SelectCommand.Parameters.AddWithValue("@ID_CONOZCA_RB", ID_CONOZCA_RB);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "REFERENCIAS_BANCARIAS");
            cn.Close();

            return ds.Tables["REFERENCIAS_BANCARIAS"];
        }

        public void ELIMINAR_REFERENCIAS_BANCARIAS(int ID_CONOZCA_RB)
        {
            cn.Close();
            da.DeleteCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.DeleteCommand.CommandType = CommandType.StoredProcedure;
            da.DeleteCommand.Parameters.AddWithValue("@OPCION", "ELIMINAR_REFERENCIAS_BANCARIAS");
            da.DeleteCommand.Parameters.AddWithValue("@ID_CONOZCA_RB", ID_CONOZCA_RB);
            cn.Open();
            da.DeleteCommand.ExecuteNonQuery();
            cn.Close();
        }


        //LISTA DOCUMENTOS
        public void INSERTAR_LISTA_DOCUMENTO(CE_CONOZCA_SU_CLIENTE obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR_LISTA_DOCUMENTO");
            da.InsertCommand.Parameters.AddWithValue("@ID_CONOZCA_D", obj.ID_CONOZCA_D);
            da.InsertCommand.Parameters.AddWithValue("@DOCUMENTO", obj.DOCUMENTO);

            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable CONSULTAR_LISTA_DOCUMENTOS(int ID_CONOZCA_D)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR_LISTA_DOCUMENTO");
            da.SelectCommand.Parameters.AddWithValue("@ID_CONOZCA_D", ID_CONOZCA_D);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "LISTA_DOCUMENTOS_CONOZCA");
            cn.Close();

            return ds.Tables["LISTA_DOCUMENTOS_CONOZCA"];
        }

        public void ELIMINAR_LISTA_DOCUMENTO(int ID_CONOZCA_D)
        {
            cn.Close();
            da.DeleteCommand = new SqlCommand("SP_CONOZCA_SU_CLIENTES", cn);
            da.DeleteCommand.CommandType = CommandType.StoredProcedure;
            da.DeleteCommand.Parameters.AddWithValue("@OPCION", "ELIMINAR_LISTA_DOCUMENTO");
            da.DeleteCommand.Parameters.AddWithValue("@ID_CONOZCA_D", ID_CONOZCA_D);
            cn.Open();
            da.DeleteCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
