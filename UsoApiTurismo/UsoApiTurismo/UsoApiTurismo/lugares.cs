using System;
using System.Collections.Generic;
using System.Text;

namespace UsoApiTurismo
{
    public class lugares
    {
        public int Id_lugar { get; set; }
        public string Nombre_lugar { get; set; } = string.Empty;
        public string Direccion_lugar { get; set; } = string.Empty;
        public int Contacto_lugar { get; set; }
    }
}
