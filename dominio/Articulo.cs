using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int id { get; set; }
        public int codigo { get; set; }
        public int nombre { get; set; }
        public int descripcion { get; set; }
        public decimal precio { get; set; }

    }
}
