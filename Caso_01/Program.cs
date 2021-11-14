using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1 = new Paciente("1", 1, "Andre", "Martinez Flores");
            Paciente paciente2 = new Paciente("2", 2, "Luis", "Quiroga Horna");
            Paciente paciente3 = new Paciente("3", 3, "Matilde", "Flores Llosa");
            Paciente paciente4 = new Paciente("4", 4, "Xiomara", "Ávila Ramírez");
            Paciente paciente5 = new Paciente("5", 5, "Pedro", "Salvador Ruíz");

            Nodo colaEspera = null;
            ColaDePrioridad lista = new ColaDePrioridad();

            Console.WriteLine("====================================================");
            Console.WriteLine("||     Atención de Pacientes: Yuki Consulting     ||");
            Console.WriteLine("====================================================\n");

            // Insertando cola inicial de cinco (05) pacientes según orden de llegada
            Console.WriteLine("::::::::::::: COLA DE PACIENTES CON PRIORIDAD NORMAL :::::::::::::");
            colaEspera = lista.NuevoNodo(paciente1, paciente1.prioridad);
            colaEspera = lista.push(colaEspera, paciente2, paciente2.prioridad);
            colaEspera = lista.push(colaEspera, paciente3, paciente3.prioridad);
            colaEspera = lista.push(colaEspera, paciente4, paciente4.prioridad);
            colaEspera = lista.push(colaEspera, paciente5, paciente5.prioridad);
            lista.RecorrerCola(colaEspera);

            // Procesando (eliminando) dos (02) pacientes
            Console.WriteLine("::::::::::::: PROCESANDO DOS PACIENTES :::::::::::::");
            colaEspera = lista.pop(colaEspera);
            colaEspera = lista.pop(colaEspera);
            lista.RecorrerCola(colaEspera);

            // Insertando un (01) paciente con prioridad alta (prioridad: 0)
            Console.WriteLine("::::::::::::: PRIORIZANDO PACIENTE :::::::::::::");
            Paciente paciente0 = new Paciente("6", 0, "Laura", "Campos Valera");
            colaEspera = lista.push(colaEspera, paciente0, paciente0.prioridad);
            Console.WriteLine("- Insertando paciente de alta prioridad. ID: " + paciente0.id + " - " +
                paciente0.nombre + " " + paciente0.apellido);
            lista.RecorrerCola(colaEspera);

            // Procesando (eliminando) otros dos (02) pacientes de la cola
            Console.WriteLine("::::::::::::: PROCESANDO DOS PACIENTES MÁS DE LA COLA :::::::::::::");
            colaEspera = lista.pop(colaEspera);
            colaEspera = lista.pop(colaEspera);
            lista.RecorrerCola(colaEspera);

            Console.ReadKey();
        }
    }
}
