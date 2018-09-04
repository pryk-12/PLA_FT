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
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_lugar_nacimiento, "SP_LLENAR_COMBOBOX", "PROVINCIAS", "DESCRIPCION", "ID_PROVINCIA", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_ocupacion, "SP_LLENAR_COMBOBOX", "OCUPACIONES", "DESCRIPCION", "ID_OCUPACION", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_pais_nacionalidad, "SP_LLENAR_COMBOBOX", "PAISES", "DESCRIPCION", "ID_PAIS", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_provincia, "SP_LLENAR_COMBOBOX", "PROVINCIAS", "DESCRIPCION", "ID_PROVINCIA", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_tipo_identificacion, "SP_LLENAR_COMBOBOX", "TIPO_IDENTIFICACIONES", "DESCRIPCION", "ID_TIPO_IDENTIFICACION", "DESCRIPCION LIKE'%" + "" + "%'");
        }

        public void RECIBIR_DATOS(CE_CLIENTE CE)
        {
            txt_nombres.Text = CE.NOMBRES;
            txt_apellido_mat.Text = CE.APELLIDO_MAT;
            txt_apellido_pat.Text = CE.APELLIDO_PAT;
            txt_celular.Text = CE.CELULAR;
            txt_direccion.Text = CE.DIRECCION_RESIDENCIAL;
            txt_email.Text = CE.EMAIL;
            txt_id.Text = CE.ID_CLIENTE.ToString();
            txt_identificacion.Text = CE.IDENTIFICACION;
            txt_telefono.Text = CE.TELEFONO;           
            cb_estado.Text = CE.ESTADO;
            cb_lugar_nacimiento.SelectedValue = CE.ID_LUGAR_NACIMIENTO;
            cb_ocupacion.SelectedValue = CE.ID_OCUPACION;
            cb_oficina.SelectedValue = CE.ID_OFICINA;
            cb_pais_nacionalidad.SelectedValue = CE.ID_NACIONALIDAD;
            cb_provincia.SelectedValue = CE.ID_PROVINCIA;
            cb_sexo.Text = CE.SEXO;
            cb_tipo_cliente.Text = CE.TIPO_CLIENTE;
            cb_tipo_identificacion.SelectedValue = CE.ID_TIPO_IDENTIFICACION;
            cb_tipo_vivienda.Text = CE.TIPO_VIVIENDA;
            ch_pep.Checked = CE.ES_PEP;
            ch_vinculado_pep.Checked = CE.VINCULADO_PEP;
            dt_fecha_nacimiento.Text = CE.FECHA_NACIMIENTO.ToString();

            if (cb_sexo.Text == "MASCULINO")
            {
                cb_estado_civil.Items.Clear();
                cb_estado_civil.Items.Add("");
                cb_estado_civil.Items.Add("SOLTERO");
                cb_estado_civil.Items.Add("CASADO");
                cb_estado_civil.Items.Add("UNION LIBRE");
                cb_estado_civil.Items.Add("VIUDO");
            }
            else if (cb_sexo.Text == "FEMENINO")
            {
                cb_estado_civil.Items.Clear();
                cb_estado_civil.Items.Add("");
                cb_estado_civil.Items.Add("SOLTERA");
                cb_estado_civil.Items.Add("CASADA");
                cb_estado_civil.Items.Add("UNION LIBRE");
                cb_estado_civil.Items.Add("VIUDA");
            }

            cb_estado_civil.Text = CE.ESTADO_CIVIL;
        }

        public void INSERTAR_ACTUALIZAR()
        {
            string MENSAJE = "";
            CE.APELLIDO_MAT = txt_apellido_mat.Text.Trim();
            CE.APELLIDO_PAT = txt_apellido_pat.Text.Trim();
            CE.CELULAR = txt_celular.Text.Trim();
            CE.DIRECCION_RESIDENCIAL = txt_direccion.Text.Trim();
            CE.EMAIL = txt_email.Text.Trim();
            CE.ES_PEP = ch_pep.Checked;
            CE.ESTADO = cb_estado.Text;
            CE.ESTADO_CIVIL = cb_estado_civil.Text;
            CE.FECHA_NACIMIENTO = dt_fecha_nacimiento.Value.Date;
            CE.ID_LUGAR_NACIMIENTO = Convert.ToInt32(cb_lugar_nacimiento.SelectedValue);
            CE.ID_NACIONALIDAD = Convert.ToInt32(cb_pais_nacionalidad.SelectedValue);
            CE.ID_OCUPACION = Convert.ToInt32(cb_ocupacion.SelectedValue);
            CE.ID_OFICINA = Convert.ToInt32(cb_oficina.SelectedValue);
            CE.ID_PROVINCIA = Convert.ToInt32(cb_provincia.SelectedValue);
            CE.ID_TIPO_IDENTIFICACION = Convert.ToInt32(cb_tipo_identificacion.SelectedValue);
            CE.IDENTIFICACION = txt_identificacion.Text.Trim();
            CE.NOMBRES = txt_nombres.Text.Trim();
            CE.SEXO = cb_sexo.Text;
            CE.TELEFONO = txt_telefono.Text;
            CE.TIPO_CLIENTE = cb_tipo_cliente.Text;
            CE.TIPO_VIVIENDA = cb_tipo_vivienda.Text;
            CE.VINCULADO_PEP = ch_vinculado_pep.Checked;

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
            if (txt_nombres.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Nombre es Obligatorio", this);
                txt_nombres.Focus();
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
            if (cb_tipo_cliente.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Tipo es Obligatorio", this);
                cb_tipo_cliente.Focus();
                return;
            }
            if (cb_estado_civil.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Estado Civil es Obligatorio", this);
                cb_estado_civil.Focus();
                return;
            }
            if (cb_lugar_nacimiento.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Lugar de Nacimiento es Obligatorio", this);
                cb_lugar_nacimiento.Focus();
                return;
            }
            if (cb_ocupacion.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Ocupación es Obligatoria", this);
                cb_ocupacion.Focus();
                return;
            }
            if (cb_pais_nacionalidad.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Pais de Nacionalidad es Obligatorio", this);
                cb_pais_nacionalidad.Focus();
                return;
            }
            if (cb_provincia.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Provincia de Residencia es Obligatoria", this);
                cb_provincia.Focus();
                return;
            }
            if (cb_sexo.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Sexo es Obligatorio", this);
                cb_sexo.Focus();
                return;
            }
            if (cb_tipo_identificacion.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Tipo de Identificación es Obligatorio", this);
                cb_tipo_identificacion.Focus();
                return;
            }
            if (cb_estado.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Estado es Obligatorio", this);
                cb_estado.Focus();
                return;
            }

            if (!txt_telefono.Text.Equals("   -   -"))
            {
                if (txt_telefono.Text.Length < 12)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Número de Teléfono Esta Incompleto", this);
                    txt_telefono.Focus();
                    return;
                }
            }

            if (!txt_celular.Text.Equals("   -   -"))
            {
                if (txt_celular.Text.Length < 12)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Número de Celular Esta Incompleto", this);
                    txt_celular.Focus();
                    return;
                }
            }

            if (!txt_email.Text.Trim().Equals(""))
            {
                if (!CP_UTILIDADES.VALIDAR_CORREO(txt_email.Text))
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Formato del E-Mail es Incorrecto", this);
                    txt_email.Focus();
                    return;
                }
            }

            if (cb_tipo_cliente.Text == "FISICO")
            {
                if(txt_identificacion.Text.Length < 13)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Formato de Cedula es Incorrecto, se debe incluir los guiones", this);
                    return;
                }

                if (CP_UTILIDADES.VALIDAR_CEDULA(txt_identificacion.Text) == false)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Formato de Cedula es Incorrecto", this);
                    txt_identificacion.Clear();
                    return;
                }
            }
            else
            {
                if (CP_UTILIDADES.VALIDAR_RNC(txt_identificacion.Text) == false)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Formato de RNC es Incorrecto", this);
                    txt_identificacion.Clear();
                    return;
                }
            }
            INSERTAR_ACTUALIZAR();
        }

        private void txt_identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cb_oficina.Text == "FISICO")
                {
                    if (CP_UTILIDADES.VALIDAR_CEDULA(txt_identificacion.Text) == false)
                    {
                        CP_UTILIDADES.MENSAJE_INFORMACION("El Formato de Cedula es Incorrecto", this);
                        txt_identificacion.Clear();
                        return;
                    }
                }
                else
                {
                    if (CP_UTILIDADES.VALIDAR_RNC(txt_identificacion.Text) == false)
                    {
                        CP_UTILIDADES.MENSAJE_INFORMACION("El Formato de RNC es Incorrecto", this);
                        txt_identificacion.Clear();
                        return;
                    }
                }
            }
        }

        private void cb_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cb_sexo.Text =="MASCULINO")
                {
                    cb_estado_civil.Items.Clear();
                    cb_estado_civil.Items.Add("");
                    cb_estado_civil.Items.Add("SOLTERO");
                    cb_estado_civil.Items.Add("CASADO");
                    cb_estado_civil.Items.Add("UNION LIBRE");
                    cb_estado_civil.Items.Add("VIUDO");
                }
                else if(cb_sexo.Text =="FEMENINO")
                {
                    cb_estado_civil.Items.Clear();
                    cb_estado_civil.Items.Add("");
                    cb_estado_civil.Items.Add("SOLTERA");
                    cb_estado_civil.Items.Add("CASADA");
                    cb_estado_civil.Items.Add("UNION LIBRE");
                    cb_estado_civil.Items.Add("VIUDA");
                }
            }
            catch
            {

            }
        }
    }
}
