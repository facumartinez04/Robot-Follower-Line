using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain
{
    public class Parlante
    {
        public void EmitirSonido()
        {
            MessageBox.Show("Advertencia sonora: Robot fuera de la línea.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
