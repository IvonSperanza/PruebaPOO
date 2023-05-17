using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {   Colectivo colectivo = new Colectivo();
            Pasajero pasajero = new Pasajero();
            Estudiante estudiante = new Estudiante();
            Jubilado jubilado = new Jubilado();

            Console.WriteLine("Ingrese una opción: ");
            string resp = Console.ReadLine();
            int op = Convert.ToInt32(resp);

            Console.WriteLine("Ingrese la opción: 1) Para estudiantes " +
                "2)Para jubilados" +
                "3)Si desea agregar un pasajero común"+
                " 4)Si desea ver la lista de pasajeros" +
                "5) Si quiere ver cuánto se recaudó");
            do
            {
                switch (op)
                {
                    case 1: Console.WriteLine("Ingrese nombre del pasajero: ");
                        string pnombre = Console.ReadLine();
                        estudiante.Nombre = pnombre;

                        Console.WriteLine("Ingrese Apellido del pasajero: ");
                        string apellido = Console.ReadLine();
                        estudiante.Apellido = apellido;

                        Console.WriteLine("Ingrese DNI del pasajero: ");
                        string respdni = Console.ReadLine();
                        int dni = Convert.ToInt32(respdni);
                        estudiante.Dni = dni;

                        Console.WriteLine("Ingrese Institucion a la que asiste: ");
                        string institucion = Console.ReadLine();
                        estudiante.Institucuion = institucion;

                        Console.WriteLine("Ingrese Nro. de Legajo");
                        string respnro = Console.ReadLine();
                        int nroLegajo = Convert.ToInt32(respnro);
                        estudiante.NroLegajo = nroLegajo;

                        Console.WriteLine("Posee un descuento del 50%");
                        Console.WriteLine(colectivo.AgregarPasajero(estudiante));
                        Console.WriteLine();

                        

                        break;

                    case 2:

                        Console.WriteLine("Ingrese nombre del pasajero: ");
                        string nombre = Console.ReadLine();
                        jubilado.Nombre = nombre;

                        Console.WriteLine("Ingrese Apellido del pasajero: ");
                        string apellidoJ = Console.ReadLine();
                        jubilado.Apellido = apellidoJ;

                        Console.WriteLine("Ingrese DNI del pasajero: ");
                        string resdni = Console.ReadLine();
                        int dniJ = Convert.ToInt32(resdni);
                        jubilado.Dni = dniJ;

                        Console.WriteLine("Ingrese nro de afiliado del PAMI: ");
                        string resnro = Console.ReadLine();
                        int nroAfiliado = Convert.ToInt32(resnro);
                        jubilado.NroAfiliado = nroAfiliado;
                        Console.WriteLine("Posee el boleto totalmente gratuito");
                        Console.WriteLine(colectivo.AgregarPasajero(jubilado));
                        Console.WriteLine();

                        break;

                        case 3:
                        Console.WriteLine("Ingrese nombre del pasajero: ");
                        string nombreP = Console.ReadLine();
                        pasajero.Nombre = nombreP;

                        Console.WriteLine("Ingrese Apellido del pasajero: ");
                        string apellidoP = Console.ReadLine();
                        pasajero.Apellido = apellidoP;

                        Console.WriteLine("Ingrese DNI del pasajero: ");
                        string redni = Console.ReadLine();
                        int dniP = Convert.ToInt32(redni);
                        pasajero.Dni = dniP;

                        colectivo.VenderBoleto; //Cuenta boletos en su totalidad


                    case 4:

                        foreach (var item in Pasajero.mostrarLista())//muestra la lista
                        {
                            Console.WriteLine(item.ToString());
                        }

                        Console.WriteLine();
                        break;
                case 5: Console.WriteLine(colectivo.VenderBoleto); //Muestra lo recaudado
                        Console.ReadKey();
                }

            } while (!== 0);
        
        }
    }
}
