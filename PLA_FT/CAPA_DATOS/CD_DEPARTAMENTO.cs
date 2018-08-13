﻿using System.Data;
using System.Data.SqlClient;
using CAPA_ENTIDAD;

namespace CAPA_DATOS
{
   public class CD_DEPARTAMENTO
    {
        SqlConnection cn = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable CONSULTAR(string CONDICION)
        {
            cn.Close();
            da.SelectCommand = new SqlCommand("SP_DEPARTAMENTOS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@OPCION", "CONSULTAR");
            da.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
            cn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "DEPARTAMENTOS");
            cn.Close();

            return ds.Tables["DEPARTAMENTOS"];
        }

        public void INSERTAR(CE_DEPARTAMENTO obj)
        {
            cn.Close();
            da.InsertCommand = new SqlCommand("SP_DEPARTAMENTOS", cn);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.Parameters.AddWithValue("@OPCION", "AGREGAR");
            da.InsertCommand.Parameters.AddWithValue("@ID_OFICINA", obj.ID_OFICINA);
            da.InsertCommand.Parameters.AddWithValue("@DESCRIPCION", obj.DESCRIPCION);
            da.InsertCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();
        }

        public void ACTUALIZAR(CE_DEPARTAMENTO obj)
        {
            cn.Close();
            da.UpdateCommand = new SqlCommand("SP_DEPARTAMENTOS", cn);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.Parameters.AddWithValue("@OPCION", "ACTUALIZAR");
            da.UpdateCommand.Parameters.AddWithValue("@ID_DEPARTAMENTO", obj.ID_DEPARTAMENTO);
            da.UpdateCommand.Parameters.AddWithValue("@ID_OFICINA", obj.ID_OFICINA);
            da.UpdateCommand.Parameters.AddWithValue("@DESCRIPCION", obj.DESCRIPCION);
            da.UpdateCommand.Parameters.AddWithValue("@ESTADO", obj.ESTADO == "ACTIVO" ? "A" : "I");
            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();
        }
    }
}
