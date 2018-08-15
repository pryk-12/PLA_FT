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
    public partial class FRM_EVALUACION : CAPA_PRESENTACION.FORMULARIOS.FRM_PLANTILLA
    {
        public FRM_EVALUACION()
        {
            InitializeComponent();
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_actividad_economica, "SP_LLENAR_COMBOBOX", "ACTIVIDADES_ECONOMICAS", "DESCRIPCION", "ID_ACTIVIDAD", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_nacionalidades, "SP_LLENAR_COMBOBOX", "PAISES", "DESCRIPCION", "ID_PAIS", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_paises, "SP_LLENAR_COMBOBOX", "PAISES", "DESCRIPCION", "ID_PAIS", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_provincias, "SP_LLENAR_COMBOBOX", "PROVINCIAS", "DESCRIPCION", "ID_PROVINCIA", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_cantidades_efectivo, "SP_LLENAR_COMBOBOX", "CANTIDADES_EFECTIVO", "DESCRIPCION", "ID_CANTIDAD", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
            CN_UTILIDADES.LLENAR_COMBOBOX(cb_oficina, "SP_LLENAR_COMBOBOX", "OFICINAS", "DESCRIPCION", "ID_OFICINA", "DESCRIPCION LIKE'%" + "" + "%' AND ESTADO='A'");
        }

        public void LISTAR_PRODUCTOS()
        {
            string CONDICION = "(DESCRIPCION LIKE'%" + "" + "%')";
            DG_PRODUCTOS.DataSource = CN_PRODUCTO.CONSULTAR(CONDICION);
        }

        public void LISTAR_CANALES()
        {
            string CONDICION = "(DESCRIPCION LIKE'%" + "" + "%')";
            DG_CANALES.DataSource = CN_CANAL.CONSULTAR(CONDICION);
        }

        private void FRM_EVALUACION_Load(object sender, EventArgs e)
        {
            if(txt_id.Text.Equals(""))
            {
                LISTAR_PRODUCTOS();
                LISTAR_CANALES();
                this.Text = "Agregar Evaluación";
            }
            else
            {
                this.Text = "Editar Evaluación";
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_CONSULTAR_CLIENTES FRM = new FRM_CONSULTAR_CLIENTES();
            FRM.ShowDialog();
        }

        public void BUSCAR_CLIENTE()
        {
          if(  CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE="+ txt_id_cliente.Text +"").Rows.Count>0)
          {
              txt_nombre.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["NOMBRE"].ToString();
              txt_identificacion.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["IDENTIFICACION"].ToString();
              cb_oficina.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["OFICINA"].ToString();
              cb_tipo.Text = CN_CLIENTE.VISTA_CLIENTE("ID_CLIENTE=" + txt_id_cliente.Text + "").Rows[0]["TIPO"].ToString();
          }
            else
          {
              CP_UTILIDADES.MENSAJE_INFORMACION("Este Cliente No Existe",this);
              txt_id_cliente.Text = "";
              txt_nombre.Text = "";
              txt_identificacion.Text = "";
              cb_oficina.Text = "";
              cb_tipo.Text = "";
          }
        }

        private void txt_id_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BUSCAR_CLIENTE();
            }
        }
    }
}
