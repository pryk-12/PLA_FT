using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_PUESTO : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        CE_PUESTO CE = new CE_PUESTO();
        CN_PUESTO CN = new CN_PUESTO();
        CN_UTILIDADES CNU = new CN_UTILIDADES();

        public FRM_PUESTO()
        {
            InitializeComponent();
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_oficina, "SP_LLENAR_COMBOBOX", "OFICINAS", "DESCRIPCION", "ID_OFICINA", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
        }

        public void RECIBIR_DATOS(CE_PUESTO CE)
        {
            cb_oficina.SelectedValue = CE.ID_OFICINA;
            cb_departamento.SelectedValue = CE.ID_DEPARTAMENTO;
            txt_descripcion.Text = CE.DESCRIPCION;
            txt_id.Text = CE.ID_PUESTO.ToString();
            cb_estado.Text = CE.ESTADO;
        }

        public void INSERTAR_ACTUALIZAR()
        {
            string MENSAJE = "";
            CE.ID_OFICINA = Convert.ToInt32(cb_oficina.SelectedValue);
            CE.ID_DEPARTAMENTO = Convert.ToInt32(cb_departamento.SelectedValue);
            CE.DESCRIPCION = txt_descripcion.Text.Trim();
            CE.ESTADO = cb_estado.Text;
            try
            {
                if (txt_id.Text.Equals(""))
                {
                    CN_PUESTO.INSERTAR(CE);
                    MENSAJE = "Datos Insertados Correctamente";
                }
                else
                {
                    CE.ID_PUESTO = Convert.ToInt32(txt_id.Text);
                    CN_PUESTO.ACTUALIZAR(CE);
                    MENSAJE = "Datos Actualizados Correctamente";
                }

                CP_UTILIDADES.MENSAJE_INFORMACION(MENSAJE, this);

                FRM_MANT_PUESTOS FRM = new FRM_MANT_PUESTOS();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FRM_MANT_PUESTOS")
                    {
                        FRM = (FRM_MANT_PUESTOS)frm;
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

        private void FRM_PUESTO_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Puesto";
                cb_estado.Text = "ACTIVO";
                cb_estado.Enabled = false;
            }
            else
            {
                this.Text = "Editar Puesto";
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cb_oficina.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Oficina es Obligatoria", this);
                cb_oficina.Focus();
                return;
            }
            if (cb_departamento.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Departamento es Obligatorio", this);
                cb_departamento.Focus();
                return;
            }

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

        private void cb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_oficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CN_UTILIDADES.LLENAR_COMBOBOX(cb_departamento, "SP_LLENAR_COMBOBOX", "DEPARTAMENTOS", "DESCRIPCION", "ID_DEPARTAMENTO", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A' AND ID_OFICINA=" + cb_oficina.SelectedValue + "");
            }
            catch
            {

            }
        }
    }
}
