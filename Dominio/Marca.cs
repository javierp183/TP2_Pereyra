using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            //Estoy haciendo esto, como para probar pero claro, me putea por que es un Int.. pero raro, en el ejemplo de Pokemon lo probo.
            return Descripcion;
        }
    }
}
