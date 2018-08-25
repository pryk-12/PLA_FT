using CAPA_ENTIDAD;
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

        public void INSERTAR()
        {
            try
            {
                CN_PERMISO.ELIMINAR_MENU(cb_usuario.Text);
                foreach (DataGridViewRow item in DG_MENU.Rows)
                {
                    CE_PERMISO CE = new CE_PERMISO();
                    CE.MENU_MENU = item.Cells[0].Value.ToString();
                    CE.MENU_ACCESO = Convert.ToBoolean(item.Cells[1].Value.ToString());
                    CE.MENU_USUARIO = cb_usuario.Text;
                    CN_PERMISO.INSERTAR_MENU(CE);
                }

                CN_PERMISO.ELIMINAR_PERMISO(cb_usuario.Text);
                foreach (DataGridViewRow item in DG_PERMISO.Rows)
                {
                    CE_PERMISO CE = new CE_PERMISO();
                    CE.PERMISO_PANTALLA = item.Cells[0].Value.ToString();
                    CE.PERMISO_ACCESO = Convert.ToBoolean(item.Cells[1].Value.ToString());
                    CE.PERMISO_AGREGAR = Convert.ToBoolean(item.Cells[2].Value.ToString());
                    CE.PERMISO_EDITAR = Convert.ToBoolean(item.Cells[3].Value.ToString());
                    CE.PERMISO_USUARIO = cb_usuario.Text;
                    CN_PERMISO.INSERTAR_PERMISO(CE);
                }

                CP_UTILIDADES.MENSAJE_INFORMACION("Datos Guardados Correctamente", this);
                Close();
            }
            catch (Exception ex)
            {
                CP_UTILIDADES.MENSAJE_ERROR(ex.Message,this);
            }
            
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

                if (DG_MENU.RowCount > 0)
                {
                    DG_MENU.Columns[0].ReadOnly = true;
                }

                string condicion = "PANTALLA LIKE '%" +""+ "%'";
                string usuario = "USUARIO ='" + cb_usuario.Text + "'";

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
                    DG_PERMISO.DataSource = CN_PERMISO.CONSULTAR_PERMISO(usuario);
                    DG_PERMISO.Columns[0].Width = 300;
                    DG_PERMISO.Columns[1].Width = 80;
                    DG_PERMISO.Columns[2].Width = 80;
                    DG_PERMISO.Columns[3].Width = 80;
                }
                if (DG_PERMISO.RowCount > 0)
                {
                    DG_PERMISO.Columns[0].ReadOnly = true;
                }

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DG_PERMISO.RowCount ==0)
            {
                return;
            }
            Seleccionar(true);
        }

        private void DG_MENU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        public void Seleccionar(bool opacion)
        {
            foreach (DataGridViewRow item in DG_PERMISO.Rows)
            {
                item.Cells[1].Value = opacion;
                item.Cells[2].Value = opacion;
                item.Cells[3].Value = opacion;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DG_PERMISO.RowCount == 0)
            {
                return;
            }
            Seleccionar(false);
        }

        private void FRM_PERMISOS_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cb_usuario.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("Se Debe Seleccionar El Usuario", this);
                cb_usuario.Focus();
                return;
            }

            if (DG_MENU.RowCount == 0)
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("No Hay Opciones de Menu Para Insertar", this);
                cb_usuario.Focus();
                return;
            }
            if (DG_PERMISO.RowCount == 0)
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("No Hay Permisos de Pantallas Para Insertar", this);
                cb_usuario.Focus();
                return;
            }
            INSERTAR();
        }
    }
}
