using CLass_Scheme.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLass_Scheme.manejo
{
    public class ComunidadService
    {
        private List<MiembroDeLaComunidad> miembros = new List<MiembroDeLaComunidad>();

        public void Agregar(MiembroDeLaComunidad miembro)
        {
            miembros.Add(miembro);
        }

        public void ShowAll()
        {
            foreach (var miembro in miembros)
            {
                miembro.ShowInfo();
                Console.WriteLine("------------------");
            }
        }

        public void ShowProfesores()
        {
            foreach (var miembro in miembros)
            {
                if (miembro is docente)
                {
                    miembro.ShowInfo();
                    Console.WriteLine("------------------");
                }
            }
        }

        public void ShowEstudiantes()
        {
            foreach (var miembro in miembros)
            {
                if (miembro is estudiante)
                {
                    miembro.ShowInfo();
                    Console.WriteLine("------------------");
                }
            }
        }
    }
}
