using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class WeatherModel
    {
        [Required]
        public DateOnly? Date { get; set; }


        [Required]
        public double? Temp { get; set; }

        
        [Required]
        public int? Humidity { get; set; }

        
        [Required, MinLength(3), MaxLength(30)]
        public string? weather { get; set; }

    }
}
