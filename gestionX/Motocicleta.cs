using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionX
{
    sealed class Motocicleta : Vehiculo
    {
        public int CantidadP { get; set; }

        public override void Moverse()
        {
            MessageBox.Show($"La {Marca} {Modelo} está lista y cuenta con {CantidadP} pasajeros.");
        }

        public override void Detenerse()
        {
            MessageBox.Show($"La {Marca} {Modelo} se detuvo");
        }
    }
}
