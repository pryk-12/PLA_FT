using CAPA_NEGOCIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_EVALUACION : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_EVALUACION()
        {
            InitializeComponent();
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_actividad_economica, "SP_LLENAR_COMBOBOX", "ACTIVIDADES_ECONOMICAS", "DESCRIPCION", "ID_ACTIVIDAD", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_nacionalidades, "SP_LLENAR_COMBOBOX", "PAISES", "DESCRIPCION", "ID_PAIS", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_paises, "SP_LLENAR_COMBOBOX", "PAISES", "DESCRIPCION", "ID_PAIS", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_provincias, "SP_LLENAR_COMBOBOX", "PROVINCIAS", "DESCRIPCION", "ID_PROVINCIA", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_cantidades_efectivo, "SP_LLENAR_COMBOBOX", "CANTIDADES_EFECTIVO", "DESCRIPCION", "ID_CANTIDAD", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_oficina, "SP_LLENAR_COMBOBOX", "OFICINAS", "DESCRIPCION", "ID_OFICINA", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
        }

        public void LISTAR_PRODUCTOS()
        {
            string CONDICION = "(DESCRIPCION LIKE'%" + "" + "%')";
            DG_PRODUCTOS.DataSource = CN_PRODUCTO.CONSULTAR(CONDICION);
        }

        public void LISTAR_CANALES()
        {
            string CONDICION = "(DESCRIPCION LIKE'%" + "" + "%')";
            DG_CANALES.DataSource = CN_CANAL.CONSULTAR(CONDICION);
        }

        private void FRM_EVALUACION_Load(object sender, EventArgs e)
        {
            if(txt_id.Text.Equals(""))
            {
                LISTAR_PRODUCTOS();
                LISTAR_CANALES();
                this.Text = "Agregar Evaluación";
            }
            else
            {
                this.Text = "Editar Evaluación";
            }
            GRAFICO_BARRA();
            GRAFICO_COLUMNAS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_CONSULTAR_CLIENTES FRM = new FRM_CONSULTAR_CLIENTES();
            FRM.ShowDialog();
        }

        public void BUSCAR_CLIENTE()
        {
          if(  CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE="+ txt_id_cliente.Text +"").Rows.Count>0)
          {
              txt_nombre.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["NOMBRE"].ToString();
              txt_identificacion.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["IDENTIFICACION"].ToString();
              cb_oficina.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["OFICINA"].ToString();
              cb_tipo.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["TIPO"].ToString();
          }
            else
          {
              CP_UTILIDADES.MENSAJE_INFORMACION("Este Cliente No Existe",this);
              txt_id_cliente.Text = "";
              txt_nombre.Text = "";
              txt_identificacion.Text = "";
              cb_oficina.Text = "";
              cb_tipo.Text = "";
          }
        }

        private void txt_id_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BUSCAR_CLIENTE();
            }
        }

        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                GRAFICO_BARRA();
            }
        }

        public void GRAFICO_BARRA()
        {
            int total = txt_total.Text.Length == 0 ? 0 : Convert.ToInt32(txt_total.Text);

            ch_barras.Series["BARRAS"].Points.Clear();
            ch_barras.Series["BARRAS"].Points.Add(total);
            
            ch_barras.Series["BARRAS"].Points[0].AxisLabel = " ";
            ch_barras.Series["BARRAS"].Points[0].Label = total.ToString()+" %";
            ch_barras.Series["BARRAS"].Points[0].LabelForeColor = Color.Black;
            if (total<=30)
            {
                ch_barras.Series["BARRAS"].Points[0].Color = Color.Green;
            }
            else if(total > 30 && total < 60)
            {
                ch_barras.Series["BARRAS"].Points[0].Color  = Color.Orange;
            }
             else
            {
                ch_barras.Series["BARRAS"].Points[0].Color = Color.Red;
            }


        }

        public void GRAFICO_COLUMNAS()
        {
            int actividad_economica = txt_actividad_economica.Text.Length == 0 ? 0 : Convert.ToInt32(txt_actividad_economica.Text);
            int nacionalidad = txt_nacionalidad.Text.Length == 0 ? 0 : Convert.ToInt32(txt_nacionalidad.Text);
            int pais = txt_pais.Text.Length == 0 ? 0 : Convert.ToInt32(txt_pais.Text);
            int provincia = txt_provincia.Text.Length == 0 ? 0 : Convert.ToInt32(txt_provincia.Text);
            int cantidad_efectivo = txt_cantidad_efectivo.Text.Length == 0 ? 0 : Convert.ToInt32(txt_cantidad_efectivo.Text);
            int productos = txt_producto.Text.Length == 0 ? 0 : Convert.ToInt32(txt_producto.Text);
            int canales = txt_canales.Text.Length == 0 ? 0 : Convert.ToInt32(txt_canales.Text);

            ch_columnas.Series["BARRAS"].Points.Clear();

            //Actividad Economica
            ch_columnas.Series["BARRAS"].Points.Add(actividad_economica);
            ch_columnas.Series["BARRAS"].Points[0].AxisLabel = "Actividad Economíca";
            ch_columnas.Series["BARRAS"].Points[0].Label = actividad_economica.ToString() + " %";
            ch_columnas.Series["BARRAS"].Points[0].LabelForeColor = Color.Black;
            if (actividad_economica <= 30)
            {
                ch_columnas.Series["BARRAS"].Points[0].Color = Color.Green;
            }
            else if (actividad_economica > 30 && actividad_economica < 60)
            {
                ch_columnas.Series["BARRAS"].Points[0].Color = Color.Orange;
            }
            else
            {
                ch_columnas.Series["BARRAS"].Points[0].Color = Color.Red;
            }
            //nacionalidad
            ch_columnas.Series["BARRAS"].Points.Add(nacionalidad);
            ch_columnas.Series["BARRAS"].Points[1].AxisLabel = "Nacionalidad";
            ch_columnas.Series["BARRAS"].Points[1].Label = nacionalidad.ToString() + " %";
            ch_columnas.Series["BARRAS"].Points[1].LabelForeColor = Color.Black;
            if (nacionalidad <= 30)
            {
                ch_columnas.Series["BARRAS"].Points[1].Color = Color.Green;
            }
            else if (nacionalidad > 30 && nacionalidad < 60)
            {
                ch_columnas.Series["BARRAS"].Points[1].Color = Color.Orange;
            }
            else
            {
                ch_columnas.Series["BARRAS"].Points[1].Color = Color.Red;
            }

            //pais
            ch_columnas.Series["BARRAS"].Points.Add(pais);
            ch_columnas.Series["BARRAS"].Points[2].AxisLabel = "Pais";
            ch_columnas.Series["BARRAS"].Points[2].Label = pais.ToString() + " %";
            ch_columnas.Series["BARRAS"].Points[2].LabelForeColor = Color.Black;
            if (pais <= 30)
            {
                ch_columnas.Series["BARRAS"].Points[2].Color = Color.Green;
            }
            else if (pais > 30 && pais < 60)
            {
                ch_columnas.Series["BARRAS"].Points[2].Color = Color.Orange;
            }
            else
            {
                ch_columnas.Series["BARRAS"].Points[2].Color = Color.Red;
            }

            //provincia
            ch_columnas.Series["BARRAS"].Points.Add(provincia);
            ch_columnas.Series["BARRAS"].Points[3].AxisLabel = "Provincia";
            ch_columnas.Series["BARRAS"].Points[3].Label = provincia.ToString() + " %";
            ch_columnas.Series["BARRAS"].Points[3].LabelForeColor = Color.Black;
            if (provincia <= 30)
            {
                ch_columnas.Series["BARRAS"].Points[3].Color = Color.Green;
            }
            else if (provincia > 30 && provincia < 60)
            {
                ch_columnas.Series["BARRAS"].Points[3].Color = Color.Orange;
            }
            else
            {
                ch_columnas.Series["BARRAS"].Points[3].Color = Color.Red;
            }

            //cantidad efectivo
            ch_columnas.Series["BARRAS"].Points.Add(cantidad_efectivo);
            ch_columnas.Series["BARRAS"].Points[4].AxisLabel = "Cantidad Efectivo";
            ch_columnas.Series["BARRAS"].Points[4].Label = cantidad_efectivo.ToString() + " %";
            ch_columnas.Series["BARRAS"].Points[4].LabelForeColor = Color.Black;
            if (cantidad_efectivo <= 30)
            {
                ch_columnas.Series["BARRAS"].Points[4].Color = Color.Green;
            }
            else if (cantidad_efectivo > 30 && cantidad_efectivo < 60)
            {
                ch_columnas.Series["BARRAS"].Points[4].Color = Color.Orange;
            }
            else
            {
                ch_columnas.Series["BARRAS"].Points[4].Color = Color.Red;
            }

            //productos
            ch_columnas.Series["BARRAS"].Points.Add(productos);
            ch_columnas.Series["BARRAS"].Points[5].AxisLabel = "Productos";
            ch_columnas.Series["BARRAS"].Points[5].Label = productos.ToString() + " %";
            ch_columnas.Series["BARRAS"].Points[5].LabelForeColor = Color.Black;
            if (productos <= 30)
            {
                ch_columnas.Series["BARRAS"].Points[5].Color = Color.Green;
            }
            else if (productos > 30 && productos < 60)
            {
                ch_columnas.Series["BARRAS"].Points[5].Color = Color.Orange;
            }
            else
            {
                ch_columnas.Series["BARRAS"].Points[5].Color = Color.Red;
            }

            //canales
            ch_columnas.Series["BARRAS"].Points.Add(canales);
            ch_columnas.Series["BARRAS"].Points[6].AxisLabel = "Canales";
            ch_columnas.Series["BARRAS"].Points[6].Label = canales.ToString() + " %";
            ch_columnas.Series["BARRAS"].Points[6].LabelForeColor = Color.Black;
            if (canales <= 30)
            {
                ch_columnas.Series["BARRAS"].Points[6].Color = Color.Green;
            }
            else if (canales > 30 && canales < 60)
            {
                ch_columnas.Series["BARRAS"].Points[6].Color = Color.Orange;
            }
            else
            {
                ch_columnas.Series["BARRAS"].Points[6].Color = Color.Red;
            }
        }

        private void txt_actividad_economica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                GRAFICO_COLUMNAS();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
