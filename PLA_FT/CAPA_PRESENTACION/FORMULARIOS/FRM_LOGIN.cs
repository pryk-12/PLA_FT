using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CAPA_NEGOCIOS;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_LOGIN : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mant_oficina_Click(object sender, EventArgs e)
        {
            if(txt_usuario.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Usuario es Obligatorio",this);
                txt_usuario.Focus();
                return;
            }
            if (CN_USUARIO.CONSULTAR("A.USUARIO='" + txt_usuario.Text.Trim() + "'").Rows.Count == 0)
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("Este Usuario no Existe",this);
                txt_usuario.Clear();
                txt_clave.Clear();
                txt_usuario.Focus();
                txt_clave.Enabled = true;
                return;
            }

            if (CN_USUARIO.CONSULTAR("A.USUARIO='" + txt_usuario.Text.Trim() + "' AND A.ESTADO='INACTIVO'").Rows.Count > 0)
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("Este Usuario esta Inactivo", this);
                txt_usuario.Clear();
                txt_clave.Clear();
                txt_usuario.Focus();
                txt_clave.Enabled = true;
                return;
            }

            if (CN_USUARIO.CONSULTAR("(A.USUARIO='" + txt_usuario.Text.Trim() + "' AND A.CLAVE='" + CP_UTILIDADES.ENCRIPTAR_CLAVE(txt_clave.Text.Trim()) + "')").Rows.Count >= 1)
            {
                CP_UTILIDADES.DATOS_USUARIO.USUARIO = txt_usuario.Text.Trim();

                FRM_PRINCIPAL frm = new FRM_PRINCIPAL();
                this.Hide();
                frm.Show();
            }
            else
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("Datos de Usuario Incorrectos",this);
                txt_clave.Clear();
                txt_clave.Focus();
            }
        }
    }
}
