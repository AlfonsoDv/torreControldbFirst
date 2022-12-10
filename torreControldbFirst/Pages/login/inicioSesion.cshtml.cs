using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;
using torreControldbFristDAL.Modelo;

namespace torreControldbFirst.Pages.modelo
{
    public class inicioSesionModel : PageModel
    {
        public void OnGet()
        {
        }

        [HttpPost]
        [ActionName("Login")]
        public void OnPost(DlkCatAccEmpleado empleado)
        {
            //Recogemos la informaci�n de la vista
            //Hacemos la conexion
            var connection = new NpgsqlConnection("Host=localhost;Port=5432;Pooling=true;Database=cspharma_informacional;UserId=postgres;Password=Alfminecraft2612#;");
            Console.WriteLine("[INFORMACION]: Abriendo conexi�n");
            connection.Open();

            NpgsqlCommand consulta = new NpgsqlCommand($"SELECT * FROM \"dlk_informacional\".\"dlk_cat_acc_empleados\" WHERE cod_empleado='{empleado.CodEmpleado}' AND clave_empleado='{empleado.ClaveEmpleado}'", connection);
            NpgsqlDataReader resultadoConsulta = consulta.ExecuteReader();


            if (resultadoConsulta.HasRows)
            {
                Console.WriteLine("Ha iniciado sesion con exito");
            }
            else
            {
                Console.WriteLine("** ERROR: El usuario o contrase�as no son correctos **");
            }

            Console.WriteLine("Cerrando conexion");
            connection.Close();
        }
    }
}
