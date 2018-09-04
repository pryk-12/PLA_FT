using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_OCUPACION : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        CE_OCUPACION CE = new CE_OCUPACION();
        CN_OCUPACION CN = new CN_OCUPACION();
        CN_UTILIDADES CNU = new CN_UTILIDADES();

        public FRM_OCUPACION()
        {
            InitializeComponent();
        }

        public void RECIBIR_DATOS(CE_OCUPACION CE)
        {
            txt_descripcion.Text = CE.DESCRIPCION;
            txt_id.Text = CE.ID_OCUPACION.ToString();
            cb_estado.Text = CE.ESTADO;
        }

        public void INSERTAR_ACTUALIZAR()
        {
            string MENSAJE = "";
            CE.DESCRIPCION = txt_descripcion.Text.Trim();
            CE.ESTADO = cb_estado.Text;
            try
            {
                if (txt_id.Text.Equals(""))
                {
                    CN_OCUPACION.INSERTAR(CE);
                    MENSAJE = "Datos Insertados Correctamente";
                }
                else
                {
                    CE.ID_OCUPACION = Convert.ToInt32(txt_id.Text);
                    CN_OCUPACION.ACTUALIZAR(CE);
                    MENSAJE = "Datos Actualizados Correctamente";
                }

                CP_UTILIDADES.MENSAJE_INFORMACION(MENSAJE, this);

                FRM_MANT_OCUPACIONES FRM = new FRM_MANT_OCUPACIONES();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FRM_MANT_OCUPACIONES")
                    {
                        FRM = (FRM_MANT_OCUPACIONES)frm;
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

        private void FRM_OCUPACION_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Ocupación";
                cb_estado.Text = "ACTIVO";
                cb_estado.Enabled = false;
            }
            else
            {
                this.Text = "Editar Ocupación";
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

            if (cb_estado.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Estado es Obligatorio", this);
                cb_estado.Focus();
                return;
            }

            INSERTAR_ACTUALIZAR();
        }
    }
}
