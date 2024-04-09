using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TurismoApiWeb.Modells
{

    public class Lugares
    {
        public int Id_lugar { get; set; }
        public string Nombre_lugar { get; set; } = string.Empty;
        public string Direccion_lugar { get; set; } = string.Empty;
        public int Contacto_lugar { get; set; }


    }

}
