using System;

namespace CAPA_ENTIDAD
{
   public class CE_CONOZCA_SU_CLIENTE
    {
        public int ID_CONOZCA { get; set; }
        public int ID_CLIENTE { get; set; }
        public DateTime FECHA { get; set; }
        public string ACTIVIDAD_CAGO_PEP { get; set; }
        public string NOMBRE_PEP1 { get; set; }
        public string NOMBRE_PEP2 { get; set; }
        public string PARENTEZCO1 { get; set; }
        public string PARENTEZCO2 { get; set; }
        public string EMPRESA_DONDE_LABORA { get; set; }
        public string CARGO_EN_EMPRESA { get; set; }
        public string FECHA_INGRESO { get; set; }
        public decimal SUELDO { get; set; }
        public string ACTIVIDAD_EMPRESA { get; set; }
        public string TELEFONO_EMPRESA { get; set; }
        public string DIRECCION_EMPRESA { get; set; }
        public string REFERENCIA_UBICACION_EMPRESA { get; set; }
        public bool NEGOCIO_PROPIO { get; set; }
        public string NOMBRE_NEGOCIO { get; set; }
        public string TIEMPO_EN_EL_MERCADO { get; set; }
        public string NUMERO_RUC { get; set; }
        public decimal INGRESO_MENSUAL { get; set; }
        public string ACTIVIDAD_DEL_NEGOCIO { get; set; }
        public string TELEFONO_NEGOCIO { get; set; }
        public string DIRECCION_NEGOCIO { get; set; }
        public string REFERENCIA_UBICACION_NEGOCIO { get; set; }
        public string NOMBRE_CONYUGUE { get; set; }
        public string NACIONALIDAD_CONYUGUE { get; set; }
        public string IDENTIFICACION_CONYUGUE { get; set; }
        public string OCUPACION_CONYUGUE { get; set; }
        public string TELEFONO_TRABAJO_CONYUGUE { get; set; }
        public string EMPRESA_TRAJAJO_CONYUGUE { get; set; }
        public decimal SUELDO_MENSUAL_CONYUGUE { get; set; }
        public string DIRECCION_TRABAJO_CONYUGUE { get; set; }
        public string CARGO_CONYUGUE { get; set; }
        public string ANTIGUEDAD_CONYUGUE { get; set; }
        public string NOMBRE_BENEFICIARIO { get; set; }
        public string IDENTIFICACION_BENEFICIARIO { get; set; }

       //REFERENCIAS PERSONALES
        public int ID_CONOZCA_RP { get; set; }
        public string NOMBRE_RP { get; set; }
        public string IDENTIFICACION_RP { get; set; }
        public string PARENTEZCO_RP { get; set; }
        public string DIRECCION_RP { get; set; }
        public string TELEFONO_RP { get; set; }

        //REFERENCIAS COMERCIALES
        public int ID_CONOZCA_RC { get; set; }
        public string NOMBRE_RC { get; set; }
        public string DIRECCION_RC { get; set; }
        public string TELEFONO_RC { get; set; }

       //REFERENCIAS BANCARIAS
        public int ID_CONOZCA_RB { get; set; }
        public string BANCO_RB { get; set; }
        public string TIPO_CUENTA_RB { get; set; }

    }
}
