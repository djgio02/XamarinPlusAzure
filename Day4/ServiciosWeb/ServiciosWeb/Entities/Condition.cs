using System;
namespace ServiciosWeb.Entities
{
    public class Condition
    {
        public string text { get; set; }
        public string icon { get; set; }
        public string IconUrl { 
            get
            {
                return $"http:{icon}";
            }
        }
    }
}
