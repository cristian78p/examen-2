using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace examen_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedIndex == 1)
            {
                txtCuentas.Visible = true;
                labelCuentas.Visible = true;
            }
            else
            {
                txtCuentas.Visible = false;
                labelCuentas.Visible = false;
            }
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string tipo = comboBoxTipo.Text;
                string nombre = txtNombre.Text;
                int identificacion;
                double saldo;
                int cuentasActivas = 0;

                if (string.IsNullOrWhiteSpace(tipo))
                {
                    MessageBox.Show("El tipo de cliente no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtIdentificacion.Text, out identificacion) || identificacion <= 0)
                {
                    MessageBox.Show("Ingrese una identificacion valido mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtSaldo.Text, out saldo) || saldo <= 0)
                {
                    MessageBox.Show("Ingrese un saldo mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(tipo == "Individual")
                {
                    if (!int.TryParse(txtCuentas.Text, out cuentasActivas))
                    {
                        MessageBox.Show("Ingrese un valor valido para el numero de cuentas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (cuentasActivas < 0 || cuentasActivas > 3)
                    {
                        MessageBox.Show("El numero de cuentas activas tiene que ser ente 0 y 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
               

                Cliente nuevoCliente = ClienteFactory.CrearCliente(tipo, nombre, identificacion, saldo, cuentasActivas);
                nuevoCliente.Saldo += nuevoCliente.CalcularBeneficio();
                GestorClientes.Ins.AgregarCliente(nuevoCliente);

                if (nuevoCliente is ClienteCorporativo clienteCorp)
                {
                    if (clienteCorp.AccesoLineaCredito)
                    {
                        MessageBox.Show("Este cliente corporativo aplica para una línea de crédito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Este cliente corporativo no aplica para una línea de crédito (saldo menor a $50,000,000).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                LimpiarCampos();
                CargarDGV();
                MessageBox.Show("Cliente agregado exitosamente.");
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("ingrese valores validos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            
        }
        private void LimpiarCampos()
        {
            txtCuentas.Clear();
            txtNombre.Clear();  
            txtSaldo.Clear();   
            txtCuentas.Clear();
            txtIdentificacion.Clear();
            comboBoxTipo.SelectedIndex = -1;
        }
        private void CargarDGV()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = GestorClientes.Ins.ObtenerClientes();
        }


        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cliente clienteSeleccionado = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;

                txtNombre.Text = clienteSeleccionado.Nombre;
                txtIdentificacion.Text = clienteSeleccionado.Identificacion.ToString();
                txtSaldo.Text = clienteSeleccionado.Saldo.ToString();

                // Determinar el tipo de cliente y ajustar el formulario
                if (clienteSeleccionado is ClienteCorporativo)
                {
                    comboBoxTipo.SelectedItem = "Corporativo";
                    txtCuentas.Visible = false;
                }
                else if (clienteSeleccionado is ClienteIndividual clienteInd)
                {
                    comboBoxTipo.SelectedItem = "Individual";
                    txtCuentas.Visible = true; 
                    txtCuentas.Text = clienteInd.CantidadCuentasActivas.ToString();
                }
            }
        }

        private void bttnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = comboBoxTipo.Text;
                string nombre = txtNombre.Text;
                int identificacion;
                double saldo;
                int cuentasActivas = 0;

                if (string.IsNullOrWhiteSpace(tipo))
                {
                    MessageBox.Show("El tipo de cliente no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtIdentificacion.Text, out identificacion) || identificacion <= 0)
                {
                    MessageBox.Show("Ingrese una identificacion valido mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtSaldo.Text, out saldo) || saldo <= 0)
                {
                    MessageBox.Show("Ingrese un saldo mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tipo == "Individual")
                {
                    if (!int.TryParse(txtCuentas.Text, out cuentasActivas))
                    {
                        MessageBox.Show("Ingrese un valor valido para el numero de cuentas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (cuentasActivas < 0 || cuentasActivas > 3)
                    {
                        MessageBox.Show("El numero de cuentas activas tiene que ser ente 0 y 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Cliente clienteModificado = ClienteFactory.CrearCliente(tipo, nombre, identificacion, saldo, cuentasActivas);
                clienteModificado.Saldo += clienteModificado.CalcularBeneficio();

                GestorClientes.Ins.EditarCliente(identificacion, clienteModificado);

                if (clienteModificado is ClienteCorporativo clienteCorp)
                {
                    if (clienteCorp.AccesoLineaCredito)
                    {
                        MessageBox.Show("Este cliente corporativo aplica para una línea de crédito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Este cliente corporativo no aplica para una línea de crédito (saldo menor a $50,000,000).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                LimpiarCampos();
                CargarDGV();
                MessageBox.Show("Cliente editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdentificacion.Text, out int identificacion) || identificacion <= 0)
                {
                    throw new ArgumentException("Seleccione un cliente válido para eliminar.");
                }

                Cliente clienteAEliminar = ClienteFactory.CrearCliente("Corporativo", "Temp", identificacion, 1); // Tipo y datos irrelevantes

                GestorClientes.Ins.EliminarCliente(clienteAEliminar);

                MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarDGV();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
