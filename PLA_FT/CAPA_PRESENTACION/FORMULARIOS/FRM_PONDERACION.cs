using System;
using System.Windows.Forms;
using CAPA_NEGOCIOS;
using CAPA_ENTIDAD;
namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_PONDERACION : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        decimal total = 0;

        public FRM_PONDERACION()
        {
            InitializeComponent();
        }

        public void Permiso_Acceso_Panatallas()
        {
            String condicion = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Configuraciones - Ponderaciones'";
            var Actividad_Economica = CN_PERMISO.CONSULTAR_PERMISO(condicion);
            btn_agregar.Enabled = Convert.ToBoolean(Actividad_Economica.Rows[0]["AGREGAR"].ToString()) == true ? true : false;
        }

        public void CONSULTAR()
        {
            txt_actividad.Text = CN_PONDERACION.CONSULTAR(1).Rows[0]["DESCRIPCION"].ToString();
            txt_porc_actividad.Text = CN_PONDERACION.CONSULTAR(1).Rows[0]["PORCIENTO"].ToString();

            txt_producto.Text = CN_PONDERACION.CONSULTAR(2).Rows[0]["DESCRIPCION"].ToString();
            txt_porc_producto.Text = CN_PONDERACION.CONSULTAR(2).Rows[0]["PORCIENTO"].ToString();

            txt_canal.Text = CN_PONDERACION.CONSULTAR(3).Rows[0]["DESCRIPCION"].ToString();
            txt_porc_canal.Text = CN_PONDERACION.CONSULTAR(3).Rows[0]["PORCIENTO"].ToString();

            txt_cantidad.Text = CN_PONDERACION.CONSULTAR(4).Rows[0]["DESCRIPCION"].ToString();
            txt_porc_cantidad.Text = CN_PONDERACION.CONSULTAR(4).Rows[0]["PORCIENTO"].ToString();

            txt_nacionalidad.Text = CN_PONDERACION.CONSULTAR(5).Rows[0]["DESCRIPCION"].ToString();
            txt_porc_nacionalidad.Text = CN_PONDERACION.CONSULTAR(5).Rows[0]["PORCIENTO"].ToString();

            txt_pais.Text = CN_PONDERACION.CONSULTAR(6).Rows[0]["DESCRIPCION"].ToString();
            txt_porc_pais.Text = CN_PONDERACION.CONSULTAR(6).Rows[0]["PORCIENTO"].ToString();

            txt_provincia.Text = CN_PONDERACION.CONSULTAR(7).Rows[0]["DESCRIPCION"].ToString();
            txt_porc_provincia.Text = CN_PONDERACION.CONSULTAR(7).Rows[0]["PORCIENTO"].ToString();

            SUMAR_PORCIENTO();
        }

        public void SUMAR_PORCIENTO()
        {
            decimal actividad = txt_porc_actividad.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_actividad.Text);
            decimal producto = txt_porc_producto.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_producto.Text);
            decimal canal = txt_porc_canal.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_canal.Text);
            decimal cantidad = txt_porc_cantidad.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_cantidad.Text);
            decimal nacionalidad = txt_porc_nacionalidad.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_nacionalidad.Text);
            decimal pais = txt_porc_pais.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_pais.Text);
            decimal provincia = txt_porc_provincia.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_provincia.Text);
            total = actividad + producto + canal + cantidad + nacionalidad + pais + provincia;
            lbl_total.Text = total.ToString()+" %";
        }

        public void ACTUALIZAR()
        {
            try
            {
                CE_PONDERACION CE_1 = new CE_PONDERACION();
                CE_1.PORCIENTO = txt_porc_actividad.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_actividad.Text);
                CE_1.ID_PONDERACION = 1;
                CN_PONDERACION.ACTUALIZAR(CE_1);

                CE_PONDERACION CE_2 = new CE_PONDERACION();
                CE_2.PORCIENTO = txt_porc_producto.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_producto.Text);
                CE_2.ID_PONDERACION = 2;
                CN_PONDERACION.ACTUALIZAR(CE_2);

                CE_PONDERACION CE_3 = new CE_PONDERACION();
                CE_3.PORCIENTO = txt_porc_canal.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_canal.Text);
                CE_3.ID_PONDERACION = 3;
                CN_PONDERACION.ACTUALIZAR(CE_3);

                CE_PONDERACION CE_4 = new CE_PONDERACION();
                CE_4.PORCIENTO = txt_porc_cantidad.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_cantidad.Text);
                CE_4.ID_PONDERACION = 4;
                CN_PONDERACION.ACTUALIZAR(CE_4);

                CE_PONDERACION CE_5 = new CE_PONDERACION();
                CE_5.PORCIENTO = txt_porc_nacionalidad.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_nacionalidad.Text);
                CE_5.ID_PONDERACION = 5;
                CN_PONDERACION.ACTUALIZAR(CE_5);

                CE_PONDERACION CE_6 = new CE_PONDERACION();
                CE_6.PORCIENTO = txt_porc_pais.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_pais.Text);
                CE_6.ID_PONDERACION = 6;
                CN_PONDERACION.ACTUALIZAR(CE_6);

                CE_PONDERACION CE_7 = new CE_PONDERACION();
                CE_7.PORCIENTO = txt_porc_provincia.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_porc_provincia.Text);
                CE_7.ID_PONDERACION = 7;
                CN_PONDERACION.ACTUALIZAR(CE_7);

                CP_UTILIDADES.MENSAJE_INFORMACION("Datos Actualizados Conrrectamente", this);
            }
            catch (Exception ex)
            {
                CP_UTILIDADES.MENSAJE_ERROR(ex.Message,this);
            }          
        }

        private void FRM_PONDERACION_Load(object sender, EventArgs e)
        {
            CONSULTAR();
            Permiso_Acceso_Panatallas();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            SUMAR_PORCIENTO();

            if(total != 100)
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Porciento Total debe ser Igual a 100 %",this);
                return;
            }
            ACTUALIZAR();
            Close();
        }

        private void txt_porc_actividad_KeyPress(object sender, KeyPressEventArgs e)
        {
            CP_UTILIDADES.PERMITIR_NUMERO_Y_PUNTO(sender,e,txt_porc_actividad);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SUMAR_PORCIENTO();
            }
        }

        private void txt_porc_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            CP_UTILIDADES.PERMITIR_NUMERO_Y_PUNTO(sender, e, txt_porc_producto);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SUMAR_PORCIENTO();
            }
        }

        private void txt_porc_canal_KeyPress(object sender, KeyPressEventArgs e)
        {
            CP_UTILIDADES.PERMITIR_NUMERO_Y_PUNTO(sender, e, txt_porc_canal);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SUMAR_PORCIENTO();
            }
        }

        private void txt_porc_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            CP_UTILIDADES.PERMITIR_NUMERO_Y_PUNTO(sender, e, txt_porc_cantidad);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SUMAR_PORCIENTO();
            }
        }

        private void txt_porc_nacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            CP_UTILIDADES.PERMITIR_NUMERO_Y_PUNTO(sender, e, txt_porc_nacionalidad);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SUMAR_PORCIENTO();
            }
        }

        private void txt_porc_pais_KeyPress(object sender, KeyPressEventArgs e)
        {
            CP_UTILIDADES.PERMITIR_NUMERO_Y_PUNTO(sender, e, txt_porc_pais);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SUMAR_PORCIENTO();
            }
        }

        private void txt_porc_provincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            CP_UTILIDADES.PERMITIR_NUMERO_Y_PUNTO(sender, e, txt_porc_provincia);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SUMAR_PORCIENTO();
            }
        }
    }
}
