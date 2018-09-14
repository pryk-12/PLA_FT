using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_USUARIO : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        CE_USUARIO CE = new CE_USUARIO();
        CN_USUARIO CN = new CN_USUARIO();
        CN_UTILIDADES CNU = new CN_UTILIDADES();

        public FRM_USUARIO()
        {
            InitializeComponent();
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_oficina, "SP_LLENAR_COMBOBOX", "OFICINAS", "DESCRIPCION", "ID_OFICINA", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
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

        public void RECIBIR_DATOS(CE_USUARIO CE)
        {
            cb_oficina.SelectedValue = CE.ID_OFICINA;
            cb_departamento.SelectedValue = CE.ID_DEPARTAMENTO;
            cb_puesto.SelectedValue = CE.ID_PUESTO;
            txt_id.Text = CE.ID_USUARIO.ToString();
            txt_nombre.Text = CE.NOMBRE;
            txt_usuario.Text = CE.USUARIO;
            txt_clave.Text = CP_UTILIDADES.DESENCRIPTAR_CLAVE(CE.CLAVE);
            cb_estado.Text = CE.ESTADO;
            cb_sexo.Text = CE.SEXO;
        }

        public void INSERTAR_ACTUALIZAR()
        {
            string MENSAJE = "";
            CE.ID_OFICINA = Convert.ToInt32(cb_oficina.SelectedValue);
            CE.ID_DEPARTAMENTO = Convert.ToInt32(cb_departamento.SelectedValue);
            CE.ID_PUESTO = Convert.ToInt32(cb_puesto.SelectedValue);
            CE.NOMBRE = txt_nombre.Text.Trim();
            CE.USUARIO = txt_usuario.Text.Trim();
            CE.CLAVE = CP_UTILIDADES.ENCRIPTAR_CLAVE(txt_clave.Text.Trim());
            CE.ESTADO = cb_estado.Text.Trim();
            CE.SEXO = cb_sexo.Text;
            try
            {
                if (txt_id.Text.Equals(""))
                {
                    CN_USUARIO.INSERTAR(CE);
                    MENSAJE = "Datos Insertados Correctamente";
                }
                else
                {
                    CE.ID_USUARIO = Convert.ToInt32(txt_id.Text);
                    CN_USUARIO.ACTUALIZAR(CE);
                    MENSAJE = "Datos Actualizados Correctamente";
                }

                CP_UTILIDADES.MENSAJE_INFORMACION(MENSAJE, this);

                FRM_MANT_USUARIOS FRM = new FRM_MANT_USUARIOS();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FRM_MANT_USUARIOS")
                    {
                        FRM = (FRM_MANT_USUARIOS)frm;
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

        private void cb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CN_UTILIDADES.LLENAR_COMBOBOX(cb_puesto, "SP_LLENAR_COMBOBOX", "PUESTOS", "DESCRIPCION", "ID_PUESTO", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A' AND ID_DEPARTAMENTO=" + cb_departamento.SelectedValue + " AND ID_OFICINA=" + cb_oficina.SelectedValue + "");
            }
            catch
            {

            }
        }

        private void FRM_USUARIO_Load(object sender, EventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                this.Text = "Agregar Usuario";
                cb_estado.Text = "ACTIVO";
                cb_estado.Enabled = false;
            }
            else
            {
                this.Text = "Editar Usuario";
            }

            if (CN_EMPRESA.CONSULTAR().Rows[0]["POLITICA_CLAVE"].ToString() == "SI")
            {
                button2.Visible = true;
            }
            else
            {
                button2.Visible = false;
            }

            this.Width = 525;
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
            if (cb_puesto.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Puesto es Obligatorio", this);
                cb_puesto.Focus();
                return;
            }
            if (txt_nombre.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Nombre es Obligatorio", this);
                txt_nombre.Focus();
                return;
            }
            if (txt_usuario.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Usuario es Obligatorio", this);
                txt_usuario.Focus();
                return;
            }
            if (txt_clave.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Clave es Obligatoria", this);
                txt_clave.Focus();
                return;
            }
            if (cb_estado.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Estado es Obligatorio", this);
                cb_estado.Focus();
                return;
            }
            if (cb_sexo.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Sexo es Obligatorio", this);
                cb_sexo.Focus();
                return;
            }

            if (CN_EMPRESA.CONSULTAR().Rows[0]["POLITICA_CLAVE"].ToString() == "SI")
            {
                string clave = txt_clave.Text.Trim();
                string mensaje = "";

                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMiniMaxChars = new Regex(@".{8,15}");
                var hasLowerChar = new Regex(@"[a-z]+");
                var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

                if (!hasLowerChar.IsMatch(clave))
                {
                    mensaje = "La clave debe contener al menos una letra minúscula";
                    CP_UTILIDADES.MENSAJE_INFORMACION(mensaje, this);
                    return;
                }
                else if (!hasUpperChar.IsMatch(clave))
                {
                    mensaje = "La clave debe contener Al menos una letra mayúscula";
                    CP_UTILIDADES.MENSAJE_INFORMACION(mensaje, this);
                    return;
                }
                else if (!hasMiniMaxChars.IsMatch(clave))
                {
                    mensaje = "La clave no debe ser menor de 8 o mayor que 15 caracteres";
                    CP_UTILIDADES.MENSAJE_INFORMACION(mensaje, this);
                    return;
                }
                else if (!hasNumber.IsMatch(clave))
                {
                    mensaje = "La contraseña debe contener al menos un valor numérico";
                    CP_UTILIDADES.MENSAJE_INFORMACION(mensaje, this);
                    return;
                }
            }
                      
            INSERTAR_ACTUALIZAR();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Width == 944)
            {
                this.Width = 525;
            }
            else
            {
                this.Width = 944;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
