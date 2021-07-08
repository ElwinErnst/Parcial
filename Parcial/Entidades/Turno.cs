using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    class Turno
    {
        int id;
        DateTime t;
        Paciente p;
        Medico m;

        public Turno(int id, DateTime t, Paciente p, Medico m)
        {
            this.id = id;
            this.t = t;
            this.p = p;
            this.m = m;
        }
        public Turno() { }

        public int Id { get => id; set => id = value; }
        public DateTime T { get => t; set => t = value; }
        public Paciente P { get => p; set => p = value; }
        public Medico M { get => m; set => m = value; }
    }
}
