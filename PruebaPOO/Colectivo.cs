using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPOO
{
    internal class Colectivo
    {
        private const int cantBoletos = 40;

        private int ventaBoletos = 0;
        private int precioboleto = 40;

        private int cantidadEstudiantes = 0;
        private int cantidadJubilado = 0;
        private int cantidadPasajeros = 0;


        public string AgregarPasajero(Pasajero pasajeros)
        {
            if (pasajeros = Estudiante)
            {
                miListaPasajero.Add(pasajeros);
                cantidadEstudiantes++;
                return $"El pasajero {pasajeros.Nombre} {pasajeros.Apellido} se ingresó";
            }
            else (pasajeros = Jubilado) {
                miListaPasajero.Add(pasajeros);
                cantidadJubilado++;
                return $"El pasajero {pasajeros.Nombre} {pasajeros.Apellido} se ingresó";
            }
        else
            {
                miListaPasajero < cantBoletos;
                Console.WriteLine("No se pueden agregar más pasajeros");
            }

            public void VenderBoleto(Pasajero)

        { if (cantidadEstudiantes++) {
                this.precioboleto = this.ventaBoletos++;
                this.ventaBoletos/2;
            }
            else (cantidadPasajeros){
                this.precioboleto= this.ventaBoletos++;
            }
            else(cantidadJubilado++){
                this.precioboleto = null;
            }

        }

        public Colectivo() { 
        
        miListaPasajero = new List<Pasajero>();
        }

        }
        public ReadOnlyCollection<Pasajero> mostrarLista()
        {
            return miListaPasajero.AsReadOnly();
        }
    }
