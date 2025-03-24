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
                GestorClientes.Ins.AgregarCliente(nuevoCliente);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
