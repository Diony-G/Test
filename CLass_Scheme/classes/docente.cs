using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLass_Scheme.classes
{
    internal class docente : empleado
    {
        public string Materia { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Materia: {Materia}");
        }
    }
}
