using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionX
{
    class Auto : Vehiculo
    {
        public int CantPasajeros { get; set; }

        public override void Moverse()
        {
            MessageBox.Show($"El {Marca} {Modelo} con {CantPasajeros} pasajeros, esta listo");
        }

        public override void Detenerse()
        {
            MessageBox.Show($"El {Marca} {Modelo} se detuvo");
        }
    }
}
