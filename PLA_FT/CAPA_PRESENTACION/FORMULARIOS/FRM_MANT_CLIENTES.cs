using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_MANT_CLIENTES : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_MANT_CLIENTES()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void CONSULTAR()
        {
            string CONDICION = "(A.ID_CLIENTE LIKE'%" + txt_buscar.Text + "%' OR A.NOMBRES LIKE'%" + txt_buscar.Text + "%' OR A.APELLIDO_PAT LIKE'%" + txt_buscar.Text + "%' OR A.APELLIDO_MAT LIKE'%" + txt_buscar.Text + "%' OR A.IDENTIFICACION LIKE'%" + txt_buscar.Text + "%' OR B.DESCRIPCION LIKE'%" + txt_buscar.Text + "%')";
            DG.DataSource = CN_CLIENTE.CONSULTAR(CONDICION);
            lbl_total.Text = "Total de Registro(s):  " + DG.Rows.Count.ToString();
        }

        public void Permiso_Acceso_Panatallas()
        {
            String condicion = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Mantenimientos - Clientes'";
            var Actividad_Economica = CN_PERMISO.CONSULTAR_PERMISO(condicion);
            btn_agregar.Enabled = Convert.ToBoolean(Actividad_Economica.Rows[0]["AGREGAR"].ToString()) == true ? true : false;
            btn_editar.Enabled = Convert.ToBoolean(Actividad_Economica.Rows[0]["EDITAR"].ToString()) == true ? true : false;
        }

        public void PASAR_DATOS()
        {
            if (DG.Rows.Count == 0)
            {
                return;
            }

            FRM_CLIENTE FRM = new FRM_CLIENTE();
            CE_CLIENTE CE = new CE_CLIENTE();
            CE.ID_CLIENTE = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_CLIENTE"].Value.ToString());
            CE.NOMBRES = DG.Rows[DG.CurrentRow.Index].Cells["NOMBRES"].Value.ToString();
            CE.APELLIDO_MAT = DG.Rows[DG.CurrentRow.Index].Cells["APELLIDO_MAT"].Value.ToString();
            CE.APELLIDO_PAT = DG.Rows[DG.CurrentRow.Index].Cells["APELLIDO_PAT"].Value.ToString();
            CE.CELULAR = DG.Rows[DG.CurrentRow.Index].Cells["CELULAR"].Value.ToString();
            CE.DIRECCION_RESIDENCIAL = DG.Rows[DG.CurrentRow.Index].Cells["DIRECCION_RESIDENCIAL"].Value.ToString();
            CE.EMAIL = DG.Rows[DG.CurrentRow.Index].Cells["EMAIL"].Value.ToString();
            CE.ES_PEP =Convert.ToBoolean(DG.Rows[DG.CurrentRow.Index].Cells["ES_PEP"].Value.ToString());
            CE.ESTADO = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO"].Value.ToString();
            CE.ESTADO_CIVIL = DG.Rows[DG.CurrentRow.Index].Cells["ESTADO_CIVIL"].Value.ToString();
            CE.FECHA_NACIMIENTO =Convert.ToDateTime( DG.Rows[DG.CurrentRow.Index].Cells["FECHA_NACIMIENTO"].Value.ToString());
            CE.ID_LUGAR_NACIMIENTO = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_LUGAR_NACIMIENTO"].Value.ToString());
            CE.ID_NACIONALIDAD = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_NACIONALIDAD"].Value.ToString());
            CE.ID_OCUPACION = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_OCUPACION"].Value.ToString());
            CE.ID_OFICINA = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_OFICINA"].Value.ToString());
            CE.ID_PROVINCIA = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_PROVINCIA"].Value.ToString());
            CE.ID_TIPO_IDENTIFICACION = Convert.ToInt32(DG.Rows[DG.CurrentRow.Index].Cells["ID_TIPO_IDENTIFICACION"].Value.ToString());
            CE.IDENTIFICACION = DG.Rows[DG.CurrentRow.Index].Cells["IDENTIFICACION"].Value.ToString();
            CE.SEXO = DG.Rows[DG.CurrentRow.Index].Cells["SEXO"].Value.ToString();
            CE.TELEFONO = DG.Rows[DG.CurrentRow.Index].Cells["TELEFONO"].Value.ToString();
            CE.TIPO_CLIENTE = DG.Rows[DG.CurrentRow.Index].Cells["TIPO_CLIENTE"].Value.ToString();
            CE.TIPO_VIVIENDA = DG.Rows[DG.CurrentRow.Index].Cells["TIPO_VIVIENDA"].Value.ToString();
            CE.VINCULADO_PEP = Convert.ToBoolean(DG.Rows[DG.CurrentRow.Index].Cells["VINCULADO_PEP"].Value.ToString());
            FRM.RECIBIR_DATOS(CE);
            FRM.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FRM_CLIENTE FRM = new FRM_CLIENTE();
            FRM.ShowDialog();
        }

        private void FRM_MANT_CLIENTES_Load(object sender, EventArgs e)
        {
            CONSULTAR();
            Permiso_Acceso_Panatallas();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CONSULTAR();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            PASAR_DATOS();
        }
    }
}
