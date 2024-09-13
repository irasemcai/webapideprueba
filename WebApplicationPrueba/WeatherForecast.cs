using System.Data;
using System.Data.SqlClient;
using WebApplicationPrueba.Data;

namespace WebApplicationPrueba
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class conexionTest
    {
        public string PruebaConexion()
        {

            using (SqlConnection connection = new SqlConnection(Conexion.ConexionString))
            {
                try
                {
                    connection.Open();
                    return "Conexión válida";
                }
                catch (Exception exception)
                {
                    return exception.Message;
                }
            }
        }

    }
}