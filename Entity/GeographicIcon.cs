using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoApi.Entity
{
    public class GeographicIcon
    {
        public int Id { get; set; }
        public string Imagen { get; set; }
        public string Denominacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Altura { get; set; }
        public string Historia { get; set; }

         //TODO relción con ciudad
         public City City { get; set; }

    }
}
