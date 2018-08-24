using CAPA_NEGOCIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_PERMISOS : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_PERMISOS()
        {
            InitializeComponent();
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_usuario, "SP_LLENAR_COMBOBOX", "USUARIOS", "USUARIO", "ID_USUARIO", "USUARIO LIKE'%" + "" + "%' AND ESTADO='A'");
        }

        private void cb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_usuario.Text == "" && (DG_MENU.Rows.Count > 0 && DG_PERMISO.RowCount > 0))
            {
                DG_MENU.DataSource = null;
                DG_PERMISO.DataSource = null;
                return;
            }
            try
            {
                if (CN_PERMISO.CONSULTAR_PERMISO_MENU(cb_usuario.Text).Rows.Count == 0)
                {
                    DG_MENU.DataSource = CN_PERMISO.CONSULTAR_MENU();
                    DG_MENU.Columns[0].Width = 300;
                    DG_MENU.Columns[1].Width = 80;
                }
                else
                {
                    DG_MENU.DataSource = CN_PERMISO.CONSULTAR_PERMISO_MENU(cb_usuario.Text);
                    DG_MENU.Columns[0].Width = 300;
                    DG_MENU.Columns[1].Width = 80;
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void DG_MENU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DG_MENU.RowCount == 0)
            {
                return;
            }

            string condicion = "PANTALLA LIKE '%" + DG_MENU.SelectedCells[0].Value.ToString() + "%'";
            string usuario = "USUARIO ='"+ cb_usuario.Text +"'";

            if (CN_PERMISO.CONSULTAR_PERMISO(usuario).Rows.Count == 0)
            {
                DG_PERMISO.DataSource = CN_PERMISO.CONSULTAR_PANTALLAS(condicion);
                DG_PERMISO.Columns[0].Width = 300;
                DG_PERMISO.Columns[1].Width = 80;
                DG_PERMISO.Columns[2].Width = 80;
                DG_PERMISO.Columns[3].Width = 80;
            }
            else
            {
                DG_PERMISO.DataSource = CN_PERMISO.CONSULTAR_PERMISO(cb_usuario.Text);
                DG_PERMISO.Columns[0].Width = 300;
                DG_PERMISO.Columns[1].Width = 80;
                DG_PERMISO.Columns[2].Width = 80;
                DG_PERMISO.Columns[3].Width = 80;
            }
        }
    }
}
