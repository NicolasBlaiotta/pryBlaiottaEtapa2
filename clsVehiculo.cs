using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryBlaiottaEtapa2
{
    internal class clsVehiculo
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Image Imagen { get; set; }
        public void crearVehiculo(PictureBox pctVehiculo)
        {
            PictureBox vehiculo = new PictureBox();
            Random rnd = new Random();
            switch (rnd.Next(1, 4))
            {
                case 1:
                    Imagen = pryBlaiottaEtapa2.Properties.Resources.auto;
                    break;
                case 2:
                    Imagen = pryBlaiottaEtapa2.Properties.Resources.barco;
                    break;
                case 3:
                    Imagen = pryBlaiottaEtapa2.Properties.Resources.avion;
                    break;
            }
            vehiculo.Image = Imagen;
            vehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            vehiculo.Location = pctVehiculo.Location;
            vehiculo.Size = pctVehiculo.Size;

            pctVehiculo.Parent.Controls.Add(vehiculo);
            //pctVehiculo.Dispose();
            vehiculo.BringToFront();
        }
    }
}


