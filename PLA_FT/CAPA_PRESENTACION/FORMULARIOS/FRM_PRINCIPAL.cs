using CAPA_NEGOCIOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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

        public void Permiso_Menu()
        {
            String Mantenimientos = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND MENU = 'Mantenimientos'";
            String Procesos = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND MENU = 'Procesos'";
            String Reportes = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND MENU = 'Reportes'";
            String Configuraciones = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND MENU = 'Configuraciones'";

            var Mantenimiento = CN_PERMISO.CONSULTAR_PERMISO_MENU(Mantenimientos);
            var Proceso = CN_PERMISO.CONSULTAR_PERMISO_MENU(Procesos);
            var Reporte = CN_PERMISO.CONSULTAR_PERMISO_MENU(Reportes);
            var Configuracione = CN_PERMISO.CONSULTAR_PERMISO_MENU(Configuraciones);
            
            //Menu mantenimientos
            btn_mantenimiento.Enabled = Convert.ToBoolean(Mantenimiento.Rows[0]["ACCESO"].ToString()) == true ? true : false;
           
            //Menu procesos
            btn_procesos.Enabled = Convert.ToBoolean(Proceso.Rows[0]["ACCESO"].ToString()) == true ? true : false;
           
            //Menu reportes
            btn_reportes.Enabled = Convert.ToBoolean(Reporte.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            
            //Menu configuraciones
            btn_configuraciones.Enabled = Convert.ToBoolean(Configuracione.Rows[0]["ACCESO"].ToString()) == true ? true : false;
        }

        public void Permiso_Acceso_Panatallas()
        {
            if (CN_PERMISO.CONSULTAR_PERMISO("USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "'").Rows.Count == 0)
            {
                mn_configuraciones.Enabled = false;
                mn_mantenimientos.Enabled = false;
                mn_procesos.Enabled = false;
                mn_reportes.Enabled = false;
                return;
            }
           
            String Mant_Oficinas = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Mantenimientos - Oficinas'";
            String Mant_Departamentos = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Mantenimientos - Departamentos'";
            String Mant_Puestos = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Mantenimientos - Puestos'";
            String Mant_Usuarios = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Mantenimientos - Usuarios'";
            String Mant_Clientes = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Mantenimientos - Clientes'";
            String Mant_Ocupaciones = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Mantenimientos - Ocupaciones'";
            String Mant_Lista_Documentos = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Mantenimientos - Lista Documentos Solicitados'";

            String Procesos = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Procesos - Evaluación de Riesgo'";

            String Reportes = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Reportes - Listado de Evaluaciónes'";

            String Conf_Actividades_Economicas = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Configuraciones - Actividades Economícas'";
            String Conf_Canales = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Configuraciones - Canales'";
            String Conf_Cantidades = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Configuraciones - Cantidades Efectivo'";
            String Conf_Paises = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Configuraciones - Paises'";
            String Conf_Productos = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Configuraciones - Productos'";
            String Conf_Provincias = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Configuraciones - Provincias'";
            String Conf_Recomendaciones = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Configuraciones - Recomendaciones'";
            String Conf_Ponderaciones = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Configuraciones - Ponderaciones'";
            String Conf_Empresas = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Configuraciones - Datos de Empresa'";
            String Conf_Permisos = "USUARIO = '" + CP_UTILIDADES.DATOS_USUARIO.USUARIO + "' AND PANTALLA = 'Configuraciones - Permisos'";

            var Mant_Oficina = CN_PERMISO.CONSULTAR_PERMISO(Mant_Oficinas);
            var Mant_Departamento = CN_PERMISO.CONSULTAR_PERMISO(Mant_Departamentos);
            var Mant_Puesto = CN_PERMISO.CONSULTAR_PERMISO(Mant_Puestos);
            var Mant_Usuario = CN_PERMISO.CONSULTAR_PERMISO(Mant_Usuarios);
            var Mant_Cliente = CN_PERMISO.CONSULTAR_PERMISO(Mant_Clientes);
            var Mant_Ocupacion = CN_PERMISO.CONSULTAR_PERMISO(Mant_Ocupaciones);
            var Mant_Lista_Documento = CN_PERMISO.CONSULTAR_PERMISO(Mant_Lista_Documentos);

            var Proceso = CN_PERMISO.CONSULTAR_PERMISO(Procesos);

            var Reporte = CN_PERMISO.CONSULTAR_PERMISO(Reportes);

            var Conf_Actividad_Economica = CN_PERMISO.CONSULTAR_PERMISO(Conf_Actividades_Economicas);
            var Conf_Canale = CN_PERMISO.CONSULTAR_PERMISO(Conf_Canales);
            var Conf_Cantidade = CN_PERMISO.CONSULTAR_PERMISO(Conf_Cantidades);
            var Conf_Paise = CN_PERMISO.CONSULTAR_PERMISO(Conf_Paises);
            var Conf_Producto = CN_PERMISO.CONSULTAR_PERMISO(Conf_Productos);
            var Conf_Provincia = CN_PERMISO.CONSULTAR_PERMISO(Conf_Provincias);
            var Conf_Recomendacion = CN_PERMISO.CONSULTAR_PERMISO(Conf_Recomendaciones);
            var Conf_Ponderacion = CN_PERMISO.CONSULTAR_PERMISO(Conf_Ponderaciones);
            var Conf_Empresa = CN_PERMISO.CONSULTAR_PERMISO(Conf_Empresas);
            var Conf_Permiso = CN_PERMISO.CONSULTAR_PERMISO(Conf_Permisos);

            //Menu mantenimientos
            mn_mant_oficina.Enabled = Convert.ToBoolean(Mant_Oficina.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            mn_mant_departamento.Enabled = Convert.ToBoolean(Mant_Departamento.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            mn_mant_puesto.Enabled = Convert.ToBoolean(Mant_Puesto.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            mn_mant_usuario.Enabled = Convert.ToBoolean(Mant_Usuario.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            mn_mant_clientes.Enabled = Convert.ToBoolean(Mant_Cliente.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            mn_mant_ocupaciones.Enabled = Convert.ToBoolean(Mant_Ocupacion.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            mn_mant_listaDocumentos.Enabled = Convert.ToBoolean(Mant_Lista_Documento.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            //Menu procesos
            mn_proc_evaluaciones.Enabled = Convert.ToBoolean(Proceso.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            //Menu reportes

            mn_rep_listado.Enabled = Convert.ToBoolean(Reporte.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            
            //Menu configuraciones
            mn_conf_actividad_economica.Enabled = Convert.ToBoolean(Conf_Actividad_Economica.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            mn_conf_canal.Enabled = Convert.ToBoolean(Conf_Canale.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            mn_conf_cantidad_efectivo.Enabled = Convert.ToBoolean(Conf_Cantidade.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            mn_conf_pais.Enabled = Convert.ToBoolean(Conf_Paise.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            mn_conf_producto.Enabled = Convert.ToBoolean(Conf_Producto.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            mn_conf_provincia.Enabled = Convert.ToBoolean(Conf_Provincia.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            btn_conf_recomendaciones.Enabled = Convert.ToBoolean(Conf_Recomendacion.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            btn_conf_ponderaciones.Enabled = Convert.ToBoolean(Conf_Ponderacion.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            btn_conf_empresa.Enabled = Convert.ToBoolean(Conf_Empresa.Rows[0]["ACCESO"].ToString()) == true ? true : false;
            btn_conf_permisos.Enabled = Convert.ToBoolean(Conf_Permiso.Rows[0]["ACCESO"].ToString()) == true ? true : false;
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
            panel1.Width = 183;
            byte[] Logo = (byte[])CN_EMPRESA.CONSULTAR().Rows[0]["FONDO_PANTALLA"];
            System.IO.MemoryStream ms = new MemoryStream(Logo);
            this.BackgroundImage = Image.FromStream(ms);
           

            btn_usuario.Text ="  "+ CP_UTILIDADES.DATOS_USUARIO.USUARIO;

            Permiso_Menu();
            Permiso_Acceso_Panatallas();
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

        private void btn_conf_recomendaciones_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_RECOMENDACIONES = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_RECOMENDACIONES").SingleOrDefault();
            if (FRM_MANT_RECOMENDACIONES == null)
            {
                FRM_MANT_RECOMENDACIONES frm = new FRM_MANT_RECOMENDACIONES();
                frm.MdiParent = this;
                frm.Show();
            }   
        }

        private void btn_conf_ponderaciones_Click(object sender, EventArgs e)
        {
            Form FRM_PONDERACION = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_PONDERACION").SingleOrDefault();
            if (FRM_PONDERACION == null)
            {
                FRM_PONDERACION frm = new FRM_PONDERACION();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_conf_empresa_Click(object sender, EventArgs e)
        {
            Form FRM_EMPRESA = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_EMPRESA").SingleOrDefault();
            if (FRM_EMPRESA == null)
            {
                FRM_EMPRESA frm = new FRM_EMPRESA();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mn_rep_listado_Click(object sender, EventArgs e)
        {
            Form FRM_REPORTES = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_REPORTES").SingleOrDefault();
            if (FRM_REPORTES == null)
            {
                FRM_REPORTES frm = new FRM_REPORTES();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            this.mn_reportes.Show(btn_reportes, 5, btn_reportes.Height);
        }

        private void btn_conf_permisos_Click(object sender, EventArgs e)
        {
            Form FRM_PERMISOS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_PERMISOS").SingleOrDefault();
            if (FRM_PERMISOS == null)
            {
                FRM_PERMISOS frm = new FRM_PERMISOS();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void actualizarMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permiso_Acceso_Panatallas();
            Permiso_Menu();

            byte[] Logo = (byte[])CN_EMPRESA.CONSULTAR().Rows[0]["FONDO_PANTALLA"];
            System.IO.MemoryStream ms = new MemoryStream(Logo);
            this.BackgroundImage = Image.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel1.Width == 183)
            {
                panel1.Width = 50;
            }
            else
            {
                panel1.Width = 183;
            }

            byte[] Logo = (byte[])CN_EMPRESA.CONSULTAR().Rows[0]["FONDO_PANTALLA"];
            System.IO.MemoryStream ms = new MemoryStream(Logo);
            this.BackgroundImage = Image.FromStream(ms);
        }

        private void mn_mant_ocupaciones_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_OCUPACIONES = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_OCUPACIONES").SingleOrDefault();
            if (FRM_MANT_OCUPACIONES == null)
            {
                FRM_MANT_OCUPACIONES frm = new FRM_MANT_OCUPACIONES();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mn_mant_listaDocumentos_Click(object sender, EventArgs e)
        {
            Form FRM_MANT_LISTA_DOCUMENTOS = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FRM_MANT_LISTA_DOCUMENTOS").SingleOrDefault();
            if (FRM_MANT_LISTA_DOCUMENTOS == null)
            {
                FRM_MANT_LISTA_DOCUMENTOS frm = new FRM_MANT_LISTA_DOCUMENTOS();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
