using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_de_Vehiculos_ordenados
{
    public partial class Form1 : Form
    {
        Vehiculo vehiculo;
        Inventario inventario;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            vehiculo = inventario.Buscar(TxtPlacas.Text);
            if (vehiculo != null)
            {
                TxtMostrar.Text = vehiculo.ToString();
                TxtPlacas.Clear();
                TxtPlacas.Focus();
            }
            else
                MessageBox.Show("No`existe ningun vehiculo con ese numero de placa en el inventario");
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            string placa=TxtPlacas.Text;
            string marca=TxtMarca.Text;
            string modelo=TxtModelo.Text;
            string telefono=TxtTelefono.Text;
            string anio=TxtAnio.Text;
            vehiculo = new Vehiculo(placa,marca,modelo,telefono,anio);
            inventario.Agregar(vehiculo);// una vez que se agregen los registros los ordenaremos con este metodo
            inventario.Ordenar(vehiculo);
            TxtPlacas.Clear();
            TxtMarca.Clear();
            TxtModelo.Clear();
            TxtTelefono.Clear();
            TxtAnio.Clear();
            TxtPlacas.Focus();
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            inventario.Eliminar(TxtPlacas.Text);
            MessageBox.Show("El vehiculo fue eliminado correctamente");
        }

        private void CmdLista_Click(object sender, EventArgs e)
        {
           
          TxtMostrar.Text=inventario.Lista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inventario = new Inventario();
        }
    }
}
