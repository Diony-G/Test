using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLass_Scheme.classes
{
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public string id { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, ID: {id}");
        }


    }
}
