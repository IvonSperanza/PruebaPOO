using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPOO
{
    internal class Estudiante: Pasajero {
        private string institucion;
        private int  nroLegajo;

        public string Institucuion { get { return institucion; } set { institucion = value; } }
        public int NroLegajo { get {  return nroLegajo; } set {  nroLegajo = value; } }

        
               
    }
}
