using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_01
{
    class Paciente
    {
        public string id;
        public int prioridad;
        public string nombre, apellido;

        public Paciente(string id, int prioridad, string nombre, string apellido)
        {
            this.id = id;
            this.prioridad = prioridad;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
