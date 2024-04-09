using System;
using System.Collections.Generic;
using System.Text;

namespace UsoApiTurismo
{
    public class ApiResponse
    {
        public string Mensaje { get; set; }
        public List<lugares> Response { get; set; }
    }
}
