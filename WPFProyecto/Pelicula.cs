using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProyecto
{
    class Pelicula
    {
        private String nombre;
        private int anio;
        private String director;

        public Pelicula(String nombre, int anio, String director)
        {
            this.nombre = nombre;
            this.anio = anio;
            this.director = director;
            
        }

        public String MiNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
