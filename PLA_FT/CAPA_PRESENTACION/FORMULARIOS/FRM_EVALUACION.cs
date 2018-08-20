using CAPA_NEGOCIOS;
using CAPA_ENTIDAD;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_productos, "SP_LLENAR_COMBOBOX", "PRODUCTOS", "DESCRIPCION", "ID_PRODUCTO", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_canales, "SP_LLENAR_COMBOBOX", "CANALES", "DESCRIPCION", "ID_CANAL", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
        }

        public void RECIBIR_DATOS(CE_EVALUACION CE)
        {
            txt_actividad_economica.Text = CE.VALOR_ACTIVIDAD.ToString();
            txt_canales.Text = CE.VALOR_CANAL.ToString();
            txt_cantidad_efectivo.Text = CE.VALOR_CANTIDAD.ToString();
            txt_id.Text = CE.ID_EVALUACION.ToString();
            txt_id_cliente.Text = CE.ID_CLIENTE.ToString();
            txt_nacionalidad.Text = CE.VALOR_NACIONALIDAD.ToString();
            txt_pais.Text = CE.VALOR_PAIS.ToString();
            txt_producto.Text = CE.VALOR_PRODUCTO.ToString();
            txt_provincia.Text = CE.VALOR_PROVINCIA.ToString();
            txt_total.Text = CE.VALOR_TOTAL.ToString();

            cb_actividad_economica.SelectedValue = CE.ID_ACTIVIDAD;
            cb_cantidades_efectivo.SelectedValue = CE.ID_CANTIDAD;
            cb_nacionalidades.SelectedValue = CE.ID_NACIONALIDAD;
            cb_paises.SelectedValue = CE.ID_PAIS;
            cb_provincias.SelectedValue = CE.ID_PROVINCIA;

            txt_nombre.Text = CN_CLIENTE.CONSULTAR("A.ID_CLIENTE=" + CE.ID_CLIENTE + "").Rows[0]["NOMBRE"].ToString();
            txt_identificacion.Text = CN_CLIENTE.CONSULTAR("A.ID_CLIENTE=" + CE.ID_CLIENTE + "").Rows[0]["IDENTIFICACION"].ToString();
            cb_tipo.Text = CN_CLIENTE.CONSULTAR("A.ID_CLIENTE=" + CE.ID_CLIENTE + "").Rows[0]["TIPO"].ToString();
            cb_oficina.Text = CN_CLIENTE.CONSULTAR("A.ID_CLIENTE=" + CE.ID_CLIENTE + "").Rows[0]["OFICINA"].ToString();

            txt_recomendacion.Text = CN_RECOMENDACION.CONSULTAR("ID_RECOMENDACION=" + CE.ID_RECOMENDACION + "").Rows[0]["DESCRIPCION"].ToString();

            int i;
            for (i = 0; (i
                        <= (CN_PRODUCTOS_EVALUACION.CONSULTAR("A.ID_EVALUACION=" + CE.ID_EVALUACION + "")).Rows.Count - 1); i++)
            {
                DG_PRODUCTOS.Rows.Add();
                DG_PRODUCTOS.Rows[i].Cells[0].Value = CN_PRODUCTOS_EVALUACION.CONSULTAR("A.ID_EVALUACION=" + CE.ID_EVALUACION + "").Rows[i]["ID_PRODUCTO"];
                DG_PRODUCTOS.Rows[i].Cells[1].Value = CN_PRODUCTOS_EVALUACION.CONSULTAR("A.ID_EVALUACION=" + CE.ID_EVALUACION + "").Rows[i]["DESCRIPCION"];
                DG_PRODUCTOS.Rows[i].Cells[2].Value = CN_PRODUCTOS_EVALUACION.CONSULTAR("A.ID_EVALUACION=" + CE.ID_EVALUACION + "").Rows[i]["VALORACION"];
                DG_PRODUCTOS.Rows[i].Cells[3].Value = CN_PRODUCTOS_EVALUACION.CONSULTAR("A.ID_EVALUACION=" + CE.ID_EVALUACION + "").Rows[i]["NIVEL_RIESGO"];
                DG_PRODUCTOS.Rows[i].Cells[4].Value = CN_PRODUCTOS_EVALUACION.CONSULTAR("A.ID_EVALUACION=" + CE.ID_EVALUACION + "").Rows[i]["ESTADO"];
            }

            DG_PRODUCTOS.DataSource = null;


            int e;
            for (e = 0; (e
                        <= (CN_CANALES_EVALUACION.CONSULTAR("A.ID_EVALUACION=" + CE.ID_EVALUACION + "")).Rows.Count - 1); e++)
            {
                DG_CANALES.Rows.Add();
                DG_CANALES.Rows[e].Cells[0].Value = CN_CANALES_EVALUACION.CONSULTAR("A.ID_EVALUACION=" + CE.ID_EVALUACION + "").Rows[e]["ID_CANAL"];
                DG_CANALES.Rows[e].Cells[1].Value = CN_CANALES_EVALUACION.CONSULTAR("A.ID_EVALUACION=" + CE.ID_EVALUACION + "").Rows[e]["DESCRIPCION"];
                DG_CANALES.Rows[e].Cells[2].Value = CN_CANALES_EVALUACION.CONSULTAR("A.ID_EVALUACION=" + CE.ID_EVALUACION + "").Rows[e]["VALORACION"];
                DG_CANALES.Rows[e].Cells[3].Value = CN_CANALES_EVALUACION.CONSULTAR("A.ID_EVALUACION=" + CE.ID_EVALUACION + "").Rows[e]["NIVEL_RIESGO"];
                DG_CANALES.Rows[e].Cells[4].Value = CN_CANALES_EVALUACION.CONSULTAR("A.ID_EVALUACION=" + CE.ID_EVALUACION + "").Rows[e]["ESTADO"];
            }

            DG_CANALES.DataSource = null;
            CALCULOS();
            GRAFICO_BARRA();
            GRAFICO_COLUMNAS();
        }

        public void CALCULOS()
        {
            decimal pond_actividad = Convert.ToDecimal(CN_PONDERACION.CONSULTAR(1).Rows[0]["PORCIENTO"].ToString());
            decimal pond_cantidad = Convert.ToDecimal(CN_PONDERACION.CONSULTAR(4).Rows[0]["PORCIENTO"].ToString());
            decimal pond_nacionalidad = Convert.ToDecimal(CN_PONDERACION.CONSULTAR(5).Rows[0]["PORCIENTO"].ToString());
            decimal pond_pais = Convert.ToDecimal(CN_PONDERACION.CONSULTAR(6).Rows[0]["PORCIENTO"].ToString());
            decimal pond_provincia = Convert.ToDecimal(CN_PONDERACION.CONSULTAR(7).Rows[0]["PORCIENTO"].ToString());
            decimal pond_producto = Convert.ToDecimal(CN_PONDERACION.CONSULTAR(2).Rows[0]["PORCIENTO"].ToString());
            decimal pond_canal = Convert.ToDecimal(CN_PONDERACION.CONSULTAR(3).Rows[0]["PORCIENTO"].ToString());
            //suma de la columna de valoracion / cantidad de filas
            decimal valoracion_producto = 0;
            decimal valoracion_canal = 0;

            if(DG_PRODUCTOS.Rows.Count>0)
            {
                valoracion_producto = Convert.ToDecimal(DG_PRODUCTOS.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["VALORACION"].Value.ToString()))) / Convert.ToDecimal(DG_PRODUCTOS.Rows.Cast<DataGridViewRow>().Count());
            }
            if(DG_CANALES.Rows.Count>0)
            {
                valoracion_canal = Convert.ToDecimal(DG_CANALES.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["VALORACION1"].Value.ToString()))) / Convert.ToDecimal(DG_CANALES.Rows.Cast<DataGridViewRow>().Count()); 
            }
           
           
            decimal actividad = ((cb_actividad_economica.Text ==""? 0 : Convert.ToDecimal(CN_ACTIVIDAD_ECONOMICA.CONSULTAR("ID_ACTIVIDAD="+ cb_actividad_economica.SelectedValue +"").Rows[0]["VALORACION"].ToString()) * pond_actividad) * 10/100);
            decimal cantidad = ((cb_cantidades_efectivo.Text ==""? 0 : Convert.ToDecimal(CN_CANTIDAD_EFECTIVO.CONSULTAR("ID_CANTIDAD="+ cb_cantidades_efectivo.SelectedValue +"").Rows[0]["VALORACION"].ToString()) * pond_cantidad ) * 10/100);
            decimal nacionalidad = ((cb_nacionalidades.Text == "" ? 0 : Convert.ToDecimal(CN_PAIS.CONSULTAR("ID_PAIS=" + cb_nacionalidades.SelectedValue + "").Rows[0]["VALORACION"].ToString()) * pond_nacionalidad ) * 10/100);
            decimal pais = ((cb_paises.Text == "" ? 0 : Convert.ToDecimal(CN_PAIS.CONSULTAR("ID_PAIS=" + cb_paises.SelectedValue + "").Rows[0]["VALORACION"].ToString()) * pond_pais ) * 10/100);
            decimal provincia = ((cb_provincias.Text == "" ? 0 : Convert.ToDecimal(CN_PROVINCIA.CONSULTAR("ID_PROVINCIA=" + cb_provincias.SelectedValue + "").Rows[0]["VALORACION"].ToString()) * pond_provincia ) * 10/100);
            decimal producto = ((valoracion_producto * pond_producto) * 10/100);
            decimal canal = ((valoracion_canal * pond_canal) * 10 / 100);          
            decimal total = (actividad + cantidad + nacionalidad + pais + provincia + producto + canal );

            txt_actividad_economica.Text = actividad.ToString("n2");
            txt_cantidad_efectivo.Text = cantidad.ToString("n2");
            txt_nacionalidad.Text = nacionalidad.ToString("n2");
            txt_pais.Text = pais.ToString("n2");
            txt_provincia.Text = provincia.ToString("n2");
            txt_producto.Text = producto.ToString("n2");
            txt_canales.Text = canal.ToString("n2");
            txt_total.Text = total.ToString("n2");

            GRAFICO_BARRA();
            GRAFICO_COLUMNAS();
        }

        private void FRM_EVALUACION_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Evaluación";
            }
            else
            {
                this.Text = "Editar Evaluación";
            }
            metroTabControl1.SelectedIndex = 0;
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
            if (CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows.Count > 0)
            {
                txt_nombre.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["NOMBRE"].ToString();
                txt_identificacion.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["IDENTIFICACION"].ToString();
                cb_oficina.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["OFICINA"].ToString();
                cb_tipo.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["TIPO"].ToString();
            }
            else
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("Este Cliente No Existe", this);
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
            double total = txt_total.Text.Length == 0 ? 0 : Convert.ToDouble(txt_total.Text);

            ch_barras.Series["BARRAS"].Points.Clear();
            ch_barras.Series["BARRAS"].Points.Add(total);

            ch_barras.Series["BARRAS"].Points[0].AxisLabel = " ";
            ch_barras.Series["BARRAS"].Points[0].Label = total.ToString() + " %";
            ch_barras.Series["BARRAS"].Points[0].LabelForeColor = Color.Black;
            if (total <= 30)
            {
                ch_barras.Series["BARRAS"].Points[0].Color = Color.Green;
            }
            else if (total > 30 && total < 60)
            {
                ch_barras.Series["BARRAS"].Points[0].Color = Color.Orange;
            }
            else
            {
                ch_barras.Series["BARRAS"].Points[0].Color = Color.Red;
            }


        }

        public void GRAFICO_COLUMNAS()
        {
            try
            {
                double actividad_economica = txt_actividad_economica.Text.Length == 0 ? 0 : Convert.ToDouble(txt_actividad_economica.Text);
                double nacionalidad = txt_nacionalidad.Text.Length == 0 ? 0 : Convert.ToDouble(txt_nacionalidad.Text);
                double pais = txt_pais.Text.Length == 0 ? 0 : Convert.ToDouble(txt_pais.Text);
                double provincia = txt_provincia.Text.Length == 0 ? 0 : Convert.ToDouble(txt_provincia.Text);
                double cantidad_efectivo = txt_cantidad_efectivo.Text.Length == 0 ? 0 : Convert.ToDouble(txt_cantidad_efectivo.Text);
                double productos = txt_producto.Text.Length == 0 ? 0 : Convert.ToDouble(txt_producto.Text);
                double canales = txt_canales.Text.Length == 0 ? 0 : Convert.ToDouble(txt_canales.Text);

                ch_columnas.Series["BARRAS"].Points.Clear();

                //Actividad Economica
                ch_columnas.Series["BARRAS"].Points.Add(actividad_economica);
                ch_columnas.Series["BARRAS"].Points[0].AxisLabel = "Actividad Economíca";
                ch_columnas.Series["BARRAS"].Points[0].Label = actividad_economica.ToString() + " %";
                ch_columnas.Series["BARRAS"].Points[0].LabelForeColor = Color.Black;

                if (CN_ACTIVIDAD_ECONOMICA.CONSULTAR("ID_ACTIVIDAD=" + cb_actividad_economica.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "ALTO")
                {
                    ch_columnas.Series["BARRAS"].Points[0].Color = Color.Red;
                }
                if (CN_ACTIVIDAD_ECONOMICA.CONSULTAR("ID_ACTIVIDAD=" + cb_actividad_economica.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "MEDIO")
                {
                    ch_columnas.Series["BARRAS"].Points[0].Color = Color.Orange;
                }
                if (CN_ACTIVIDAD_ECONOMICA.CONSULTAR("ID_ACTIVIDAD=" + cb_actividad_economica.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "BAJO")
                {
                    ch_columnas.Series["BARRAS"].Points[0].Color = Color.Green;
                }

                //nacionalidad
                ch_columnas.Series["BARRAS"].Points.Add(nacionalidad);
                ch_columnas.Series["BARRAS"].Points[1].AxisLabel = "Nacionalidad";
                ch_columnas.Series["BARRAS"].Points[1].Label = nacionalidad.ToString() + " %";
                ch_columnas.Series["BARRAS"].Points[1].LabelForeColor = Color.Black;

                if (CN_PAIS.CONSULTAR("ID_PAIS=" + cb_nacionalidades.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "ALTO")
                {
                    ch_columnas.Series["BARRAS"].Points[1].Color = Color.Red;
                }
                if (CN_PAIS.CONSULTAR("ID_PAIS=" + cb_nacionalidades.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "MEDIO")
                {
                    ch_columnas.Series["BARRAS"].Points[1].Color = Color.Orange;
                }
                if (CN_PAIS.CONSULTAR("ID_PAIS=" + cb_nacionalidades.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "BAJO")
                {
                    ch_columnas.Series["BARRAS"].Points[1].Color = Color.Green;
                }

                //pais
                ch_columnas.Series["BARRAS"].Points.Add(pais);
                ch_columnas.Series["BARRAS"].Points[2].AxisLabel = "Pais";
                ch_columnas.Series["BARRAS"].Points[2].Label = pais.ToString() + " %";
                ch_columnas.Series["BARRAS"].Points[2].LabelForeColor = Color.Black;

                if (CN_PAIS.CONSULTAR("ID_PAIS=" + cb_paises.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "ALTO")
                {
                    ch_columnas.Series["BARRAS"].Points[2].Color = Color.Red;
                }
                if (CN_PAIS.CONSULTAR("ID_PAIS=" + cb_paises.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "MEDIO")
                {
                    ch_columnas.Series["BARRAS"].Points[2].Color = Color.Orange;
                }
                if (CN_PAIS.CONSULTAR("ID_PAIS=" + cb_paises.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "BAJO")
                {
                    ch_columnas.Series["BARRAS"].Points[2].Color = Color.Green;
                }

                //provincia
                ch_columnas.Series["BARRAS"].Points.Add(provincia);
                ch_columnas.Series["BARRAS"].Points[3].AxisLabel = "Provincia";
                ch_columnas.Series["BARRAS"].Points[3].Label = provincia.ToString() + " %";
                ch_columnas.Series["BARRAS"].Points[3].LabelForeColor = Color.Black;

                if (CN_PROVINCIA.CONSULTAR("ID_PROVINCIA=" + cb_provincias.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "ALTO")
                {
                    ch_columnas.Series["BARRAS"].Points[3].Color = Color.Red;
                }
                if (CN_PROVINCIA.CONSULTAR("ID_PROVINCIA=" + cb_provincias.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "MEDIO")
                {
                    ch_columnas.Series["BARRAS"].Points[3].Color = Color.Orange;
                }
                if (CN_PROVINCIA.CONSULTAR("ID_PROVINCIA=" + cb_provincias.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "BAJO")
                {
                    ch_columnas.Series["BARRAS"].Points[3].Color = Color.Green;
                }

                //cantidad efectivo
                ch_columnas.Series["BARRAS"].Points.Add(cantidad_efectivo);
                ch_columnas.Series["BARRAS"].Points[4].AxisLabel = "Cantidad Efectivo";
                ch_columnas.Series["BARRAS"].Points[4].Label = cantidad_efectivo.ToString() + " %";
                ch_columnas.Series["BARRAS"].Points[4].LabelForeColor = Color.Black;

                if (CN_CANTIDAD_EFECTIVO.CONSULTAR("ID_CANTIDAD=" + cb_cantidades_efectivo.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "ALTO")
                {
                    ch_columnas.Series["BARRAS"].Points[4].Color = Color.Red;
                }
                if (CN_CANTIDAD_EFECTIVO.CONSULTAR("ID_CANTIDAD=" + cb_cantidades_efectivo.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "MEDIO")
                {
                    ch_columnas.Series["BARRAS"].Points[4].Color = Color.Orange;
                }
                if (CN_CANTIDAD_EFECTIVO.CONSULTAR("ID_CANTIDAD=" + cb_cantidades_efectivo.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString() == "BAJO")
                {
                    ch_columnas.Series["BARRAS"].Points[4].Color = Color.Green;
                }


                //productos
                ch_columnas.Series["BARRAS"].Points.Add(productos);
                ch_columnas.Series["BARRAS"].Points[5].AxisLabel = "Productos";
                ch_columnas.Series["BARRAS"].Points[5].Label = productos.ToString() + " %";
                ch_columnas.Series["BARRAS"].Points[5].LabelForeColor = Color.Black;

                if (productos <= 6)
                {
                    ch_columnas.Series["BARRAS"].Points[5].Color = Color.Green;
                }
                else if (productos > 6 && productos < 12)
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

                if (canales <= 8)
                {
                    ch_columnas.Series["BARRAS"].Points[6].Color = Color.Green;
                }
                else if (canales > 8 && canales <= 12)
                {
                    ch_columnas.Series["BARRAS"].Points[6].Color = Color.Orange;
                }
                else
                {
                    ch_columnas.Series["BARRAS"].Points[6].Color = Color.Red;
                }
            }
            catch
            {

            }          
        }

        private void txt_actividad_economica_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        public void INSERTAR_ACTUALIZAR()
        {
            try
            {
                string MENSAJE = "";
                CE_EVALUACION CE = new CE_EVALUACION();
                CE.FECHA = DateTime.Now;
                CE.ID_ACTIVIDAD = Convert.ToInt32(cb_actividad_economica.SelectedValue);
                CE.ID_CANTIDAD = Convert.ToInt32(cb_cantidades_efectivo.SelectedValue);
                CE.ID_CLIENTE = Convert.ToInt32(txt_id_cliente.Text);
                CE.ID_NACIONALIDAD = Convert.ToInt32(cb_nacionalidades.SelectedValue);
                CE.ID_PAIS = Convert.ToInt32(cb_paises.SelectedValue);
                CE.ID_PROVINCIA = Convert.ToInt32(cb_provincias.SelectedValue);
                CE.VALOR_ACTIVIDAD = txt_actividad_economica.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_actividad_economica.Text);
                CE.VALOR_CANAL = txt_canales.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_canales.Text);
                CE.VALOR_CANTIDAD = txt_cantidad_efectivo.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_cantidad_efectivo.Text);
                CE.VALOR_NACIONALIDAD = txt_nacionalidad.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_nacionalidad.Text);
                CE.VALOR_PAIS = txt_pais.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_pais.Text);
                CE.VALOR_PRODUCTO = txt_producto.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_producto.Text);
                CE.VALOR_PROVINCIA = txt_provincia.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_provincia.Text);
                CE.VALOR_TOTAL = txt_total.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_total.Text);
                CE.USUARIO = CP_UTILIDADES.DATOS_USUARIO.USUARIO;

                if (CE.VALOR_TOTAL <= 10)
                {
                    CE.ID_RECOMENDACION = Convert.ToInt32(CN_RECOMENDACION.CONSULTAR("CONDICION ='<=10'").Rows[0]["ID_RECOMENDACION"].ToString());
                }
                else if (CE.VALOR_TOTAL > 10 && CE.VALOR_TOTAL <= 20)
                {
                    CE.ID_RECOMENDACION = Convert.ToInt32(CN_RECOMENDACION.CONSULTAR("CONDICION ='>10 Y <=20'").Rows[0]["ID_RECOMENDACION"].ToString());
                }
                else if (CE.VALOR_TOTAL > 20 && CE.VALOR_TOTAL <= 30)
                {
                    CE.ID_RECOMENDACION = Convert.ToInt32(CN_RECOMENDACION.CONSULTAR("CONDICION ='> 20 Y <=30'").Rows[0]["ID_RECOMENDACION"].ToString());
                }
                else if (CE.VALOR_TOTAL > 30 && CE.VALOR_TOTAL <= 40)
                {
                    CE.ID_RECOMENDACION = Convert.ToInt32(CN_RECOMENDACION.CONSULTAR("CONDICION ='>30 Y <=40'").Rows[0]["ID_RECOMENDACION"].ToString());
                }
                else if (CE.VALOR_TOTAL > 40 && CE.VALOR_TOTAL <= 50)
                {
                    CE.ID_RECOMENDACION = Convert.ToInt32(CN_RECOMENDACION.CONSULTAR("CONDICION ='>40 Y <=50'").Rows[0]["ID_RECOMENDACION"].ToString());
                }
                else if (CE.VALOR_TOTAL > 50 && CE.VALOR_TOTAL <= 60)
                {
                    CE.ID_RECOMENDACION = Convert.ToInt32(CN_RECOMENDACION.CONSULTAR("CONDICION ='>50 Y <=60'").Rows[0]["ID_RECOMENDACION"].ToString());
                }
                else if (CE.VALOR_TOTAL > 60 && CE.VALOR_TOTAL <= 70)
                {
                    CE.ID_RECOMENDACION = Convert.ToInt32(CN_RECOMENDACION.CONSULTAR("CONDICION ='>60 Y <=70'").Rows[0]["ID_RECOMENDACION"].ToString());
                }
                else if (CE.VALOR_TOTAL > 70 && CE.VALOR_TOTAL <= 80)
                {
                    CE.ID_RECOMENDACION = Convert.ToInt32(CN_RECOMENDACION.CONSULTAR("CONDICION ='>70 Y <=80'").Rows[0]["ID_RECOMENDACION"].ToString());
                }
                else if (CE.VALOR_TOTAL > 80 && CE.VALOR_TOTAL <= 90)
                {
                    CE.ID_RECOMENDACION = Convert.ToInt32(CN_RECOMENDACION.CONSULTAR("CONDICION ='>80 Y <=90'").Rows[0]["ID_RECOMENDACION"].ToString());
                }
                else
                {
                    CE.ID_RECOMENDACION = Convert.ToInt32(CN_RECOMENDACION.CONSULTAR("CONDICION ='>90").Rows[0]["ID_RECOMENDACION"].ToString());
                }

                int ID_EVALUACION = 0;
                if (txt_id.Text == "")
                {
                    CN_EVALUACION.INSERTAR(CE);
                    ID_EVALUACION = Convert.ToInt32(CN_EVALUACION.CONSULTAR_MAX().Rows[0][0].ToString());
                    MENSAJE = "Datos Insertados Correctamente";
                }
                else
                {
                    ID_EVALUACION = Convert.ToInt32(txt_id.Text);
                    CE.ID_EVALUACION = ID_EVALUACION;
                    CN_EVALUACION.ACTUALIZAR(CE);
                    MENSAJE = "Datos Actualizados Correctamente";
                }

                if (DG_PRODUCTOS.Rows.Count > 0)
                {
                    CN_PRODUCTOS_EVALUACION.ELIMINAR(ID_EVALUACION);
                    foreach (DataGridViewRow FILA in DG_PRODUCTOS.Rows)
                    {
                        CE_PRODUCTO_EVALUACION CE_P = new CE_PRODUCTO_EVALUACION();
                        CE_P.ID_EVALUACION = ID_EVALUACION;
                        CE_P.ID_PRODUCTO = Convert.ToInt32(FILA.Cells[0].Value.ToString());
                        CN_PRODUCTOS_EVALUACION.INSERTAR(CE_P);
                    }
                }

                if (DG_CANALES.Rows.Count > 0)
                {
                    CN_CANALES_EVALUACION.ELIMINAR(ID_EVALUACION);
                    foreach (DataGridViewRow FILA in DG_CANALES.Rows)
                    {
                        CE_CANALES_EVALUACION CE_C = new CE_CANALES_EVALUACION();
                        CE_C.ID_EVALUACION = ID_EVALUACION;
                        CE_C.ID_CANAL = Convert.ToInt32(FILA.Cells[0].Value.ToString());
                        CN_CANALES_EVALUACION.INSERTAR(CE_C);
                    }
                }

                if (txt_observacion.Text.Trim().Length > 0)
                {
                    CE_OBSERVACION CE_O = new CE_OBSERVACION();
                    CE_O.DESCRIPCION = txt_observacion.Text.Trim();
                    CE_O.FECHA = DateTime.Now;
                    CE_O.ID_EVALUACION = ID_EVALUACION;
                    CE_O.USUARIO = CP_UTILIDADES.DATOS_USUARIO.USUARIO;
                    CN_OBSERVACION.INSERTAR(CE_O);
                }

                CP_UTILIDADES.MENSAJE_INFORMACION(MENSAJE, this);

                FRM_MANT_EVALUACIONES FRM = new FRM_MANT_EVALUACIONES();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FRM_MANT_EVALUACIONES")
                    {
                        FRM = (FRM_MANT_EVALUACIONES)frm;
                        FRM.CONSULTAR();
                        this.Close();
                        break;
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                CP_UTILIDADES.MENSAJE_ERROR(ex.Message, this);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            INSERTAR_ACTUALIZAR();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cb_productos.Text == "")
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("Se Debe Seleccionar El Producto", this);
                return;
            }
            foreach (DataGridViewRow item in DG_PRODUCTOS.Rows)
            {
                if (cb_productos.Text == item.Cells["DESCRIPCION"].Value.ToString())
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("Este Producto ya esta en la Lista", this);
                    cb_productos.Text = "";
                    return;
                }
            }

            int ID = Convert.ToInt32(CN_PRODUCTO.CONSULTAR("ID_PRODUCTO=" + cb_productos.SelectedValue + "").Rows[0]["ID_PRODUCTO"].ToString());
            string DESCRIPCION = CN_PRODUCTO.CONSULTAR("ID_PRODUCTO=" + cb_productos.SelectedValue + "").Rows[0]["DESCRIPCION"].ToString();
            decimal VALORACION = Convert.ToDecimal(CN_PRODUCTO.CONSULTAR("ID_PRODUCTO=" + cb_productos.SelectedValue + "").Rows[0]["VALORACION"].ToString());
            string NIVEL_RIESGO = CN_PRODUCTO.CONSULTAR("ID_PRODUCTO=" + cb_productos.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString();
            string ESTADO = CN_PRODUCTO.CONSULTAR("ID_PRODUCTO=" + cb_productos.SelectedValue + "").Rows[0]["ESTADO"].ToString();

            DG_PRODUCTOS.Rows.Add(ID, DESCRIPCION, VALORACION, NIVEL_RIESGO, ESTADO);
            CALCULOS();
            cb_productos.SelectedItem = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DG_PRODUCTOS.Rows.Count == 0)
            {
                return;
            }
            DG_PRODUCTOS.Rows.Remove(DG_PRODUCTOS.CurrentRow);
            CALCULOS();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cb_canales.Text == "")
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("Se Debe Seleccionar El Canal", this);
                return;
            }
            foreach (DataGridViewRow item in DG_CANALES.Rows)
            {
                if (cb_canales.Text == item.Cells["DESCRIP"].Value.ToString())
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("Este Canal ya esta en la Lista", this);
                    cb_canales.Text = "";
                    return;
                }
            }

            int ID = Convert.ToInt32(CN_CANAL.CONSULTAR("ID_CANAL=" + cb_canales.SelectedValue + "").Rows[0]["ID_CANAL"].ToString());
            string DESCRIPCION = CN_CANAL.CONSULTAR("ID_CANAL=" + cb_canales.SelectedValue + "").Rows[0]["DESCRIPCION"].ToString();
            decimal VALORACION = Convert.ToDecimal(CN_CANAL.CONSULTAR("ID_CANAL=" + cb_canales.SelectedValue + "").Rows[0]["VALORACION"].ToString());
            string NIVEL_RIESGO = CN_CANAL.CONSULTAR("ID_CANAL=" + cb_canales.SelectedValue + "").Rows[0]["NIVEL_RIESGO"].ToString();
            string ESTADO = CN_CANAL.CONSULTAR("ID_CANAL=" + cb_canales.SelectedValue + "").Rows[0]["ESTADO"].ToString();
            DG_CANALES.DataSource = null;

            DG_CANALES.Rows.Add(ID, DESCRIPCION, VALORACION, NIVEL_RIESGO, ESTADO);
            CALCULOS();
            cb_canales.SelectedItem = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DG_CANALES.Rows.Count == 0)
            {
                return;
            }
            
            DG_CANALES.Rows.Remove(DG_CANALES.CurrentRow);
            CALCULOS();
        }

        private void cb_actividad_economica_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CALCULOS();
            }
            catch
            {

            }
        }

        private void cb_nacionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CALCULOS();
            }
            catch
            {

            }
        }

        private void cb_paises_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CALCULOS();
            }
            catch
            {

            }
        }

        private void cb_provincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CALCULOS();
            }
            catch
            {

            }
        }

        private void cb_cantidades_efectivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CALCULOS();
            }
            catch
            {

            }
        }
    }
}
