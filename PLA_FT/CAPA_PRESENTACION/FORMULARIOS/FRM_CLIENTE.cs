using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_CLIENTE : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        CE_CLIENTE CE = new CE_CLIENTE();
        CN_CLIENTE CN = new CN_CLIENTE();

        public FRM_CLIENTE()
        {
            InitializeComponent();
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_oficina, "SP_LLENAR_COMBOBOX", "OFICINAS", "DESCRIPCION", "ID_OFICINA", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
        }

        public void RECIBIR_DATOS(CE_CLIENTE CE)
        {
            txt_nombre.Text = CE.NOMBRE;
            txt_identificacion.Text = CE.IDENTIFICACION;
            txt_id.Text = CE.ID_CLIENTE.ToString();
            cb_oficina.SelectedValue = CE.ID_OFICINA;
            cb_estado.Text = CE.ESTADO;
            cb_tipo.Text = CE.TIPO;
        }

        public void INSERTAR_ACTUALIZAR()
        {
            string MENSAJE = "";
            CE.NOMBRE = txt_nombre.Text.Trim();
            CE.IDENTIFICACION = txt_identificacion.Text.Trim();
            CE.ESTADO = cb_estado.Text;
            CE.ID_OFICINA = Convert.ToInt32(cb_oficina.SelectedValue);
            CE.TIPO = cb_tipo.Text;
            try
            {
                if (txt_id.Text.Equals(""))
                {
                    CN_CLIENTE.INSERTAR(CE);
                    MENSAJE = "Datos Insertados Correctamente";
                }
                else
                {
                    CE.ID_CLIENTE = Convert.ToInt32(txt_id.Text);
                    CN_CLIENTE.ACTUALIZAR(CE);
                    MENSAJE = "Datos Actualizados Correctamente";
                }

                CP_UTILIDADES.MENSAJE_INFORMACION(MENSAJE, this);

                FRM_MANT_CLIENTES FRM = new FRM_MANT_CLIENTES();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FRM_MANT_CLIENTES")
                    {
                        FRM = (FRM_MANT_CLIENTES)frm;
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

        private void FRM_CLIENTE_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Cliente";
                cb_estado.Text = "ACTIVO";
                cb_estado.Enabled = false;
            }
            else
            {
                this.Text = "Editar Cliente";
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Nombre es Obligatorio", this);
                txt_nombre.Focus();
                return;
            }
            if (txt_identificacion.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Identificación es Obligatoria", this);
                txt_identificacion.Focus();
                return;
            }
            if (cb_oficina.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Oficina es Obligatoria", this);
                cb_oficina.Focus();
                return;
            }
            if (cb_tipo.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Tipo es Obligatorio", this);
                cb_tipo.Focus();
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
