using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CAPA_DATOS
{
   public class CD_UTILIDADES
    {
        SqlConnection CON = new SqlConnection(CD_CONEXION.cadena_conexion);
        SqlDataAdapter DA = new SqlDataAdapter();

       public void LLENAR_COMBOBOX(ComboBox COMBO, string SP, string TABLA, string VALOR, string CODIGO, string CONDICION)
       {
           DA.SelectCommand = new SqlCommand(SP, CON);
           DA.SelectCommand.CommandType = CommandType.StoredProcedure;
           DA.SelectCommand.Parameters.AddWithValue("@TABLA", TABLA);
           DA.SelectCommand.Parameters.AddWithValue("@VALOR_CODIGO", CODIGO);
           DA.SelectCommand.Parameters.AddWithValue("@VALOR_MOSTRAR", VALOR);
           DA.SelectCommand.Parameters.AddWithValue("@CONDICION", CONDICION);
           DataSet ds = new DataSet();
           CON.Open();
           DA.Fill(ds, TABLA);
           CON.Close();
           COMBO.DataSource = ds.Tables[TABLA];
           COMBO.DisplayMember = VALOR;
           COMBO.ValueMember = CODIGO;
           COMBO.SelectedItem = null;
       }
    }
}
