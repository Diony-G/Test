using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLass_Scheme.classes
{
    internal class empleado : MiembroDeLaComunidad
    {
        public decimal Salario { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Salario: {Salario}");
        }
    }
}
