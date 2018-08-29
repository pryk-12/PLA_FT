using CAPA_ENTIDAD;
using CAPA_NEGOCIOS;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_EMPRESA : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_EMPRESA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(*… *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"; //formatos soportados
            openFileDialog1.FilterIndex = 4;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                if (string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("No ha Seleccionado Ninguna Imagen",this);
                    return;
                }
            }
        }

        public void ACTUALIZAR()
        {
            try
            {
                System.IO.MemoryStream ms = new MemoryStream();
                this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] ruta_imagen = ms.GetBuffer();

                System.IO.MemoryStream ms1 = new MemoryStream();
                this.pictureBox2.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                byte[] ruta_imagen2 = ms1.GetBuffer();

                CE_EMPRESA obj = new CE_EMPRESA();
                obj.CELULAR = txt_celular.Text;
                obj.DIRECCION = txt_direccion.Text.Trim();
                obj.EMAIL = txt_email.Text.Trim();
                obj.NOMBRE_EMPRESA = txt_nombre.Text.Trim();
                obj.IDENTIFICACION = txt_identificacion.Text.Trim();
                obj.LOGO = ruta_imagen;
                obj.PAGINA_WEB = txt_pagina_web.Text.Trim();
                obj.TELEFONO = txt_telefono.Text.Trim();
                obj.POLITICA_CLAVE = cb_politica_clave.Text;
                obj.FONDO_PANTALLA = ruta_imagen2;
                this.btn_editar.Enabled = true;
                this.btn_agregar.Enabled = false;
                this.metroPanel1.Enabled = false;
                CN_EMPRESA.ACTUALIZAR(obj);
                CP_UTILIDADES.MENSAJE_INFORMACION("Datos De Empresa Actualizados Con Éxito", this);
            }
            catch (Exception ex)
            {
                CP_UTILIDADES.MENSAJE_INFORMACION(ex.Message,this);
            }
           
        }

        public void Cargar_Datos()
        {
            try
            {
                this.metroPanel1.Enabled = false;
                this.btn_agregar.Enabled = false;
                txt_celular.Text = CN_EMPRESA.CONSULTAR().Rows[0]["CELULAR"].ToString();
                txt_direccion.Text = CN_EMPRESA.CONSULTAR().Rows[0]["DIRECCION"].ToString();
                txt_email.Text = CN_EMPRESA.CONSULTAR().Rows[0]["EMAIL"].ToString();
                txt_nombre.Text = CN_EMPRESA.CONSULTAR().Rows[0]["NOMBRE_EMPRESA"].ToString();
                txt_pagina_web.Text = CN_EMPRESA.CONSULTAR().Rows[0]["PAGINA_WEB"].ToString();
                txt_telefono.Text = CN_EMPRESA.CONSULTAR().Rows[0]["TELEFONO"].ToString();
                txt_identificacion.Text = CN_EMPRESA.CONSULTAR().Rows[0]["IDENTIFICACION"].ToString();
                byte[] Logo = (byte[])CN_EMPRESA.CONSULTAR().Rows[0]["LOGO"];
                System.IO.MemoryStream ms = new MemoryStream(Logo);
                cb_politica_clave.Text = CN_EMPRESA.CONSULTAR().Rows[0]["POLITICA_CLAVE"].ToString();
                byte[] Logo2 = (byte[])CN_EMPRESA.CONSULTAR().Rows[0]["FONDO_PANTALLA"];
                System.IO.MemoryStream ms1 = new MemoryStream(Logo2);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox2.Image = Image.FromStream(ms1);
            }
            catch
            {

            }
        }

        private void FRM_EMPRESA_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("El Nombre es Obligatorio",this);
                txt_nombre.Focus();
                return;
            }

            if (txt_direccion.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("La Dirección es Obligatoria",this);
                txt_direccion.Focus();
                return;
            }

            if (!txt_telefono.Text.Equals("   -   -"))
            {
                if (txt_telefono.Text.Length < 12)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Número de Teléfono Esta Incompleto",this);
                    txt_telefono.Focus();
                    return;
                }
            }

            if (!txt_celular.Text.Equals("   -   -"))
            {
                if (txt_celular.Text.Length < 12)
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Número de Celular Esta Incompleto",this);
                    txt_celular.Focus();
                    return;
                }
            }

            if (cb_politica_clave.Text.Equals(""))
            {
                CP_UTILIDADES.MENSAJE_INFORMACION("Se debe Seleccionar si la Clave es con o sin Politica", this);
                cb_politica_clave.Focus();
                return;
            }

            if (!txt_email.Text.Trim().Equals(""))
            {
                if (!CP_UTILIDADES.VALIDAR_CORREO(txt_email.Text))
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("El Formato del E-Mail es Incorrecto",this);
                    txt_email.Focus();
                    return;
                }
            }

            ACTUALIZAR();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::CAPA_PRESENTACION.Properties.Resources.Logo_Transparente;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.metroPanel1.Enabled = true;
            this.btn_agregar.Enabled = true;
            this.btn_editar.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(*… *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"; //formatos soportados
            openFileDialog1.FilterIndex = 4;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                if (string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    CP_UTILIDADES.MENSAJE_INFORMACION("No ha Seleccionado Ninguna Imagen", this);
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = global::CAPA_PRESENTACION.Properties.Resources.Logo_Transparente;
        }
    }
}
