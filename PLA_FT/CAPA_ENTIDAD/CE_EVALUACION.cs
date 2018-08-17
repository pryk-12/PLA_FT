using System;

namespace CAPA_ENTIDAD
{
   public class CE_EVALUACION
    {
       public int ID_EVALUACION { get; set; }
       public DateTime FECHA { get; set; }
       public int ID_CLIENTE { get; set; }
       public int ID_ACTIVIDAD { get; set; }
       public decimal VALOR_ACTIVIDAD { get; set; }
       public int ID_NACIONALIDAD { get; set; }
       public decimal VALOR_NACIONALIDAD { get; set; }
       public int ID_PAIS { get; set; }
       public decimal VALOR_PAIS { get; set; }
       public int ID_PROVINCIA { get; set; }
       public decimal VALOR_PROVINCIA { get; set; }
       public int ID_CANTIDAD { get; set; }
       public decimal VALOR_CANTIDAD { get; set; }
       public decimal VALOR_PRODUCTO { get; set; }
       public decimal VALOR_CANAL { get; set; }
       public int ID_RECOMENDACION { get; set; }
       public decimal VALOR_TOTAL { get; set; }
    }
}



















