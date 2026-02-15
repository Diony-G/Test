using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLass_Scheme.classes
{
    internal class exalumno : MiembroDeLaComunidad
    {
        public int graduacion { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Año de graduación: {graduacion}");
        }

    }
}
