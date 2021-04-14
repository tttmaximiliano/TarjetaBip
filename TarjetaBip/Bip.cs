using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaBip
{
    class Bip {

        public static string[] arreglo1 = new string[10];

        ClaseEstatica c = new ClaseEstatica();

        public Bip() {
        }

        private int saldos;

        public int Saldos {
            get { return saldos; }
        }

        public bool Cargar() {
            int monto;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Cargar Tarjeta Bip");
            Console.WriteLine("********************");
            Console.Write("Ingrese Monto a cargar :$");
            

            monto = Int32.Parse(Console.ReadLine());
            if (monto > 0) {
                
            saldos = saldos + monto;
              
            Console.WriteLine("");
            Console.Write("Tu Saldo es =$" + saldos);
            Console.WriteLine("");
            Console.ReadKey();
                return true;

            } else {
                return false;
            }
        }
        public bool Pagar() {
            //arreglo auxiliar
            string[] Arreglo2 = new string[10];
            //fecha y hora actual
            string tiempo = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss tt");


            for (int i = 0; i < 10; i++) {
                Arreglo2[i] = arreglo1[i];
            }
                if (saldos >= c.ValorPasaje()) {

                for (int i = 0; i < 9; i++) {
                    arreglo1[i + 1] = Arreglo2[i];
                }

                Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" Pagar Pasaje");
                    Console.WriteLine("******************");
                    Console.WriteLine(" Saldo = $" + saldos);
                    Console.WriteLine("-" + c.ValorPasaje());
                    saldos = saldos - c.ValorPasaje();
                    Console.WriteLine("Saldo actual es de = $" + saldos);
                    arreglo1[0] = tiempo +" "+ c.ValorPasaje();
                    Console.WriteLine("");
                    Console.ReadKey();
                    return true;

                } else {
                    Console.Write("Tu saldo es insuficiente...");
                    Console.ReadKey();
                    return false;
                }
        }
        public void Imprimir() {
            Console.Clear();
            Console.WriteLine("Historial de Viajes");
            Console.WriteLine("");
            for (int f = 0; f <= 9; f++) {
                Console.WriteLine(arreglo1[f]);
            }
            Console.ReadKey();
        }
        public void Salir() {
            Console.Clear();
            Console.Write("Saliendo...");
            Console.WriteLine("Retire su Comprobante");
            Console.ReadKey();
        }
        public void ConSaldo() {
            Console.Write("Saldo en la tarjeta Bip = $" + saldos);
            Console.ReadKey();
        }

    }
}
