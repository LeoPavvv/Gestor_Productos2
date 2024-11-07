using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Productos2
{
    public class Producto
    {
        public int Id { get; set; }
        public string descripcion { get; set; }

        public decimal precio { get; set; }

        public override string ToString()
        {
            return "Producto: ID " + this.Id + " Precio " + this.precio + " Descripcion " + this.descripcion;
        }

        public Producto()
        { 
        
        }

        public Producto(int id, string descripcion, decimal precio)
        {
            this.Id = id;
            this.descripcion = descripcion;
            this.precio = precio;
        }
    }
}
