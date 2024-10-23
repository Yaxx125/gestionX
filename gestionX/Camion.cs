using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionX
{
     class Camion : Vehiculo
    {
        public int CapCarga { get; set; }

        public override void Moverse()
        {
            MessageBox.Show($"El {Marca} {Modelo} cuenta con {CapCarga} kilogramos, está listo para arrancar");
        }

        public override void Detenerse()
        {
            MessageBox.Show($"El {Marca} {Modelo} se detuvo.");
        }
    }
}
