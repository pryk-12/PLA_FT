using System;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_DEPARTAMENTO : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        CE_DEPARTAMENTO CE = new CE_DEPARTAMENTO();
        CN_DEPARTAMENTO CN = new CN_DEPARTAMENTO();
        CN_UTILIDADES CNU = new CN_UTILIDADES();

        public FRM_DEPARTAMENTO()
        {
            InitializeComponent();
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_oficina, "SP_LLENAR_COMBOBOX","OFICINAS","DESCRIPCION","ID_OFICINA","DESCRIPCION LIKE'%"+ "" +"%' AND ESTADO='A'");
        }

        public void RECIBIR_DATOS(CE_DEPARTAMENTO CE)
        {
            cb_oficina.SelectedValue = CE.ID_OFICINA;
            txt_descripcion.Text = CE.DESCRIPCION;
            txt_id.Text = CE.ID_DEPARTAMENTO.ToString();
            cb_estado.Text = CE.ESTADO;
        }

        public void INSERTAR_ACTUALIZAR()
        {
            string MENSAJE = "";
            CE.ID_OFICINA =  Convert.ToInt32(cb_oficina.SelectedValue);
            CE.DESCRIPCION = txt_descripcion.Text.Trim();
            CE.ESTADO = cb_estado.Text;
            try
            {
                if (txt_id.Text.Equals(""))
                {
                    CN_DEPARTAMENTO.INSERTAR(CE);
                    MENSAJE = "Datos Insertados Correctamente";
                }
                else
                {
                    CE.ID_DEPARTAMENTO= Convert.ToInt32(txt_id.Text);
                    CN_DEPARTAMENTO.ACTUALIZAR(CE);
                    MENSAJE = "Datos Actualizados Correctamente";
                }

                CP_UTILIDADES.MENSAJE_INFORMACION(MENSAJE, this);

                FRM_MANT_DEPARTAMENTOS FRM = new FRM_MANT_DEPARTAMENTOS();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FRM_MANT_DEPARTAMENTOS")
                    {
                        FRM = (FRM_MANT_DEPARTAMENTOS)frm;
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

        private void FRM_DEPARTAMENTO_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Departamento";
                cb_estado.Text = "ACTIVO";
                cb_estado.Enabled = false;
            }
            else
            {
                this.Text = "Editar Departamento";
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
