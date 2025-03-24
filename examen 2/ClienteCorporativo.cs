using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2
{
    public class ClienteCorporativo : Cliente
    {
        public bool AccesoLineaCredito { get; set; }
        public ClienteCorporativo(string nombre, int identificacion, double saldo) : base(nombre, identificacion, saldo)
        {
            if (saldo >= 50000000)
            {
                AccesoLineaCredito = true;
            }
            else
            {
                AccesoLineaCredito = false;
            }
        }
        public override double CalcularBeneficio()
        {
            return AccesoLineaCredito ? Saldo * 0.10 : 0;
        }
    }
}
