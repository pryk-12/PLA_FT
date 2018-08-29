using System;
using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System.Text.RegularExpressions;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_CAMBIAR_CLAVE : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_CAMBIAR_CLAVE()
        {
            InitializeComponent();
            txt_usuario.Text = CP_UTILIDADES.DATOS_USUARIO.USUARIO;
        }

        private void btn_mant_oficina_Click(object sender, EventArgs e)
        {
            if(txt_clave.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Clave es Obligatoria",this);
                txt_clave.Focus();
                return;
            }
            if (!txt_clave.Text.Equals(txt_confirmar_clave.Text))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("Las Clave No Son Iguales", this);
                txt_confirmar_clave.Focus();
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
                    mensaje = "La clave no debe ser menor o mayor que 12 caracteres";
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


            CE_USUARIO CE = new CE_USUARIO();
            CE.USUARIO = txt_usuario.Text.Trim();
            CE.CLAVE = CP_UTILIDADES.ENCRIPTAR_CLAVE(txt_clave.Text);
            CN_USUARIO.CAMBIAR_CLAVE(CE);
            CP_UTILIDADES.MENSAJE_INFORMACION("Las Clave Fue Cambiada Correctamente", this);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Width == 625)
            {
                this.Width = 254;
            }
            else
            {
                this.Width = 625;
            }
        }

        private void FRM_CAMBIAR_CLAVE_Load(object sender, EventArgs e)
        {
            this.Width = 254;

            if(CN_EMPRESA.CONSULTAR().Rows[0]["POLITICA_CLAVE"].ToString()=="SI")
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }

        }


    }
}
