using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurismoApiWeb.Modells;

namespace TurismoApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LugarController : ControllerBase
    {
        public List<Lugares> ListLugares;
        public LugarController()
        {
            ListLugares = new List<Lugares>();

            ListLugares.Add(new Lugares()
            {

                Id_lugar = 1,
                Nombre_lugar = "Finca Rauda",
                Direccion_lugar = "Aleria, Usulutan",
                Contacto_lugar = 75896545
            });

            ListLugares.Add(new Lugares()
            {

                Id_lugar = 2,
                Nombre_lugar = "Aqua Park",
                Direccion_lugar = "San Miguel",
                Contacto_lugar = 78144512
            });
            ListLugares.Add(new Lugares()
            {

                Id_lugar = 3,
                Nombre_lugar = "montegrande",
                Direccion_lugar = "San Miguel",
                Contacto_lugar = 324234234
            });
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(ListLugares)
;
        }

        [HttpGet("Get")]

        public IActionResult Get(int id)
        {
            Lugares lugar;

            foreach (var item in ListLugares)
            {
                if (item.Id_lugar == id)
                {
                    lugar = item;
                    return Ok(item);

                }
            }
            return BadRequest("El estudiante no existe");


        }


        [HttpPost("Add_lugar")]

        public IActionResult Add_lugar(
            int Id,
            string Nombre,
            string Direccion,
            int Contacto

            )
        {
            ListLugares.Add(
                new Lugares
                {
                    Id_lugar = Id,
                    Nombre_lugar = Nombre,
                    Direccion_lugar = Direccion,
                    Contacto_lugar = Contacto

                }


                );
            return Ok(ListLugares);

        }

        [HttpPut("Mod_Lugar")]

        public IActionResult Mod_Lugar(
            int Id,
            string Nombre,
            string Direccion,
            int Contacto


           )
        {

            // Este codigo nos sirve para buscar el registro del areglo
            bool existe = false;
            int index = 0;
            foreach (var item in ListLugares)
            {
                index++;
                if (item.Id_lugar == Id)
                {

                    ListLugares.Remove(item);
                    existe = true;
                    break;

                }
            }

            if (!existe)
            {
                return BadRequest("No se encontro");
            }

            ListLugares.Insert(index - 1,
             new Lugares
             {
                 Id_lugar = Id,
                 Nombre_lugar = Nombre,
                 Direccion_lugar = Direccion,
                 Contacto_lugar = Contacto

             }
          );


            return Ok(ListLugares);
        }


        [HttpDelete("Delete_lugar")]
        public IActionResult Delete_lugar(int Id)
        {


            foreach (var item in ListLugares)
            {
                if (item.Id_lugar == Id)
                {

                    ListLugares.Remove(item);
                    return Ok("Se elimino correctamente");

                }
            }

            return BadRequest("No se encontro el registro");

        }




    }

}
