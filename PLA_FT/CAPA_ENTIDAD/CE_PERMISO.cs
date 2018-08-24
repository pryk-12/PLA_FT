
namespace CAPA_ENTIDAD
{
   public class CE_PERMISO
    {
       //OPCIONES DE MENU
        public string MENU_USUARIO { get; set; }
        public string MENU_MENU { get; set; }
        public bool MENU_ACCESO { get; set; }

       //PANTALLAS
        public string PERMISO_USUARIO { get; set; }
        public string PERMISO_PANTALLA { get; set; }
        public bool PERMISO_ACCESO { get; set; }
        public bool PERMISO_AGREGAR { get; set; }
        public bool PERMISO_EDITAR { get; set; }
    }
}
