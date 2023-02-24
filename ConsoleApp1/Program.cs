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
            Cliente cliente1 = new Cliente("harold", 220);
            Cliente cliente2 = new Cliente("juan", 600);
            Cliente cliente3 = new Cliente("carlos", 400);
            Banco banco = new Banco(cliente1, cliente2, cliente3); 
            int opc = 0;
            char seguir = 'S';
            string user = "";
            Cliente client = new Cliente("", 0);
            do
                {
                    Console.WriteLine("Que usuario quiere usar");
                    Console.WriteLine("Usuario 1");
                    Console.WriteLine("Usuario 2");
                    Console.WriteLine("Usuario 3");

                    user = Console.ReadLine();
                    switch(user) {
                        case "Usuario 1":
                            client = cliente1;
                            break;
                        case "Usuario 2":
                            client = cliente2;
                            break;
                        case "Usuario 3":
                            client = cliente3;
                            break;
                    }
              } while (user == "");
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
                        client.Depositar(depo);
                        banco.Operar(depo, client);
                        break;
                    case 2:
                        Console.WriteLine("Dijite el monto que va a extraer");
                        double extra = double.Parse(Console.ReadLine());
                        client.Extraer(extra);
                        break;
                    case 3:
                        Console.WriteLine("Su monto es: "+ client.getMonto());
                        break;
                }

                Console.WriteLine("Desea seguir utilizando el programa (S/N)");
                seguir = char.Parse(Console.ReadLine());

                if (seguir != 's' || seguir != 'S')
                {
                    banco.DespositosTotales();
                }
            } while (seguir == 'S' || seguir == 's');

            Console.ReadKey();
        }
    }
}
