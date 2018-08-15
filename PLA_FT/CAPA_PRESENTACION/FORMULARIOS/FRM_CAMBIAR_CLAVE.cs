using System;
using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;

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
            CE_USUARIO CE = new CE_USUARIO();
            CE.USUARIO = txt_usuario.Text.Trim();
            CE.CLAVE = CP_UTILIDADES.ENCRIPTAR_CLAVE(txt_clave.Text);
            CN_USUARIO.CAMBIAR_CLAVE(CE);
            CP_UTILIDADES.MENSAJE_INFORMACION("Las Clave Fue Cambiada Correctamente", this);
            Close();
        }


    }
}
