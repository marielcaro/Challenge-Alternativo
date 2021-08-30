using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoApi.Entity
{
    public class City
    {
        public int Id { get; set; }
        public string Imagen { get; set; }
        public string Denominacion { get; set; }

        public int Poblacion { get; set; }

        public int Superficie { get; set; }

        //TODO relción con continente
        public Continent Continet { get; set; }

        //TODO relción con iconos geográficos
        public ICollection<GeographicIcon> GeographicIcons { get; set; }

    }
}
