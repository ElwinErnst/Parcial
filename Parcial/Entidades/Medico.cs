using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    class Medico
    {
        int id;
        string nombre;
        Especialidad e;

        public Medico(int id, string nombre, Especialidad e)
        {
            this.id = id;
            this.nombre = nombre;
            this.e = e;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Especialidad E { get => e; set => e = value; }
    }
}
