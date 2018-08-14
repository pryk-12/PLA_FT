using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_PRINCIPAL : Form
    {
        public FRM_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void FRM_PRINCIPAL_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
                }
            }

            lbl_usuario.Text = CP_UTILIDADES.DATOS_USUARIO.USUARIO;

            OCULTAR_BARRAS(false);
        }

        public void OCULTAR_BARRAS(bool opcion)
        {
            pn_mantenimientos.Visible = opcion;
            pn_configuraciones.Visible = opcion;
        }

        private void btn_mantenimiento_Click(object sender, EventArgs e)
        {
            OCULTAR_BARRAS(false);
            pn_mantenimientos.Visible = true;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Deseas Cerrar Sesión", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            {
                FRM_LOGIN FRM = new FRM_LOGIN();
                this.Hide();
                FRM.Show();
            }
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CAMBIAR_CLAVE FRM = new FRM_CAMBIAR_CLAVE();
            FRM.ShowDialog();
        }

        private void btn_mant_oficina_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_OFICINAS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_OFICINAS").SingleOrDefault();
            if (FRM_MANT_OFICINAS == null)
            {
                FRM_MANT_OFICINAS frm = new FRM_MANT_OFICINAS();
                frm.MdiParent = this;
                frm.Show();
            }    
        }

        private void btn_mant_departamento_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_DEPARTAMENTOS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_DEPARTAMENTOS").SingleOrDefault();
            if (FRM_MANT_DEPARTAMENTOS == null)
            {
                FRM_MANT_DEPARTAMENTOS frm = new FRM_MANT_DEPARTAMENTOS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.metroContextMenu1.Show(pictureBox1, 0, pictureBox1.Height);
        }

        private void btn_procesos_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_mant_puesto_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_PUESTOS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_PUESTOS").SingleOrDefault();
            if (FRM_MANT_PUESTOS == null)
            {
                FRM_MANT_PUESTOS frm = new FRM_MANT_PUESTOS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void btn_mant_usuario_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_USUARIOS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_USUARIOS").SingleOrDefault();
            if (FRM_MANT_USUARIOS == null)
            {
                FRM_MANT_USUARIOS frm = new FRM_MANT_USUARIOS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void btn_conf_actividades_economicas_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_ACTIVIDADES_ECONOMICAS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_ACTIVIDADES_ECONOMICAS").SingleOrDefault();
            if (FRM_MANT_ACTIVIDADES_ECONOMICAS == null)
            {
                FRM_MANT_ACTIVIDADES_ECONOMICAS frm = new FRM_MANT_ACTIVIDADES_ECONOMICAS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void btn_configuraciones_Click(object sender, EventArgs e)
        {
            OCULTAR_BARRAS(false);
            pn_configuraciones.Visible = true;
        }

        private void btn_conf_productos_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_PRODUCTOS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_PRODUCTOS").SingleOrDefault();
            if (FRM_MANT_PRODUCTOS == null)
            {
                FRM_MANT_PRODUCTOS frm = new FRM_MANT_PRODUCTOS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }


    }
}
