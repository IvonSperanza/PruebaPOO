using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPOO
{
    internal class Pasajero
    {
        private string nombre;
        private string apellido;
        private int dni;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get {  return apellido; } set {  apellido = value; } }
        public int Dni { get {  return dni; } set {  dni = value; } }


    }
}
