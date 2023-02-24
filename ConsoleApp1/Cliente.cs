using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cliente
    {
        private string nombre;
        private double monto;
        public Cliente(string nombre, double monto)
        {
            this.nombre = nombre;
            this.monto = monto;
        }
        public void Extraer(double monto_plus)
        {
            this.monto -= monto_plus;
        }
        public void Depositar(double monto_mn)
        {
            this.monto += monto_mn;
        }

        public double getMonto()
        {
            return monto;
        }
        public string getNombre() { 
            return nombre;
        }
    }
}
