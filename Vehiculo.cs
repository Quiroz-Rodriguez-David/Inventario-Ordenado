using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_de_Vehiculos_ordenados
{
    class Vehiculo
    {
        private string _Placa;
        public string Placa { get { return _Placa; } }
        private string _Marca;
        public string Marca{get { return _Marca; } }
        private string _Modelo;
        public string Modelo { get { return _Modelo; } }
        private string _Telefono;
        public string Telefono { get { return _Telefono; } }
        private string _Anio;
        public string Anio { get { return _Anio; } }
        public Vehiculo(string placa, string marca, string modelo, string telefono, string anio)
        {
            _Placa = placa;
            _Marca = marca;
            _Modelo = modelo;
            _Telefono = telefono;
            _Anio = anio;
        }
        public override string ToString()
        {
            return "Placas: " + Placa.ToString()+ Environment.NewLine+"Marca: "+Marca+Environment.NewLine+"Modelo: "+Modelo+Environment.NewLine
                +"Telefono: "+Telefono+Environment.NewLine+"Año: "+ Anio +Environment.NewLine; 
        }

    }
}
