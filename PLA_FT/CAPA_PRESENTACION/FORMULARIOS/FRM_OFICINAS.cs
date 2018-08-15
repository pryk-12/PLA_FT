using System;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_OFICINAS : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        CE_OFICINA CE = new CE_OFICINA();
        CN_OFICINA CN = new CN_OFICINA();

        public FRM_OFICINAS()
        {
            InitializeComponent();
        }

        public void RECIBIR_DATOS(CE_OFICINA CE)
        {
            txt_descripcion.Text = CE.DESCRIPCION;
            txt_direccion.Text = CE.DIRECCION;
            txt_id.Text = CE.ID_OFICINA.ToString();
            txt_telefono.Text = CE.TELEFONO;
            cb_estado.Text = CE.ESTADO;
            txt_valoracion.Text = CE.VALORACION.ToString();
            cb_nivel_riesgo.Text = CE.NIVEL_RIESGO;
        }

        public void INSERTAR_ACTUALIZAR()
        {
            string MENSAJE = "";
            CE.DESCRIPCION = txt_descripcion.Text.Trim();
            CE.DIRECCION = txt_direccion.Text.Trim();
            CE.ESTADO = cb_estado.Text;
            CE.TELEFONO = txt_telefono.Text;
            CE.VALORACION = txt_valoracion.Text.Length == 0 ? 0 : Convert.ToDouble(txt_valoracion.Text);
            CE.NIVEL_RIESGO = cb_nivel_riesgo.Text;
            try
            {
                if (txt_id.Text.Equals(""))
                {
                    CN_OFICINA.INSERTAR(CE);
                    MENSAJE = "Datos Insertados Correctamente";
                }
                else
                {
                    CE.ID_OFICINA = Convert.ToInt32(txt_id.Text);
                    CN_OFICINA.ACTUALIZAR(CE);
                    MENSAJE = "Datos Actualizados Correctamente";
                }

                CP_UTILIDADES.MENSAJE_INFORMACION(MENSAJE, this);

                FRM_MANT_OFICINAS FRM = new FRM_MANT_OFICINAS();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FRM_MANT_OFICINAS")
                    {
                        FRM = (FRM_MANT_OFICINAS)frm;
                        FRM.CONSULTAR();
                        this.Close();
                        break;
                    }
                }

                Close();
            }
            catch (Exception ex)
            {
                CP_UTILIDADES.MENSAJE_ERROR(ex.Message,this);
            }
           
        }

        private void FRM_OFICINAS_Load(object sender, EventArgs e)
        {
            if(txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Oficina";
                cb_estado.Text = "ACTIVO";
                cb_estado.Enabled = false;
            }
            else
            {
                this.Text = "Editar Oficina";
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(txt_descripcion.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Descripción es Obligatoria",this);
                txt_descripcion.Focus();
                return;
            }
            if (txt_direccion.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Dirección es Obligatoria", this);
                txt_direccion.Focus();
                return;
            }
            if (!txt_telefono.Text.Equals("   -   -"))
            {
                if (txt_telefono.Text.Length < 12)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Teléfono Tiene el Formato Incorrecto", this);
                    txt_telefono.Focus();
                    return;
                }
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
    }
}
