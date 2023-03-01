using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente []clientes = new Cliente[3];

            clientes[0] = new Cliente("harold", 220);
            clientes[1] = new Cliente("juan", 600);
            clientes[2] = new Cliente("carlos", 400);

            Banco banco = new Banco(clientes[0], clientes[1], clientes[2]); 
            int opc = 0;
            char seguir = 'S';
            int user;
            int index_user = 0;
            Console.WriteLine("Que usuario quiere usar");
            Console.WriteLine("Usuario 1 (1)");
            Console.WriteLine("Usuario 2 (2)");
            Console.WriteLine("Usuario 3 (3)");
            Console.WriteLine("Dijite el numero del usuario \n");

            user = int.Parse(Console.ReadLine());
            switch(user) {
                case 1:
                    index_user = 0;
                    break;
                case 2:
                    index_user = 1;
                    break;
                case 3:
                    index_user = 2;
                    break;
                default:
                    Console.WriteLine("Su usuario es el numero 1");
                    break;
            }
            Console.WriteLine("Bienvenido!");

            do
            {
                
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Extraer");
                Console.WriteLine("3. Retornar monto");

                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Dijite el monto que va a depositar");
                        double depo = double.Parse(Console.ReadLine());
                        clientes[index_user].Depositar(depo);
                        banco.Operar(depo, clientes[index_user]);
                        break;
                    case 2:
                        Console.WriteLine("Dijite el monto que va a extraer");
                        double extra = double.Parse(Console.ReadLine());
                        clientes[index_user].Extraer(extra);
                        break;
                    case 3:
                        Console.WriteLine("Su monto es: "+ clientes[index_user].getMonto());
                        break;
                }

                Console.WriteLine("Desea seguir utilizando el programa (S/N)");
                seguir = char.Parse(Console.ReadLine());

                if (seguir != 's' || seguir != 'S')
                {
                    banco.DespositosTotales();
                }
            } while (seguir == 'S' || seguir == 's');
        }
    }
}
