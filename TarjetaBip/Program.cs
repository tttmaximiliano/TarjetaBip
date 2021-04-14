
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaBip{
    class Program{
        
        static void Main(string[] args){

            Bip b = new Bip();

            string opcion = "";

            while (true) {

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Bienvenido");
                Console.WriteLine("Tarjeta Bip");
                Console.WriteLine("=====================");
                Console.WriteLine("");

                Console.WriteLine("1 - Saldo tarjeta Bip");
                Console.WriteLine("2 - Cargar");
                Console.WriteLine("3 - Pagar");
                Console.WriteLine("4 - Historial de viajes");
                Console.WriteLine("5 - Salir");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Elija una opción : ");

                //Formato de fecha
                //Console.WriteLine(fechaHoy.ToString("dd/MM/yyyy HH:mm:ss tt"));

                opcion = Console.ReadLine();

                //c1.Valores_Pasaje(0)

                Console.ReadKey();

                switch (opcion) {
                    case "1":
                        b.ConSaldo();
                        break;

                    case "2":
                        b.Cargar();
                       
                        break;

                    case "3":
                        b.Pagar();
                        break;
                    case "4":
                        b.Imprimir();
                        break;

                    case "5":
                        b.Salir();
                        break;

                    default:

                        break;
                       
                }
            }
        }
    }
}
