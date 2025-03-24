using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2
{
    public class GestorClientes
    {
        private static GestorClientes _instancia;
        private List<Cliente> clientes;
        private GestorClientes()
        {
            clientes = new List<Cliente>();
        }
        public static GestorClientes Ins
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new GestorClientes();
                }
                return _instancia;
            }
        }
        public void AgregarCliente(Cliente cliente)
        {
            try
            {
                if (clientes.Any(c => c.Identificacion == cliente.Identificacion))
                {
                    throw new ArgumentException("Ya existe un cliente con esa identificación.");
                }
                clientes.Add(cliente);
            }
            catch (ArgumentException ex)
            {
                throw; 
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el cliente.", ex);
            }
        }
        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        }
        public void EditarCliente(int identificacion, Cliente nuevosDatos)
        {
            try
            {
                var clienteExistente = clientes.FirstOrDefault(c => c.Identificacion == identificacion);
                if (clienteExistente != null)
                {
                    clienteExistente.Nombre = nuevosDatos.Nombre;
                    clienteExistente.SaldoInicial = nuevosDatos.SaldoInicial;
                }
                else
                {
                    throw new ArgumentException("No se encontró un cliente con esa identificación.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el cliente.", ex);
            }
        }
        public void EliminarCliente(Cliente cliente)
        {
            try
            {
                var clienteAEliminar = clientes.FirstOrDefault(c => c.Identificacion == cliente.Identificacion);
                if (clienteAEliminar != null)
                {
                    clientes.Remove(clienteAEliminar);
                }
                else
                {
                    throw new ArgumentException("No se encontró un cliente con esa identificación.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente.", ex);
            }
        }

    }
}
