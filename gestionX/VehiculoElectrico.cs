using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionX
{
    class VehiculoElectrico : Vehiculo, IVehiculoElectrico
    {
        public int Bateria { get; set; }

        public void CargaBateria()
        {
            MessageBox.Show("Cargando bateria...");
            MessageBox.Show("Bateria cargada");
        }

        public override void Moverse()
        {
            MessageBox.Show($" El {Marca} {Modelo} se está moviendo, carga : {Bateria}% ");
        }
    }
}
