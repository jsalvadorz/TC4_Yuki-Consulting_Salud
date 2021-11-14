using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_01
{
    class ColaDePrioridad
    {
        public void RecorrerCola(Nodo header)
        {
            Console.WriteLine("============ INICIO DE COLA DE PACIENTES ============");
            Console.WriteLine("-----------------------------------------------------");
            Nodo temp = new Nodo();
            while (!isEmpty(header))
            {
                Console.WriteLine("ID: " + header.dato.id + " | " + header.dato.nombre + " " +
                    header.dato.apellido + " | Prioridad: " + header.dato.prioridad);
                temp = header;
                header = header.next;
            }
            Console.WriteLine("============= FIN DE COLA DE PACIENTES =============\n");
        }

        public Nodo NuevoNodo(Paciente dato, int prioridad)
        {
            Nodo temp = new Nodo();
            temp.dato = dato;
            temp.dato.prioridad = prioridad;
            temp.next = null;
            return temp;
        }

        public Nodo push(Nodo header, Paciente dato, int prioridad)
        {
            Nodo puntero = header;
            Nodo temp = NuevoNodo(dato, prioridad);
            if (header.dato.prioridad > prioridad)
            {
                temp.next = header;
                header = temp;
            }
            else
            {
                while (puntero.next != null && puntero.next.dato.prioridad < prioridad)
                {
                    puntero = puntero.next;
                }
                temp.next = puntero.next;
                puntero.next = temp;
            }
            return header;
        }

        public Nodo pop(Nodo header)
        {
            Nodo temp = header;
            (header) = (header).next;
            return header;
        }

        public bool isEmpty(Nodo header)
        {
            if (header == null) return true;
            return false;
        }
    }
}
