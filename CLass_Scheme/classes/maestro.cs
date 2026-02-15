using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLass_Scheme.classes
{
    internal class maestro : docente
    {
        public string Nivel { get; set; } // Primaria, Secundaria, etc.

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Nivel: {Nivel}");
        }
    }
}
