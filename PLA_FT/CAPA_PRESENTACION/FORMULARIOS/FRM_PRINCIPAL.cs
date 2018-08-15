using System;
using System.Linq;
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

            btn_usuario.Text ="  "+ CP_UTILIDADES.DATOS_USUARIO.USUARIO;
        }

        private void btn_mantenimiento_Click(object sender, EventArgs e)
        {
            this.mn_mantenimientos.Show(btn_mantenimiento, 5, btn_mantenimiento.Height);
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

        private void btn_configuraciones_Click(object sender, EventArgs e)
        {
            this.mn_configuraciones.Show(btn_configuraciones, 5, btn_configuraciones.Height);
        }

        private void mn_mant_oficina_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_OFICINAS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_OFICINAS").SingleOrDefault();
            if (FRM_MANT_OFICINAS == null)
            {
                FRM_MANT_OFICINAS frm = new FRM_MANT_OFICINAS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void mn_conf_oficina_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_OFICINAS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_OFICINAS").SingleOrDefault();
            if (FRM_MANT_OFICINAS == null)
            {
                FRM_MANT_OFICINAS frm = new FRM_MANT_OFICINAS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void mn_mant_departamento_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_DEPARTAMENTOS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_DEPARTAMENTOS").SingleOrDefault();
            if (FRM_MANT_DEPARTAMENTOS == null)
            {
                FRM_MANT_DEPARTAMENTOS frm = new FRM_MANT_DEPARTAMENTOS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void mn_mant_puesto_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_PUESTOS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_PUESTOS").SingleOrDefault();
            if (FRM_MANT_PUESTOS == null)
            {
                FRM_MANT_PUESTOS frm = new FRM_MANT_PUESTOS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void mn_mant_usuario_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_USUARIOS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_USUARIOS").SingleOrDefault();
            if (FRM_MANT_USUARIOS == null)
            {
                FRM_MANT_USUARIOS frm = new FRM_MANT_USUARIOS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void mn_conf_actividad_economica_Click(object sender, EventArgs e)
        {

            Form FRM_MANT_ACTIVIDADES_ECONOMICAS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_ACTIVIDADES_ECONOMICAS").SingleOrDefault();
            if (FRM_MANT_ACTIVIDADES_ECONOMICAS == null)
            {
                FRM_MANT_ACTIVIDADES_ECONOMICAS frm = new FRM_MANT_ACTIVIDADES_ECONOMICAS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void mn_conf_producto_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_PRODUCTOS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_PRODUCTOS").SingleOrDefault();
            if (FRM_MANT_PRODUCTOS == null)
            {
                FRM_MANT_PRODUCTOS frm = new FRM_MANT_PRODUCTOS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void mn_conf_canal_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_CANALES = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_CANALES").SingleOrDefault();
            if (FRM_MANT_CANALES == null)
            {
                FRM_MANT_CANALES frm = new FRM_MANT_CANALES();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void mn_conf_pais_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_PAISES = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_PAISES").SingleOrDefault();
            if (FRM_MANT_PAISES == null)
            {
                FRM_MANT_PAISES frm = new FRM_MANT_PAISES();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void mn_conf_provincia_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_PROVINCIAS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_PROVINCIAS").SingleOrDefault();
            if (FRM_MANT_PROVINCIAS == null)
            {
                FRM_MANT_PROVINCIAS frm = new FRM_MANT_PROVINCIAS();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            this.metroContextMenu1.Show(btn_usuario, 5, btn_usuario.Height);
        }

        private void mn_conf_cantidad_efectivo_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_CANTIDADES_EFECTIVO = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_CANTIDADES_EFECTIVO").SingleOrDefault();
            if (FRM_MANT_CANTIDADES_EFECTIVO == null)
            {
                FRM_MANT_CANTIDADES_EFECTIVO frm = new FRM_MANT_CANTIDADES_EFECTIVO();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void mn_mant_clientes_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_CLIENTES = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_CLIENTES").SingleOrDefault();
            if (FRM_MANT_CLIENTES == null)
            {
                FRM_MANT_CLIENTES frm = new FRM_MANT_CLIENTES();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void btn_procesos_Click(object sender, EventArgs e)
        {
            this.mn_procesos.Show(btn_procesos, 5, btn_procesos.Height);
        }

        private void mn_proc_evaluaciones_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_EVALUACIONES = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_EVALUACIONES").SingleOrDefault();
            if (FRM_MANT_EVALUACIONES == null)
            {
                FRM_MANT_EVALUACIONES frm = new FRM_MANT_EVALUACIONES();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

       
    }
}
