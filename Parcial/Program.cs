using System;
using Parcial.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Parcial
{
    class Program
    {
        public static List<Paciente> pacientes;
        public static List<Medico> medicos;
        public static List<Especialidad> especialidades;
        public static List<Turno> turnos;

        static void Main(string[] args)
        {
            pacientes = new List<Paciente>();
            turnos = new List<Turno>();
            medicos = new List<Medico>();
            especialidades = new List<Especialidad>();
            cargarDatos();
            Menu();
        }

        public static void punto2()
        {
            Especialidad e = especialidades.ElementAt(SeleccionarEspecialidad());
            
            foreach(Medico m in medicos)
            {
                if(e == m.E)
                {
                    Console.WriteLine("ID: {0}, {1}", m.Id.ToString(), m.Nombre);
                }
            }
        }
        
        public static void punto3()
        {
            Medico m = medicos.ElementAt(SeleccionarMedico());
            Turno t = turnos.ElementAt(SeleccionarTurno());
            foreach(Turno tu in turnos)
            {
                if (m == tu.M && t.T == tu.T)
                {
                    Console.WriteLine("Nombre Medico: {0}, Hora Turno {1}", t.M.Nombre, tu.T);
                }
            }
        }

        public static int SeleccionarTurno()
        {
            ListarTurno();
            Console.Write("Seleccione un Turno: ");
            int p = MenuPrincipal.Herramientas.LeerEntero(1, Program.turnos.Count);
            return p - 1;
        }
        public static void ListarTurno()
        {
            Console.Clear();
            foreach (Turno t in Program.turnos)
            {
                Console.WriteLine("{0} - ID: {1}, Fecha: {2}", Program.turnos.IndexOf(t) + 1, t.Id, t.T.ToString());
            }
        }

        public static int SeleccionarMedico()
        {
            ListarMedico();
            Console.Write("Seleccione un Medico: ");
            int p = MenuPrincipal.Herramientas.LeerEntero(1, Program.medicos.Count);
            return p - 1;
        }
        public static void ListarMedico()
        {
            Console.Clear();
            foreach (Medico m in Program.medicos)
            {
                Console.WriteLine("{0} - {1}, {2}", Program.medicos.IndexOf(m) + 1, m.Id, m.Nombre);
            }
        }

        public static void cargarDatos()
        {
            especialidades.Add(new Especialidad(1, "Pediatria"));
            especialidades.Add(new Especialidad(2, "Oncologia"));

            pacientes.Add(new Paciente(1, "Roberto", new DateTime(2008, 03, 09)));
            pacientes.Add(new Paciente(2, "Roberto", new DateTime(2019, 12, 19)));
            pacientes.Add(new Paciente(3, "Roberto", new DateTime(1978, 03, 30)));

            medicos.Add(new Medico(1, "Ariel",especialidades[0]));
            medicos.Add(new Medico(2, "Alex",especialidades[1]));
            
            turnos.Add(new Turno(1, new DateTime(2020, 12, 03, 12, 13, 0), pacientes[0], medicos[1]));
            turnos.Add(new Turno(2, new DateTime(2019, 11, 18, 9, 0, 0), pacientes[1], medicos[0]));

        }

        public static int SeleccionarEspecialidad()
        {
            ListarEspecialidades();
            Console.Write("Seleccione una especialidad: ");
            int p = MenuPrincipal.Herramientas.LeerEntero(1, Program.especialidades.Count);
            return p - 1;
        }
        public static void ListarEspecialidades()
        {
            Console.Clear();
            foreach (Especialidad e in Program.especialidades)
            {
                Console.WriteLine("{0} - {1}, {2}", Program.especialidades.IndexOf(e) + 1, e.Id, e.Nombre);
            }
        }

        public static void Menu()
        {
            Console.Clear();
            string[] opciones = new string[3];

            opciones[0] = "Turnos Por Fecha del Medico";
            opciones[1] = "Listar Medicos Por Especialidad";
            opciones[2] = "Salir";

            MenuPrincipal.Herramientas.DibujoMenu("Clinica", opciones);
            Console.Write("Seleccione una opcion: ");
            int op = MenuPrincipal.Herramientas.LeerEntero(1,3);

            switch (op)
            {
                case 1: punto3(); Console.ReadKey(true); Menu(); break;
                case 2: punto2(); Console.ReadKey(true); Menu(); break;
                case 3: break;

            }
        }
    }
}
