using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_de_Vehiculos_ordenados
{
    class Inventario
    {
        public  Vehiculo[] _inventario;
         private int Num_Vehiculos;
        public Inventario()
        {
            _inventario = new  Vehiculo[15];
            for(int i=0;i<15; i++)
            {
                _inventario[i] = null;
                Num_Vehiculos=0;
            }
        }
        public void Agregar(Vehiculo V)
        {
  
            if (Num_Vehiculos < 15)
            {
              _inventario[Num_Vehiculos++]=V;
            }
        }
        public void Ordenar(Vehiculo Ordenar)
        {
            for (int orden=0; orden < Num_Vehiculos; orden++)// mientras  orden se a menor de numero de vehiculos, has el ciclo e incrementa orden
            {
                if (_inventario[orden] != null) // si inventario es diferente de nulo entnces has lo siguiente
                {/*CompareTO= Compara esta instancia con un Object especificado
                    e indica si la posición de esta instancia es anterior, posterior o igual 
                    que la posición del Object especificado en el criterio de ordenación.*/
                    if (Ordenar.Placa.CompareTo(_inventario[orden].Placa) < 0)
                    {// Ordenar con metodo Placa compara los valores de inventario con la placa   sea menor que cero
                        for (int i = Num_Vehiculos; i > orden; i--) // i es igual a numero de vehiculos, i sea mayor que orden, i decrementa
                        {
                           _inventario[i] = _inventario[i - 1];
                           // inventario[valor de i] es igual a inventario[valor de i resta 1]
                        }
                        _inventario[orden] = Ordenar; // inventario[valor de orden] es igual a Ordenar
                        orden= Num_Vehiculos; // orden es igual a numero de vehiculos
                    }
                }
           }

        }
        public Vehiculo Buscar(string placa)
        {
            Vehiculo V= _inventario[0];
            for(int i=0; i<Num_Vehiculos; i++) // iniciamos el ciclo  para contar dentro del vector
            if (placa == _inventario[i].Placa)
                {
                    V = _inventario[i];
                    break;
                }
            else
                {
                    V = null;
                }
            return V;
        }
        public void Eliminar(string placa)
        {
            for(int i=0; i<Num_Vehiculos; i++)
                if (placa == _inventario[i].Placa)
                { 
                    for(int j = i + 1; j < Num_Vehiculos; j++)
                    {
                        _inventario[i-1] = _inventario[j];
                    }
                    _inventario[Num_Vehiculos--] = null;
                 }
        }
        public string Lista() 
        {
            string lista = "";
            for(int i = 0; i < Num_Vehiculos; i++)
            {
                lista += _inventario[i]+Environment.NewLine;
            }
            return lista;
        }
        public override string ToString()
        {
            return Num_Vehiculos.ToString();
        }

    }
}
