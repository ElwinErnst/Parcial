using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    class Paciente
    {
        int id;
        string nombre;
        DateTime fechanacimiento;

        public Paciente(int id, string nombre, DateTime fechanacimiento)
        {
            this.id = id;
            this.nombre = nombre;
            this.fechanacimiento = fechanacimiento;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
    }
}
