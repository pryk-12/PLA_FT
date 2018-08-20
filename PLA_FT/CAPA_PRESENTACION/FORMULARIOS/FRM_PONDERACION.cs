using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CAPA_NEGOCIOS;
using CAPA_ENTIDAD;
namespace CAPA_PRESENTACION.FORMULARIOS
{
    public partial class FRM_PONDERACION : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_PONDERACION()
        {
            InitializeComponent();
        }
        public void CONSULTAR()
        {
            if(CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString() == "ACTIVIDAD ECONOMICA")
            {
                txt_actividad.Text = CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString();
                txt_porc_actividad.Text  = CN_PONDERACION.CONSULTAR().Rows[0]["PORCIENTO"].ToString();
            }
            if(CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString() == "PRODUCTOS")
            {
                txt_producto.Text = CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString();
                txt_porc_producto.Text = CN_PONDERACION.CONSULTAR().Rows[0]["PORCIENTO"].ToString();
            }
            if (CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString() == "CANALES")
            {
                txt_canal.Text = CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString();
                txt_porc_canal.Text = CN_PONDERACION.CONSULTAR().Rows[0]["PORCIENTO"].ToString();
            }
            if (CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString() == "CANTIDAD EFECTIVO")
            {
                txt_cantidad.Text = CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString();
                txt_porc_cantidad.Text = CN_PONDERACION.CONSULTAR().Rows[0]["PORCIENTO"].ToString();
            }
            if (CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString() == "PAIS NACIONALIDAD")
            {
                txt_nacionalidad.Text = CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString();
                txt_porc_nacionalidad.Text = CN_PONDERACION.CONSULTAR().Rows[0]["PORCIENTO"].ToString();
            }
            if (CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString() == "PAIS RESIDENCIA")
            {
                txt_pais.Text = CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString();
                txt_porc_pais.Text = CN_PONDERACION.CONSULTAR().Rows[0]["PORCIENTO"].ToString();
            }
            if (CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString() == "PROVINCIA")
            {
                txt_provincia.Text = CN_PONDERACION.CONSULTAR().Rows[0]["DESCRIPCION"].ToString();
                txt_porc_provincia.Text = CN_PONDERACION.CONSULTAR().Rows[0]["PORCIENTO"].ToString();
            }

        }

        private void FRM_PONDERACION_Load(object sender, EventArgs e)
        {
            CONSULTAR();
        }
    }
}
