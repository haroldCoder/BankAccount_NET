using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Banco
    {
        Cliente cliente1;
        Cliente cliente2;
        Cliente cliente3;
        public Banco(Cliente cliente1, Cliente cliente2, Cliente cliente3) {
            this.cliente3 = cliente3;
            this.cliente1 = cliente1;
            this.cliente2 = cliente2;
        }
        public void Operar(double deposito, Cliente client)
        {
            Console.WriteLine("el usuario "+client.getNombre()+" deposito: $"+deposito);
        }
        public void DespositosTotales()
        {
            Console.WriteLine("El usuario " + this.cliente1.getNombre() + " tiene $" + this.cliente1.getMonto());
            Console.WriteLine("El usuario " + this.cliente2.getNombre() + " tiene $" + this.cliente2.getMonto());
            Console.WriteLine("El usuario " + this.cliente3.getNombre() + " tiene $" + this.cliente3.getMonto());
        }
    }
}
