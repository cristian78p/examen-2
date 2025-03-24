using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2
{
    public static class ClienteFactory
    {
        public static Cliente CrearCliente(string tipo, string nombre, int identificacion, double saldoInicial, int cantidadCuentasActivas = 0 )
        {
            if (tipo == "Corporativo")
            {
                return new ClienteCorporativo(nombre, identificacion, saldoInicial);
            }
            else if (tipo == "Individual")
            {
                return new ClienteIndividual(nombre, identificacion, saldoInicial, cantidadCuentasActivas);
            }
            else
            {
                throw new ArgumentException("Tipo de cliente no válido");
            }
        }
    }
}
