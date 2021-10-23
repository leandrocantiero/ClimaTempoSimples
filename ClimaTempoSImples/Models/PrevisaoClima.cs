using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClimaTempoSImples.Models
{
    public class PrevisaoClima
    {
        public int Id { get; set; }
        public String Clima { get; set; }
        public float TempMin { get; set; }
        public float TempMax { get; set; }
    }
}