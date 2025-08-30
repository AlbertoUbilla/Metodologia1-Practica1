using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class Cola : Coleccionable
    {
        private Queue<Comparable> elementos = new Queue<Comparable>();
        public int Cuantos()
        {
            return elementos.Count;
        }
        public Comparable Minimo()
        {
            if(Cuantos() == 0) return null;
            Comparable minimo = elementos.Peek();
            foreach(Comparable c in elementos)
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
            if(Cuantos()== 0) return null;
            Comparable maximo = elementos.Peek();
            foreach(Comparable c in elementos)
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
            elementos.Enqueue(c);
        }
        public bool Contiene(Comparable c)
        {
            //Any es un metodo de LINQ que revisa si hay algun elemento que cumpla con ca condicion que le pase por parametro
            //Uso una expresion Lambda para tomar cada elemento y comparar
            return elementos.Any(aux => aux.sosIgual(c));
        }
        public Comparable Desencolar()
        {
            if(elementos.Count == 0) return null;
            return elementos.Dequeue(); //Sacar y devolver el primer elemento
        }
    }
}
