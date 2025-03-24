using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2
{
    public class ClienteIndividual : Cliente
    {
        public int CantidadCuentasActivas { get; set; }
        public ClienteIndividual(string nombre, int identificacion, double saldoInicial, int cantidadCuentasActivas) : base(nombre, identificacion, saldoInicial)
        {
            if (cantidadCuentasActivas < 0 || cantidadCuentasActivas > 3)
            {
                throw new ArgumentException("La cantidad de cuentas activas debe estar entre 0 y 3.");
            }
            CantidadCuentasActivas = cantidadCuentasActivas;
        }
        public override double CalcularBeneficio()
        {
            return 50000 * CantidadCuentasActivas;
        }
    }
}
