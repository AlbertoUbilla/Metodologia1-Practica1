using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class Pila : Coleccionable
    {
        private Stack<Comparable>elementos = new Stack<Comparable>();
        public int Cuantos()
        {
            return elementos.Count;
        }
        public Comparable Minimo()
        {
            if (Cuantos() == 0) return null;
            Comparable minimo = elementos.Peek();
            foreach (Comparable c in elementos)
            {
                if (c.sosMenor(minimo))
                {
                    minimo = c;
                }
            }
            return minimo;
        }
        public Comparable Maximo()
        {
            if (Cuantos() == 0) return null;
            Comparable maximo = elementos.Peek();
            foreach (Comparable c in elementos)
            {
                if (c.sosMayor(maximo))
                {
                    maximo = c;
                }
            }
            return maximo;
        }
        public void Agregar(Comparable c)
        {
            elementos.Push(c);
        }
        public bool Contiene(Comparable c)
        {
            //Any es un metodo de LINQ que revisa si hay algun elemento que cumpla con ca condicion que le pase por parametro
            //Uso una expresion Lambda para tomar cada elemento y comparar
            return elementos.Any(aux => aux.sosIgual(c));
        }
        public Comparable Desencolar()
        {
            if (elementos.Count == 0) return null;
            return elementos.Pop(); //Sacar y devolver el primer elemento
        }
    }
}
