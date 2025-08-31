using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class Alumno : Persona
    {
        private int legajo;
        private double promedio;

        public Alumno(int l, double p, string n, int d) : base(n,d)
        {
            this.legajo = l;
            this.promedio = p;
        }
        public int getLegajo()
        {
            return this.legajo;
        }
        public double getPromedio()
        {
            return this.promedio;
        }
        public override bool sosIgual(Comparable c)
        {
            return this.promedio == ((Alumno)c).getPromedio();
        }
        public override bool sosMenor(Comparable c)
        {
            return this.promedio < ((Alumno)c).getPromedio();
        }
        public override bool sosMayor(Comparable c)
        {
            return this.promedio > ((Alumno)c).getPromedio();
        }
        public override string ToString()
        {
            return $"Nombre: {getNombre()}, DNI: {getDni()}, Legajo: {legajo}, Promedio: {promedio}";
        }
    }
}
