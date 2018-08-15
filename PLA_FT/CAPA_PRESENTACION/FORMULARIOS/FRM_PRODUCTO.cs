using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_PRODUCTO : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        CE_PRODUCTO CE = new CE_PRODUCTO();
        CN_PRODUCTO CN = new CN_PRODUCTO();

        public FRM_PRODUCTO()
        {
            InitializeComponent();
        }

        public void RECIBIR_DATOS(CE_PRODUCTO CE)
        {
            txt_descripcion.Text = CE.DESCRIPCION;
            txt_valoracion.Text = CE.VALORACION.ToString();
            txt_id.Text = CE.ID_PRODUCTO.ToString();
            cb_nivel_riesgo.Text = CE.NIVEL_RIESGO;
            cb_estado.Text = CE.ESTADO;
        }

        public void INSERTAR_ACTUALIZAR()
        {
            string MENSAJE = "";
            CE.DESCRIPCION = txt_descripcion.Text.Trim();
            CE.VALORACION = txt_valoracion.Text.Length == 0 ? 0 : Convert.ToDouble(txt_valoracion.Text);
            CE.ESTADO = cb_estado.Text;
            CE.NIVEL_RIESGO = cb_nivel_riesgo.Text;
            try
            {
                if (txt_id.Text.Equals(""))
                {
                    CN_PRODUCTO.INSERTAR(CE);
                    MENSAJE = "Datos Insertados Correctamente";
                }
                else
                {
                    CE.ID_PRODUCTO = Convert.ToInt32(txt_id.Text);
                    CN_PRODUCTO.ACTUALIZAR(CE);
                    MENSAJE = "Datos Actualizados Correctamente";
                }

                CP_UTILIDADES.MENSAJE_INFORMACION(MENSAJE, this);

                FRM_MANT_PRODUCTOS FRM = new FRM_MANT_PRODUCTOS();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FRM_MANT_PRODUCTOS")
                    {
                        FRM = (FRM_MANT_PRODUCTOS)frm;
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

        private void FRM_PRODUCTO_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Producto";
                cb_estado.Text = "ACTIVO";
                cb_estado.Enabled = false;
            }
            else
            {
                this.Text = "Editar Producto";
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_descripcion.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Descripción es Obligatoria", this);
                txt_descripcion.Focus();
                return;
            }
            if (cb_nivel_riesgo.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Nivel de Riesgo es Obligatorio", this);
                cb_nivel_riesgo.Focus();
                return;
            }

            if (cb_estado.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Estado es Obligatorio", this);
                cb_estado.Focus();
                return;
            }

            INSERTAR_ACTUALIZAR();
        }

        private void txt_valoracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            CP_UTILIDADES.PERMITIR_NUMERO_Y_PUNTO(sender, e, txt_valoracion);
        }
    }
}
