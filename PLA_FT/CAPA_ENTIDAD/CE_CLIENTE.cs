
using System;
namespace CAPA_ENTIDAD
{
   public class CE_CLIENTE
    {
       public int ID_CLIENTE { get; set; }
       public string NOMBRES { get; set; }
       public string APELLIDO_PAT { get; set; }
       public string APELLIDO_MAT { get; set; }
       public string TIPO_CLIENTE { get; set; }
       public int ID_TIPO_IDENTIFICACION { get; set; }
       public string IDENTIFICACION { get; set; }
       public int ID_OFICINA { get; set; }
       public int ID_LUGAR_NACIMIENTO { get; set; }
       public DateTime FECHA_NACIMIENTO { get; set; }
       public int ID_NACIONALIDAD { get; set; }
       public string ESTADO_CIVIL { get; set; }
       public string SEXO { get; set; }
       public int ID_OCUPACION { get; set; }
       public string EMAIL { get; set; }
       public string DIRECCION_RESIDENCIAL { get; set; }
       public int ID_PROVINCIA { get; set; }
       public string TELEFONO { get; set; }
       public string CELULAR { get; set; }
       public string TIPO_VIVIENDA { get; set; }
       public bool ES_PEP { get; set; }
       public bool VINCULADO_PEP { get; set; }
       public string ESTADO { get; set; }
    }
}

























