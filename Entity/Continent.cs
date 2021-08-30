using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoApi.Entity
{
    public class Continent
    {
        public int Id { get; set; }
        public string Imagen { get; set; }
        public string Denominacion { get; set; }

        //TODO relción con ciudades
        public ICollection<City> Cities { get; set; }

        //TODO relción con iconos geográficos
        public ICollection<GeographicIcon> GeographicIcons { get; set; }


    }
}
