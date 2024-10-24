using Prototipo_con_Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Segundo_Parcial__Práctico_
{
    public partial class Form1 : Form
    {
        private List<IVehiculo> listaVehiculos = new List<IVehiculo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = comboTipoVehiculo.SelectedItem?.ToString();
                if (tipo == null)
                {
                    MessageBox.Show("Selecciona un tipo de vehículo.");
                    return;
                }

                IVehiculo vehiculo = CrearVehiculo(tipo);
                listaVehiculos.Add(vehiculo);
                ActualizarLista();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar vehículo: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listVehiculos.SelectedIndex >= 0)
            {
                listaVehiculos.RemoveAt(listVehiculos.SelectedIndex);
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para eliminar.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (listVehiculos.SelectedIndex >= 0)
            {
                string tipo = comboTipoVehiculo.SelectedItem?.ToString();
                IVehiculo vehiculo = CrearVehiculo(tipo);
                listaVehiculos[listVehiculos.SelectedIndex] = vehiculo;
                ActualizarLista();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Selecciona un vehículo para actualizar.");
            }
        }
        private IVehiculo CrearVehiculo(string tipo)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            int año = int.Parse(txtAño.Text);

            switch (tipo)
            {
                case "Automóvil":
                    int puertas = int.Parse(txtPuertas.Text);
                    return new Automovil(marca, modelo, año, puertas);

                case "Motocicleta":
                    bool tieneSidecar = chkSidecar.Checked;
                    return new Motocicleta(marca, modelo, año, tieneSidecar);

                case "Bicicleta":
                    string tipoBicicleta = txtTipo.Text;
                    return new Bicicleta(marca, modelo, año, tipoBicicleta);

                default:
                    throw new Exception("Tipo de vehículo no válido.");
            }
        }

        private void ActualizarLista()
        {
            listVehiculos.Items.Clear();
            foreach (var vehiculo in listaVehiculos)
            {
                listVehiculos.Items.Add(vehiculo.ToString());
            }
        }
        private void LimpiarCampos()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtAño.Clear();
            txtPuertas.Clear();
            txtTipo.Clear();
            chkSidecar.Checked = false;
            comboTipoVehiculo.SelectedIndex = -1;
        }

    }
}