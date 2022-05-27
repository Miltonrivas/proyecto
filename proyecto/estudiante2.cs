using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    internal class estudiante2
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Seccion { get; set; }
        public string Id_genero { get; set; }
        public string Foto { get; set; }
        public string Fecha { get; set; }
        public estudiante2() { }
        public estudiante2(int pId, string pNombre, string pSeccion, string pGenero,
        string pFoto, string pFecha)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Seccion = pSeccion;
            this.Id_genero = pGenero;
            this.Foto = pFoto;
            this.Fecha = pFecha;
        }
    }
}
