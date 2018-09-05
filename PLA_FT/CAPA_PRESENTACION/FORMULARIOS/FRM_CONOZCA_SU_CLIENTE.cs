using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_CONOZCA_SU_CLIENTE : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        CE_CONOZCA_SU_CLIENTE CE = new CE_CONOZCA_SU_CLIENTE();
        CE_CONOZCA_SU_CLIENTE CN = new CE_CONOZCA_SU_CLIENTE();

        public FRM_CONOZCA_SU_CLIENTE()
        {
            InitializeComponent();
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_oficina, "SP_LLENAR_COMBOBOX", "OFICINAS", "DESCRIPCION", "ID_OFICINA", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_nacionalidad_conyugue, "SP_LLENAR_COMBOBOX", "PAISES", "DESCRIPCION", "ID_PAIS", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        public void BUSCAR_CLIENTE()
        {
            if (CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows.Count > 0)
            {
                txt_nombres.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["NOMBRES"].ToString() + " " + CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["APELLIDO_PAT"].ToString() + " " + CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["APELLIDO_MAT"].ToString();
                txt_identificacion.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["IDENTIFICACION"].ToString();
                cb_oficina.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["OFICINA"].ToString();
                cb_tipo_cliente.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["TIPO_CLIENTE"].ToString();
                ch_pep.Checked = Convert.ToBoolean(CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["ES_PEP"].ToString());
                ch_vinculado_pep.Checked = Convert.ToBoolean(CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["VINCULADO_PEP"].ToString());

                txt_actividad_cargo_pep.Enabled = ch_pep.Checked == true ? true : false;
                txt_nombre1_vinculado_pep.Enabled = ch_vinculado_pep.Checked == true ? true : false;
                txt_nombre2_vinculado_pep.Enabled = ch_vinculado_pep.Checked == true ? true : false;
                txt_parentezco1_vinculado_pep.Enabled = ch_vinculado_pep.Checked == true ? true : false;
                txt_parentezco2_vinculado_pep.Enabled = ch_vinculado_pep.Checked == true ? true : false;
            }
            else
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("Este Cliente No Existe, O Esta Inactivo", this);
                txt_id_cliente.Text = "";
                txt_nombres.Text = "";
                txt_identificacion.Text = "";
                cb_oficina.Text = "";
                cb_tipo_cliente.Text = "";
                ch_pep.Checked = false;
                ch_vinculado_pep.Checked = false;
            }
        }

        public void RECIBIR_DATOS(CE_CONOZCA_SU_CLIENTE obj)
        {
            txt_id.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["ID_CONOZCA"].ToString();
            txt_actividad_cargo_pep.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA ="+ obj.ID_CONOZCA +"").Rows[0]["ACTIVIDAD_CAGO_PEP"].ToString();
            txt_actividad_negocio.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["ACTIVIDAD_DEL_NEGOCIO"].ToString();
            txt_actividad_empresa_cliente.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["ACTIVIDAD_EMPRESA"].ToString();
            txt_fecha_inicion_conyugue.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["ANTIGUEDAD_CONYUGUE"].ToString();
            txt_cargo_conyugue.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["CARGO_CONYUGUE"].ToString();
            txt_cargo_en_empresa.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["CARGO_EN_EMPRESA"].ToString();
            txt_direccion_empresa_cliente.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["DIRECCION_EMPRESA"].ToString();
            txt_direccion_negocio.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["DIRECCION_NEGOCIO"].ToString();
            txt_direccion_conyugue.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["DIRECCION_TRABAJO_CONYUGUE"].ToString();
            txt_nombre_empresa_cliente.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["EMPRESA_DONDE_LABORA"].ToString();
            txt_nombre_empresa_conyugue.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["EMPRESA_TRAJAJO_CONYUGUE"].ToString();
            txt_fecha_ingreso_empresa_cliente.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["FECHA_INGRESO"].ToString();
            txt_id_cliente.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["ID_CLIENTE"].ToString();
            txt_identifiacion_beneficiario.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["IDENTIFICACION_BENEFICIARIO"].ToString();
            txt_identificacion_conyugue.Text =CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["IDENTIFICACION_CONYUGUE"].ToString();
            txt_ingresos_negocio.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["INGRESO_MENSUAL"].ToString();
            cb_nacionalidad_conyugue.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["NACIONALIDAD_CONYUGUE"].ToString();
            ch_empresa_propia.Checked =Convert.ToBoolean( CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["NEGOCIO_PROPIO"].ToString());
            txt_beneficiario.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["NOMBRE_BENEFICIARIO"].ToString();
            txt_nombre_conyugue.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["NOMBRE_CONYUGUE"].ToString();
            txt_nombre_negocio.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["NOMBRE_NEGOCIO"].ToString();
            txt_nombre1_vinculado_pep.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["NOMBRE_PEP1"].ToString();
            txt_nombre2_vinculado_pep.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["NOMBRE_PEP2"].ToString();
            txt_numero_ruc_negocio.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["NUMERO_RUC"].ToString();
            txt_ocupacion_conyugue.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["OCUPACION_CONYUGUE"].ToString();
            txt_parentezco1_vinculado_pep.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["PARENTEZCO1"].ToString();
            txt_parentezco2_vinculado_pep.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["PARENTEZCO2"].ToString();
            txt_lugar_referencia_empresa.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["REFERENCIA_UBICACION_EMPRESA"].ToString();
            txt_lugar_referencia_negocio.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["REFERENCIA_UBICACION_NEGOCIO"].ToString();
            txt_sueldo_empresa_cliente.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["SUELDO"].ToString();
            txt_sueldo_conyugue.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["SUELDO_MENSUAL_CONYUGUE"].ToString();
            txt_telefono_empresa_cliente.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["TELEFONO_EMPRESA"].ToString();
            txt_telefono_negocio.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["TELEFONO_NEGOCIO"].ToString();
            txt_telefono_conyugue.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["TELEFONO_TRABAJO_CONYUGUE"].ToString();
            txt_fecha_inicion_negocio.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["TIEMPO_EN_EL_MERCADO"].ToString();
            txt_beneficiario.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["NOMBRE_BENEFICIARIO"].ToString();
            txt_identifiacion_beneficiario.Text = CN_CONOZCA_SU_CLIENTE.CONSULTAR("A.ID_CONOZCA =" + obj.ID_CONOZCA + "").Rows[0]["IDENTIFICACION_BENEFICIARIO"].ToString();
            BUSCAR_CLIENTE();

            if (CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_PERSONALES(obj.ID_CONOZCA).Rows.Count > 0)
            {
                int i;
                for (i = 0; (i
                            <= (CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_PERSONALES(obj.ID_CONOZCA)).Rows.Count - 1); i++)
                {
                    DG_REFERENCIAS_P.Rows.Add();
                    DG_REFERENCIAS_P.Rows[i].Cells[0].Value = CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_PERSONALES(obj.ID_CONOZCA).Rows[i]["NOMBRE"];
                    DG_REFERENCIAS_P.Rows[i].Cells[1].Value = CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_PERSONALES(obj.ID_CONOZCA).Rows[i]["IDENTIFICACION"];
                    DG_REFERENCIAS_P.Rows[i].Cells[2].Value = CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_PERSONALES(obj.ID_CONOZCA).Rows[i]["DIRECCION"];
                    DG_REFERENCIAS_P.Rows[i].Cells[3].Value = CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_PERSONALES(obj.ID_CONOZCA).Rows[i]["PARENTEZCO"];
                    DG_REFERENCIAS_P.Rows[i].Cells[4].Value = CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_PERSONALES(obj.ID_CONOZCA).Rows[i]["TELEFONO"];
                }
                DG_REFERENCIAS_P.DataSource = null;
            }

            if (CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_COMERCIALES(obj.ID_CONOZCA).Rows.Count > 0)
            {
                int e;
                for (e = 0; (e
                            <= (CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_COMERCIALES(obj.ID_CONOZCA)).Rows.Count - e); e++)
                {
                    DG_REFERENCIA_C.Rows.Add();
                    DG_REFERENCIA_C.Rows[e].Cells[0].Value = CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_COMERCIALES(obj.ID_CONOZCA).Rows[e]["NOMBRE"];
                    DG_REFERENCIA_C.Rows[e].Cells[1].Value = CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_COMERCIALES(obj.ID_CONOZCA).Rows[e]["DIRECCION"];
                    DG_REFERENCIA_C.Rows[e].Cells[2].Value = CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_COMERCIALES(obj.ID_CONOZCA).Rows[e]["TELEFONO"];
                }
                DG_REFERENCIA_C.DataSource = null;
            }

            if (CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_BANCARIAS(obj.ID_CONOZCA).Rows.Count > 0)
            {
                int f;
                for (f = 0; (f
                            <= (CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_BANCARIAS(obj.ID_CONOZCA)).Rows.Count - f); f++)
                {
                    DG_REFERENCIA_B.Rows.Add();
                    DG_REFERENCIA_B.Rows[f].Cells[0].Value = CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_BANCARIAS(obj.ID_CONOZCA).Rows[f]["BANCO"];
                    DG_REFERENCIA_B.Rows[f].Cells[1].Value = CN_CONOZCA_SU_CLIENTE.CONSULTAR_REFERENCIAS_BANCARIAS(obj.ID_CONOZCA).Rows[f]["TIPO_CUENTA"];
                }
                DG_REFERENCIA_B.DataSource = null;
            }

        }

        public void INSERTAR_ACTUALIZAR()
        {
            string MENSAJE = "";
            CE.ACTIVIDAD_CAGO_PEP = txt_actividad_cargo_pep.Text.Trim();
            CE.ACTIVIDAD_DEL_NEGOCIO = txt_actividad_negocio.Text.Trim();
            CE.ACTIVIDAD_EMPRESA = txt_actividad_empresa_cliente.Text.Trim();
            CE.ANTIGUEDAD_CONYUGUE = txt_fecha_inicion_conyugue.Text.Trim();
            CE.CARGO_CONYUGUE = txt_cargo_conyugue.Text.Trim();
            CE.CARGO_EN_EMPRESA = txt_cargo_en_empresa.Text.Trim();
            CE.DIRECCION_EMPRESA = txt_direccion_empresa_cliente.Text.Trim();
            CE.DIRECCION_NEGOCIO = txt_direccion_negocio.Text.Trim();
            CE.DIRECCION_TRABAJO_CONYUGUE = txt_direccion_conyugue.Text.Trim();
            CE.EMPRESA_DONDE_LABORA = txt_nombre_empresa_cliente.Text.Trim();
            CE.EMPRESA_TRAJAJO_CONYUGUE = txt_nombre_empresa_conyugue.Text.Trim();
            CE.FECHA = DateTime.Now;
            CE.FECHA_INGRESO = txt_fecha_ingreso_empresa_cliente.Text.Trim();
            CE.ID_CLIENTE = Convert.ToInt32(txt_id_cliente.Text.Trim());
            CE.IDENTIFICACION_BENEFICIARIO = txt_identifiacion_beneficiario.Text.Trim();
            CE.IDENTIFICACION_CONYUGUE = txt_identificacion_conyugue.Text.Trim();
            CE.INGRESO_MENSUAL = txt_ingresos_negocio.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_ingresos_negocio.Text);
            CE.NACIONALIDAD_CONYUGUE = cb_nacionalidad_conyugue.Text.Trim();
            CE.NEGOCIO_PROPIO = ch_empresa_propia.Checked;
            CE.NOMBRE_BENEFICIARIO = txt_beneficiario.Text.Trim();
            CE.NOMBRE_CONYUGUE = txt_nombre_conyugue.Text.Trim();
            CE.NOMBRE_NEGOCIO = txt_nombre_negocio.Text.Trim();
            CE.NOMBRE_PEP1 = txt_nombre1_vinculado_pep.Text.Trim();
            CE.NOMBRE_PEP2 = txt_nombre2_vinculado_pep.Text.Trim();
            CE.NUMERO_RUC = txt_numero_ruc_negocio.Text.Trim();
            CE.OCUPACION_CONYUGUE = txt_ocupacion_conyugue.Text.Trim();
            CE.PARENTEZCO1 = txt_parentezco1_vinculado_pep.Text.Trim();
            CE.PARENTEZCO2 = txt_parentezco2_vinculado_pep.Text.Trim();
            CE.REFERENCIA_UBICACION_EMPRESA = txt_lugar_referencia_empresa.Text.Trim();
            CE.REFERENCIA_UBICACION_NEGOCIO = txt_lugar_referencia_negocio.Text.Trim();
            CE.SUELDO = txt_sueldo_empresa_cliente.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_sueldo_empresa_cliente.Text);
            CE.SUELDO_MENSUAL_CONYUGUE = txt_sueldo_conyugue.Text.Length == 0 ? 0 : Convert.ToDecimal(txt_sueldo_conyugue.Text);
            CE.TELEFONO_EMPRESA = txt_telefono_empresa_cliente.Text.Trim();
            CE.TELEFONO_NEGOCIO = txt_telefono_negocio.Text.Trim();
            CE.TELEFONO_TRABAJO_CONYUGUE = txt_telefono_conyugue.Text.Trim();
            CE.TIEMPO_EN_EL_MERCADO = txt_fecha_inicion_negocio.Text.Trim();
            try
            {
                int ID_CONOZCA = 0;
                if (txt_id.Text.Equals(""))
                {
                    CN_CONOZCA_SU_CLIENTE.INSERTAR(CE);
                    MENSAJE = "Datos Insertados Correctamente";
                    ID_CONOZCA = Convert.ToInt32(CN_CONOZCA_SU_CLIENTE.CONSULTAR_MAX().Rows[0][0].ToString());
                }
                else
                {
                    CE.ID_CONOZCA = Convert.ToInt32(txt_id.Text);
                    CN_CONOZCA_SU_CLIENTE.ACTUALIZAR(CE);
                    MENSAJE = "Datos Actualizados Correctamente";
                    ID_CONOZCA = Convert.ToInt32(txt_id.Text);
                }

                CN_CONOZCA_SU_CLIENTE.ELIMINAR_REFERENCIAS_PERSONALES(ID_CONOZCA);
                
                if(DG_REFERENCIAS_P.Rows.Count > 0)
                {

                    foreach (DataGridViewRow  item in DG_REFERENCIAS_P.Rows)
                    {
                        CE_CONOZCA_SU_CLIENTE CP = new CE_CONOZCA_SU_CLIENTE();
                        CP.ID_CONOZCA_RP = ID_CONOZCA;
                        CP.IDENTIFICACION_RP = item.Cells["IDENTIFICACION"].Value.ToString();
                        CP.NOMBRE_RP = item.Cells["NOMBRE"].Value.ToString();
                        CP.DIRECCION_RP = item.Cells["DIRECCION"].Value.ToString();
                        CP.PARENTEZCO_RP = item.Cells["PARENTEZCO"].Value.ToString();
                        CP.TELEFONO_RP = item.Cells["TELEFONO"].Value.ToString();

                        CN_CONOZCA_SU_CLIENTE.INSERTAR_REFERENCIAS_PERSONALES(CP);
                    }
                }

                CN_CONOZCA_SU_CLIENTE.ELIMINAR_REFERENCIAS_COMERCIALES(ID_CONOZCA);

                if (DG_REFERENCIA_C.Rows.Count > 0)
                {

                    foreach (DataGridViewRow item in DG_REFERENCIA_C.Rows)
                    {
                        CE_CONOZCA_SU_CLIENTE CP = new CE_CONOZCA_SU_CLIENTE();
                        CP.ID_CONOZCA_RC = ID_CONOZCA;
                        CP.NOMBRE_RC = item.Cells["NOMBRE_C"].Value.ToString();
                        CP.DIRECCION_RC = item.Cells["DIRECCION_C"].Value.ToString();
                        CP.TELEFONO_RC = item.Cells["TELEFONO_C"].Value.ToString();

                        CN_CONOZCA_SU_CLIENTE.INSERTAR_REFERENCIAS_COMERCIALES(CP);
                    }
                }

                CN_CONOZCA_SU_CLIENTE.ELIMINAR_REFERENCIAS_BANCARIAS(ID_CONOZCA);

                if (DG_REFERENCIA_B.Rows.Count > 0)
                {
                    foreach (DataGridViewRow item in DG_REFERENCIA_B.Rows)
                    {
                        CE_CONOZCA_SU_CLIENTE CP = new CE_CONOZCA_SU_CLIENTE();
                        CP.ID_CONOZCA_RB = ID_CONOZCA;
                        CP.BANCO_RB = item.Cells["BANCO_B"].Value.ToString();
                        CP.TIPO_CUENTA_RB = item.Cells["TIPO_CUENTA_B"].Value.ToString();
                        CN_CONOZCA_SU_CLIENTE.INSERTAR_REFERENCIAS_BANCARIAS(CP);
                    }
                }

                CP_UTILIDADES.MENSAJE_INFORMACION(MENSAJE, this);

                FRM_MANT_CONOZCA_SU_CLIENTE FRM = new FRM_MANT_CONOZCA_SU_CLIENTE();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FRM_MANT_CONOZCA_SU_CLIENTE")
                    {
                        FRM = (FRM_MANT_CONOZCA_SU_CLIENTE)frm;
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_nombre_referencia.Text == "")
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Nombre es Obligatorio", this);
                txt_nombre_referencia.Focus();
                return;
            }

            if (CP_UTILIDADES.VALIDAR_CEDULA(txt_identificacion_referencia.Text) == false)
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Formato de Cedula es Incorrecto", this);
                txt_identificacion.Clear();
                return;
            }

            if (!txt_telefono_referencia.Text.Equals("   -   -"))
            {
                if (txt_telefono_referencia.Text.Length < 12)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Número de Teléfono Esta Incompleto", this);
                    txt_telefono_referencia.Focus();
                    return;
                }
            }

            foreach (DataGridViewRow item in DG_REFERENCIAS_P.Rows)
            {
                if (txt_nombre_referencia.Text.Trim() == item.Cells["NOMBRE"].Value.ToString())
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("Este Nombre ya esta en la Lista", this);
                    txt_nombre_referencia.Text = "";
                    return;
                }
            }

            string NOMBRE = txt_nombre_referencia.Text.Trim();
            string IDENTIFICACION = txt_identificacion_referencia.Text.Trim();
            string DIRECCION = txt_direccion_referencia.Text.Trim();
            string PARENTEZCO = txt_parentezco_referencia.Text.Trim();
            string TELEFONO = txt_telefono_referencia.Text.Trim();
            DG_REFERENCIAS_P.DataSource = null;

            DG_REFERENCIAS_P.Rows.Add(NOMBRE, IDENTIFICACION, DIRECCION, PARENTEZCO, TELEFONO);
            txt_nombre_referencia.Clear();
            txt_identificacion_referencia.Clear();
            txt_direccion_referencia.Clear();
            txt_parentezco_referencia.Clear();
            txt_telefono_referencia.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_nombre_referencia_c.Text == "")
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Nombre es Obligatorio", this);
                txt_nombre_referencia_c.Focus();
                return;
            }


            if (!txt_telefono_referencia_c.Text.Equals("   -   -"))
            {
                if (txt_telefono_referencia_c.Text.Length < 12)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Número de Teléfono Esta Incompleto", this);
                    txt_telefono_referencia_c.Focus();
                    return;
                }
            }

            foreach (DataGridViewRow item in DG_REFERENCIA_C.Rows)
            {
                if (txt_nombre_referencia_c.Text.Trim() == item.Cells["NOMBRE_C"].Value.ToString())
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("Este Nombre ya esta en la Lista", this);
                    txt_nombre_referencia_c.Text = "";
                    return;
                }
            }

            string NOMBRE = txt_nombre_referencia_c.Text.Trim();
            string DIRECCION = txt_direccion_referencia_c.Text.Trim();
            string TELEFONO = txt_telefono_referencia_c.Text.Trim();
            DG_REFERENCIA_C.DataSource = null;

            DG_REFERENCIA_C.Rows.Add(NOMBRE, DIRECCION, TELEFONO);
            txt_nombre_referencia_c.Clear();
            txt_direccion_referencia_c.Clear();
            txt_telefono_referencia_c.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txt_banco.Text == "")
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Banco es Obligatorio", this);
                txt_banco.Focus();
                return;
            }

            if (cb_tipo_cuenta.Text == "")
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Tipo de Cuenta es Obligatorio", this);
                cb_tipo_cuenta.Focus();
                return;
            }

            foreach (DataGridViewRow item in DG_REFERENCIA_B.Rows)
            {
                if (txt_banco.Text.Trim() == item.Cells["BANCO_B"].Value.ToString())
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("Este Banco ya esta en la Lista", this);
                    txt_banco.Text = "";
                    return;
                }
            }

            string BANCO = txt_banco.Text.Trim();
            string TIPO_CUENTA = cb_tipo_cuenta.Text.Trim();

            DG_REFERENCIA_B.DataSource = null;

            DG_REFERENCIA_B.Rows.Add(BANCO, TIPO_CUENTA);
            txt_banco.Clear();
            cb_tipo_cuenta.Text = "";
        }

        private void FRM_CONOZCA_SU_CLIENTE_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Datos Cliente";
            }
            else
            {
                this.Text = "Editar Datos Cliente";
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {


            if (txt_id_cliente.Text.Length==0)
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Cliente es Obligatorio", this);
                txt_id_cliente.Focus();
                tab.SelectedIndex = 0;
                return;
            }


            if (!txt_telefono_empresa_cliente.Text.Equals("   -   -"))
            {
                if (txt_telefono_empresa_cliente.Text.Length < 12)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Número de Teléfono Esta Incompleto", this);
                    txt_telefono_empresa_cliente.Focus();
                    tab.SelectedIndex = 1;
                    return;
                }
            }
            if (!txt_telefono_negocio.Text.Equals("   -   -"))
            {
                if (txt_telefono_negocio.Text.Length < 12)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Número de Teléfono Esta Incompleto", this);
                    txt_telefono_negocio.Focus();
                    tab.SelectedIndex = 2;
                    return;
                }
            }
            if (!txt_telefono_conyugue.Text.Equals("   -   -"))
            {
                if (txt_telefono_conyugue.Text.Length < 12)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Número de Teléfono Esta Incompleto", this);
                    txt_telefono_conyugue.Focus();
                    tab.SelectedIndex = 3;
                    return;
                }
            }

            if (!txt_telefono_referencia.Text.Equals("   -   -"))
            {
                if (txt_telefono_referencia.Text.Length < 12)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Número de Teléfono Esta Incompleto", this);
                    txt_telefono_referencia.Focus();
                    tab.SelectedIndex = 4;
                    return;
                }
            }
            if (!txt_telefono_referencia_c.Text.Equals("   -   -"))
            {
                if (txt_telefono_referencia_c.Text.Length < 12)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Número de Teléfono Esta Incompleto", this);
                    txt_telefono_referencia_c.Focus();
                    tab.SelectedIndex = 5;
                    return;
                }
            }
            

            
            
            INSERTAR_ACTUALIZAR();
        }

        private void txt_id_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BUSCAR_CLIENTE();
            }
        }

        private void txt_sueldo_empresa_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            CP_UTILIDADES.PERMITIR_NUMERO_Y_PUNTO(sender,e,txt_sueldo_empresa_cliente);
        }

        private void txt_ingresos_negocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CP_UTILIDADES.PERMITIR_NUMERO_Y_PUNTO(sender, e, txt_ingresos_negocio);
        }

        private void txt_sueldo_conyugue_KeyPress(object sender, KeyPressEventArgs e)
        {
            CP_UTILIDADES.PERMITIR_NUMERO_Y_PUNTO(sender, e, txt_sueldo_conyugue);
        }
    }
}
