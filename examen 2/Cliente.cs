using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2
{
    public abstract class Cliente
    {
        public string Nombre { get; set; }
        public int Identificacion { get; set; }
        public double Saldo { get; set; }

        public Cliente(string nombre, int identificacion, double saldo) 
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacio");
            }
            if (identificacion <= 0)
            {
                throw new ArgumentException("El numero de identificacion debe ser mayor a cero");
            }

            if (saldo <= 0)
            {
                throw new ArgumentException("El salario base debe ser mayor a cero");
            }

            Nombre = nombre;
            Identificacion = identificacion;
            Saldo = saldo;
        }
        public abstract double CalcularBeneficio();
    }
}
