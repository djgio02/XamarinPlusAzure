using System;
namespace ServiciosWeb.Entities
{
    public class WeatherResponse
    {
        public Location location { get; set; }
        public Weather current { get; set; }
    }
}
